using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using MNM = Microsoft.Azure.Management.Network.Models;
namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Update", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkVirtualAppliance", SupportsShouldProcess = true), OutputType(typeof(PSNetworkVirtualAppliance))]
    public class UpdateNetworkVirtualApplianceCommand : NetworkVirtualApplianceBaseCmdlet
    {

        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Sku of the Virtual Appliance.")]
        [ValidateNotNullOrEmpty]
        public PSVirtualApplianceSkuProperties Sku { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The ASN number of the Virtual Appliance.")]
        [ValidateNotNullOrEmpty]
        public int VirtualApplianceAsn { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "A hashtable which represents resource tags.")]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Do not ask for confirmation if you want to overwrite a resource")]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            base.Execute();
            if(!this.IsNetworkVirtualAppliancePresent(this.ResourceGroupName, this.Name))
            {
                throw new ArgumentException(Properties.Resources.ResourceNotFound);
            }
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.OverwritingResource, Name),
                Properties.Resources.CreatingResourceMessage,
                Name,
                () =>
                {
                    var nva = UpdateNetworkVirtualAppliance();
                    WriteObject(nva);
                }
            );
        }

        private PSNetworkVirtualAppliance UpdateNetworkVirtualAppliance()
        {
            var networkVirtualAppliance = this.GetNetworkVirtualAppliance(this.ResourceGroupName, this.Name);
            if (this.VirtualApplianceAsn != 0)
            {
                networkVirtualAppliance.VirtualApplianceAsn = this.VirtualApplianceAsn;
            }
            networkVirtualAppliance.NvaSku = this.Sku??networkVirtualAppliance.NvaSku;

            var networkVirtualApplianceModel = NetworkResourceManagerProfile.Mapper.Map<MNM.NetworkVirtualAppliance>(networkVirtualAppliance);

            networkVirtualApplianceModel.Tags = TagsConversionHelper.CreateTagDictionary(this.Tag, validate: true);

            this.NetworkVirtualAppliancesClient.CreateOrUpdate(this.ResourceGroupName, this.Name, networkVirtualApplianceModel);

            var getNetworkVirtualAppliance = this.GetNetworkVirtualAppliance(this.ResourceGroupName, this.Name);
            return getNetworkVirtualAppliance;
        }
    }
}
