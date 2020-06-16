using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Rest.Azure;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkVirtualApplianceSku"), OutputType(typeof(PSNetworkVirtualApplianceSku))]
    public class GetVirtualApplianceSkuCommand : VirtualApplianceSkuBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Sku name.",
            ParameterSetName = "ResourceName")]
        public virtual string SkuName  { get; set; }

        public override void Execute()
        {
            // Does not support wild cards.
            base.Execute();
            if (!(String.IsNullOrEmpty(SkuName)))
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
                WriteObject(psSkus, true);
            }
        }
    }
}
