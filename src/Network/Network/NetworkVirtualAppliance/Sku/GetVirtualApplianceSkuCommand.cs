using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Rest.Azure;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    public class GetVirtualApplianceSkuCommand : VirtualApplianceSkuBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.",
            ParameterSetName = "ResourceName")]
        public virtual string Name { get; set; }

        public override void Execute()
        {
            base.Execute();
            if (!(String.IsNullOrEmpty(Name)))
            {
                var sku = this.GetVirtualApplianceSku(this.Name);
                WriteObject(sku);
            }
            else
            {
                IPage<NetworkVirtualApplianceSku> skuPage;
                skuPage = this.VirtualApplianceSkusClient.List();
                // Get all resources by polling on next page link
                var skuList = ListNextLink<NetworkVirtualApplianceSku>.GetAllResourcesByPollingNextLink(skuPage, this.VirtualApplianceSkusClient.ListNext);
                var psNsgs = new List<PSNetworkSecurityGroup>();
                foreach (var networkSecurityGroup in nsgList)
                {
                    var psNsg = this.ToPsNetworkSecurityGroup(networkSecurityGroup);
                    psNsg.ResourceGroupName = NetworkBaseCmdlet.GetResourceGroup(networkSecurityGroup.Id);
                    psNsgs.Add(psNsg);
                }

                WriteObject(psNsgs, true);
            }
        }
    }
}

