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

        public PSNetworkVirtualApplianceSku GetVirtualApplianceSku(string name)
        {
            var nvaSku = this.VirtualApplianceSkusClient.Get(name);
            var psSku = NetworkResourceManagerProfile.Mapper.Map<PSNetworkVirtualApplianceSku>(nvaSku);
            return psSku;
        }

        public PSNetworkVirtualApplianceSku ToPsNetworkVirtualApplianceSku(NetworkVirtualApplianceSku nvaSku)
        {
            var psSku = NetworkResourceManagerProfile.Mapper.Map<PSNetworkVirtualApplianceSku>(nvaSku);
            psSku.Tag = TagsConversionHelper.CreateTagHashtable(nvaSku.Tags);
            return psSku;
        }
    }
}
