﻿using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Network;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkVirtualAppliance", SupportsShouldProcess = true), OutputType(typeof(bool))]
    public class RemoveNetworkVirtualApplianceCommand : NetworkVirtualApplianceBaseCmdlet
    {
        private const string ResourceNameParameterSet = "ResourceNameParameterSet";
        private const string ResourceIdParameterSet = "ResourceIdParameterSet";
        private const string ResourceObjectParameterSet = "ResourceObjectParameterSet";

        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceNameParameterSet,
            HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceNameParameterSet,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(
           Mandatory = true,
           ValueFromPipelineByPropertyName = true,
           ParameterSetName = ResourceIdParameterSet,
           HelpMessage = "The Resource Id.")]
        [ValidateNotNullOrEmpty]
        public string ResourceId{ get; set; }

        [Parameter(
           Mandatory = true,
           ValueFromPipelineByPropertyName = true,
           ParameterSetName = ResourceObjectParameterSet,
           HelpMessage = "The resource object.")]
        [ValidateNotNullOrEmpty]
        public PSNetworkVirtualAppliance NetworkVirtualAppliance { get; set; }

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

            if (ParameterSetName.Equals(ResourceObjectParameterSet))
            {
                this.ResourceGroupName = GetResourceGroup(NetworkVirtualAppliance.Id);
                this.Name = NetworkVirtualAppliance.Name;
            }
            else if (ParameterSetName.Equals(ResourceIdParameterSet))
            {
                this.ResourceGroupName = GetResourceGroup(ResourceId);
                this.Name = GetResourceName(ResourceId, "Microsoft.Network/networkVirtualAppliances");
            }
            // Console.WriteLine(this.ResourceGroupName + " " + this.Name);
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.RemovingResource, Name),
                Properties.Resources.RemoveResourceMessage,
                Name,
                () =>
                {
                    this.NetworkVirtualAppliancesClient.Delete(this.ResourceGroupName, this.Name);
                    if (PassThru)
                    {
                        WriteObject(true);
                    }
                });
        }
    }
}
