using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Graph.RBAC.Version1_6.ActiveDirectory;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Rest.Azure;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkVirtualAppliance"), OutputType(typeof(PSNetworkVirtualAppliance))]
    public class GetNetworkVirtualApplianceCommand : NetworkVirtualApplianceBaseCmdlet
    {
        private const string ResourceNameParameterSet = "ResourceNameParameterSet";
        private const string ResourceIdParameterSet = "ResourceIdParameterSet";
        private const string ResourceNVAParameterSet = "ResourceNVAParameterSet";


        [Alias("ResourceName")]
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.",
            ParameterSetName = ResourceNameParameterSet)]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.",
            ParameterSetName = ResourceNVAParameterSet)]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.",
            ParameterSetName = ResourceNameParameterSet)]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.",
            ParameterSetName = ResourceNVAParameterSet)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.",
            ParameterSetName = ResourceIdParameterSet)]
        public virtual string ResourceId { get; set; }

        public override void Execute()
        {
            base.Execute();
            if (ParameterSetName.Equals(ResourceIdParameterSet))
            {
                this.ResourceGroupName = GetResourceGroup(this.ResourceId);
                this.Name = GetResourceName(this.ResourceId, "Microsoft.Network/networkVirtualAppliances");
            }
            
            if (ShouldGetByName(ResourceGroupName, Name))
            {
                //Console.WriteLine("Get one.");
                var nva = this.GetNetworkVirtualAppliance(this.ResourceGroupName, this.Name);
                WriteObject(nva);
            }
            else
            {
                IPage<NetworkVirtualAppliance> nvaPage;
                if (ShouldListByResourceGroup(ResourceGroupName, Name))
                {
                    //Console.WriteLine("Listing by rg.");
                    nvaPage = this.NetworkVirtualAppliancesClient.ListByResourceGroup(ResourceGroupName);
                }
                else
                {
                    //Console.WriteLine("Listing by sub.");
                    nvaPage = this.NetworkVirtualAppliancesClient.List();
                }

                // Get all resources by polling on next page link
                var nvaList = ListNextLink<NetworkVirtualAppliance>.GetAllResourcesByPollingNextLink(nvaPage, this.NetworkVirtualAppliancesClient.ListNext);

                var psNvas= new List<PSNetworkVirtualAppliance>();

                foreach (var nva in nvaList)
                {
                    var psNva = this.ToPsNetworkVirtualAppliance(nva);
                    psNva.ResourceGroupName = NetworkBaseCmdlet.GetResourceGroup(nva.Id);
                    psNvas.Add(psNva);
                }

                WriteObject(TopLevelWildcardFilter(ResourceGroupName, Name, psNvas), true);
            }
        }
    }
}
