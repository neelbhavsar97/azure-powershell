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
    public class NewNetworkVirtualApplianceCommand : NetworkVirtualApplianceBaseCmdlet
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
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The public IP address location.")]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Resource ID of the Virtual Hub.")]
        [ValidateNotNullOrEmpty]
        public string VirtualHubId { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Sku of the Virtual Appliance.")]
        public PSVirtualApplianceSkuProperties Sku{ get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "ASN number of the Virtual Appliance.")]
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
            var present = this.IsNetworkVirtualAppliancePresent(this.ResourceGroupName, this.Name);
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.OverwritingResource, Name),
                Properties.Resources.CreatingResourceMessage,
                Name,
                () =>
                {
                    var networkInterface = CreateNetworkVirtualAppliance();
                    if (present)
                    {
                        networkInterface = this.GetNetworkVirtualAppliance(this.ResourceGroupName, this.Name);
                    }

                    WriteObject(networkInterface);
                },
                () => present);
        }

        private PSNetworkVirtualAppliance CreateNetworkVirtualAppliance()
        {
            var networkVirtualAppliance = new PSNetworkVirtualAppliance();
            networkVirtualAppliance.Name = this.Name;
            networkVirtualAppliance.Location = this.Location;
            networkVirtualAppliance.VirtualHub = new PSResourceId();
            networkVirtualAppliance.VirtualHub.Id = this.VirtualHubId;
            networkVirtualAppliance.VirtualApplianceAsn = this.VirtualApplianceAsn;
            networkVirtualAppliance.Sku = this.Sku;

            var networkVirtualApplianceModel = NetworkResourceManagerProfile.Mapper.Map<MNM.NetworkVirtualAppliance>(networkVirtualAppliance);
            networkVirtualApplianceModel.Tags = TagsConversionHelper.CreateTagDictionary(this.Tag, validate: true);
            this.NetworkVirtualAppliancesClient.CreateOrUpdate(this.ResourceGroupName, this.Name, networkVirtualApplianceModel);

            var getNetworkVirtualAppliance = this.GetNetworkVirtualAppliance(this.ResourceGroupName, this.Name);
            return getNetworkVirtualAppliance;
        }
    }
}
