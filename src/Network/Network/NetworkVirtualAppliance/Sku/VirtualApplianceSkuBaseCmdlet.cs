using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
namespace Microsoft.Azure.Commands.Network
{
    public abstract class VirtualApplianceSkuBaseCmdlet : NetworkBaseCmdlet
    {
        public IVirtualApplianceSkusOperations VirtualApplianceSkusClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.VirtualApplianceSkus;
            }
        }

        public bool IsVirtualApplianceSkuPresent(string name)
        {
            try
            {
                GetVirtualApplianceSku(name);
            }
            catch (Microsoft.Rest.Azure.CloudException exception)
            {
                if (exception.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    // Resource is not present
                    return false;
                }
                throw;
            }
            return true;
        }

        public PSVirtualApplianceSkuProperties GetVirtualApplianceSku(string name)
        {
            var nvasku = this.VirtualApplianceSkusClient.Get(name);
            var psSku = NetworkResourceManagerProfile.Mapper.Map<PSVirtualApplianceSkuProperties>(nvasku);
            return psSku;
        }
    }
}
