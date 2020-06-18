using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Rest.Azure;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Linq;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkVirtualApplianceSku"), OutputType(typeof(PSNetworkVirtualApplianceSku))]
    public class GetVirtualApplianceSkuCommand : VirtualApplianceSkuBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = "The Sku name.",
            ParameterSetName = "ResourceName")]
        [ValidateNotNullOrEmpty]
        public virtual string SkuName  { get; set; }

        public override void Execute()
        {
            base.Execute();
            if (ShouldGetByName(this.SkuName))
            {
                var sku = this.GetVirtualApplianceSku(this.SkuName);
                WriteObject(sku);
            }
            else
            {
                IPage<NetworkVirtualApplianceSku> skuPage;
                skuPage = this.VirtualApplianceSkusClient.List();
                // Get all resources by polling on next page link
                var skuList = ListNextLink<NetworkVirtualApplianceSku>.GetAllResourcesByPollingNextLink(skuPage, this.VirtualApplianceSkusClient.ListNext);
                var psSkus = new List<PSNetworkVirtualApplianceSku>();
                foreach (var sku in skuList)
                {
                    var psSku = this.ToPsNetworkVirtualApplianceSku(sku);
                    psSkus.Add(psSku);
                }
                WriteObject(Filter(this.SkuName, psSkus), true);
            }
        }

        private bool ShouldGetByName(string name)
        {
            return !string.IsNullOrEmpty(name) && !WildcardPattern.ContainsWildcardCharacters(name);
        }

        private List<PSNetworkVirtualApplianceSku> Filter(string skuname, List<PSNetworkVirtualApplianceSku> resources)
        {
            if (!string.IsNullOrEmpty(skuname))
            {
                WildcardPattern pattern = new WildcardPattern(skuname, WildcardOptions.IgnoreCase);
                var tmp = resources.Where(p => pattern.IsMatch(p.Vendor)).ToList();
                return tmp;
            }
            return resources;
        }
    }
}
