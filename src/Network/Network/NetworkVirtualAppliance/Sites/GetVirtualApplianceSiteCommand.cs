using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Rest.Azure;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.NetworkInformation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualApplianceSite"), OutputType(typeof(PSVirtualApplianceSite))]
    public class GetVirtualApplianceSiteCommand : VirtualApplianceSiteBaseCmdlet
    {
        private const string ResourceNameParameterSet = "ResourceNameParameterSet";
        private const string ResourceIdParameterSet = "ResourceIdParameterSet";

        private string NvaName;

        [Alias("ResourceName")]
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.",
            ParameterSetName = ResourceNameParameterSet)]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Network Virtual Appliance that the site is attached.",
            ParameterSetName = ResourceNameParameterSet)]
        public virtual string NetworkVirtualApplianceId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.",
            ParameterSetName = ResourceNameParameterSet)]
        [ResourceGroupCompleter]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource Id of the Virtual Appliance Site.",
            ParameterSetName = ResourceIdParameterSet)]
        public virtual string ResourceId { get; set; }

        public override void Execute()
        {
            base.Execute();
            if (ParameterSetName.Equals(ResourceIdParameterSet))
            {
                this.ResourceGroupName = GetResourceGroup(this.ResourceId);
                this.NvaName = GetResourceName(this.ResourceId, "Microsoft.Network/networkVirtualAppliances", "virtualApplianceSites");
                this.Name = GetResourceName(this.ResourceId, "virtualAppliancesites");
            }
            else
            {
                this.NvaName = GetResourceName(this.NetworkVirtualApplianceId, "Microsoft.Network/networkVirtualAppliances");
            }
            if (ShouldGetByName(ResourceGroupName, NvaName, Name))
            {
                var site = this.GetVirtualApplianceSite(this.ResourceGroupName, this.NvaName, this.Name);
                WriteObject(site);
            }
            else
            {

                IPage<VirtualApplianceSite> sitePage;
                if(ShouldListByNva(ResourceGroupName, NvaName, Name))
                {

                }
                if (ShouldListByResourceGroup(ResourceGroupName, NvaName))
                {
                    sitePage = this.VirtualApplianceSitesClient.List(ResourceGroupName, Name);
                    // Get all resources by polling on next page link
                    var siteList = ListNextLink<VirtualApplianceSite>.GetAllResourcesByPollingNextLink(sitePage, this.VirtualApplianceSitesClient.ListNext);

                    var psSites = new List<PSVirtualApplianceSite>();

                    foreach (var site in siteList)
                    {
                        var psSite = this.ToPsVirtualApplianceSite(site);
                        psSites.Add(psSite);
                    }

                    WriteObject(TopLevelWildcardFilter(ResourceGroupName, Name, psSites), true);
                }
                else if(ShouldListBySubscription(this.ResourceGroupName, this.NvaName))
                {
                   
                }
            }
        }
        private bool ShouldListByNva(string resourceGroupName, string nvaName, string name)
        {
            return !string.IsNullOrEmpty(resourceGroupName) &&
                !WildcardPattern.ContainsWildcardCharacters(resourceGroupName) &&
                !string.IsNullOrEmpty(nvaName) &&
                !WildcardPattern.ContainsWildcardCharacters(nvaName) &&
                (string.IsNullOrEmpty(name) || WildcardPattern.ContainsWildcardCharacters(name));
        }
        private bool ShouldGetByName(string resourceGroupName, string nvaName, string name)
        {
            return !string.IsNullOrEmpty(resourceGroupName) && 
                !WildcardPattern.ContainsWildcardCharacters(resourceGroupName) && 
                !string.IsNullOrEmpty(nvaName) && 
                !WildcardPattern.ContainsWildcardCharacters(nvaName) &&
                !string.IsNullOrEmpty(name) &&
                !WildcardPattern.ContainsWildcardCharacters(name);
        }
    }
}
