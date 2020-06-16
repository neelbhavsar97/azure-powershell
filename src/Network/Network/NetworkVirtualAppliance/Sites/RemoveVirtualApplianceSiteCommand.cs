using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Network;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualApplianceSite", SupportsShouldProcess = true), OutputType(typeof(bool))]
    public class RemoveVirtualApplianceSiteCommand : VirtualApplianceSiteBaseCmdlet
    {
        private const string ResourceNameParameterSet = "ResourceNameParameterSet";
        private const string ResourceIdParameterSet = "ResourceIdParameterSet";
        private const string ResourceObjectParameterSet = "ResourceObjectParameterSet";

        private string NvaName;
        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceNameParameterSet,
            HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceNameParameterSet,
            HelpMessage = "The resource ID of the Network Virtual Appliance associated with this site.")]
        [ValidateNotNullOrEmpty]
        public virtual string NetworkVirtualApplianceId { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceNameParameterSet,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceIdParameterSet,
            HelpMessage = "The resource id.")]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceId { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceObjectParameterSet,
            HelpMessage = "The virtual appliance site object.")]
        [ValidateNotNullOrEmpty]
        public virtual PSVirtualApplianceSite VirtualApplianceSite { get; set; }

        [Parameter(
           Mandatory = false,
           HelpMessage = "Do not ask for confirmation.")]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            base.Execute();
            if (ParameterSetName.Equals(ResourceIdParameterSet))
            {
                this.ResourceGroupName = GetResourceGroup(this.ResourceId);
                this.NvaName = GetResourceName(this.ResourceId, "Microsoft.Network/networkVirtualAppliances", "virtualApplianceSites");
                this.Name = GetResourceName(this.ResourceId, "virtualAppliancesites");
                string nvaRg = GetResourceGroup(NetworkVirtualApplianceId);
                if (!nvaRg.Equals(this.ResourceGroupName))
                {
                    throw new Exception("The resource group for Network Virtual Appliance is not same as that of site.");
                }
            }
            else if (ParameterSetName.Equals(ResourceObjectParameterSet))
            {
                this.ResourceGroupName = GetResourceGroup(VirtualApplianceSite.Id);
                this.Name = VirtualApplianceSite.Name;
                this.NvaName = GetResourceName(VirtualApplianceSite.Id, "Microsoft.Network/networkVirtualAppliances", "virtualApplianceSites");
            }
            else
            {
                string nvaName = GetResourceName(NetworkVirtualApplianceId, "Microsoft.Network/networkVirtualAppliances");
                string nvaRg = GetResourceGroup(NetworkVirtualApplianceId);
                if (!nvaRg.Equals(this.ResourceGroupName))
                {
                    throw new Exception("The resource group for Network Virtual Appliance is not same as that of site.");
                }
            }
            
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.RemovingResource, Name),
                Properties.Resources.RemoveResourceMessage,
                Name,
                () =>
                {
                    this.VirtualApplianceSitesClient.Delete(this.ResourceGroupName, NvaName, this.Name);
                    if (PassThru)
                    {
                        WriteObject(true);
                    }
                });
        }
    }
}
