﻿using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Rest.Azure;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkVirtualApplianceSku"), OutputType(typeof(PSNetworkSecurityGroup))]
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
                // Get one NVA Sku.
                var sku = this.GetVirtualApplianceSku(this.Name);
                WriteObject(sku);
            }
            else
            {
                // List all NVA Skus.
                IPage<NetworkVirtualApplianceSku> skuPage;
                skuPage = this.VirtualApplianceSkusClient.List();
                // Get all resources by polling on next page link
                var skuList = ListNextLink<NetworkVirtualApplianceSku>.GetAllResourcesByPollingNextLink(skuPage, this.VirtualApplianceSkusClient.ListNext);
                var psNsgs = new List<PSNetworkVirtualApplianceSku>();
                foreach (var sku in skuList)
                {
                    var psNsg = this.ToPsNetworkVirtualApplianceSku(sku);
                    psNsgs.Add(psNsg);
                }
                WriteObject(psNsgs, true);
            }
        }
    }
}

