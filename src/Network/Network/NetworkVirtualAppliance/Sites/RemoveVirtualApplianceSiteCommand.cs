using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Network;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    public class RemoveVirtualApplianceSiteCommand : VirtualApplianceSiteBaseCmdlet
    {
        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.")]
        [ResourceNameCompleter("Microsoft.Network/virtualApplianceSite", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource ID of the Network Virtual Appliance associated with this site.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public virtual string NetworkVirtualApplianceId { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceGroupName { get; set; }

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
            string nvaName = GetResourceName(NetworkVirtualApplianceId, "Microsoft.Network/networkVirtualAppliances");
            base.Execute();
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.RemovingResource, Name),
                Properties.Resources.RemoveResourceMessage,
                Name,
                () =>
                {
                    this.VirtualApplianceSitesClient.Delete(this.ResourceGroupName, nvaName, this.Name);
                    if (PassThru)
                    {
                        WriteObject(true);
                    }
                });
        }
    }
}
