using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    public abstract class NetworkVirtualApplianceBaseCmdlet : NetworkBaseCmdlet
    {
        public INetworkVirtualAppliancesOperations NetworkVirtualAppliancesClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.NetworkVirtualAppliances;
            }
        }

        public bool IsNetworkVirtualAppliancePresent(string resourceGroupName, string name)
        {
            try
            {
                GetNetworkVirtualAppliance(resourceGroupName, name);
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

        public PSNetworkVirtualAppliance GetNetworkVirtualAppliance(string resourceGroupName, string name, string expandResource = null)
        {
            var nva = this.NetworkVirtualAppliancesClient.Get(resourceGroupName, name, expandResource);
            var psNva= NetworkResourceManagerProfile.Mapper.Map<PSNetworkVirtualAppliance>(nva);
            psNva.ResourceGroupName = resourceGroupName;
            psNva.Tag =
                TagsConversionHelper.CreateTagHashtable(nva.Tags);
            return psNva;
        }
        public PSNetworkVirtualAppliance ToPsNetworkVirtualAppliance(NetworkVirtualAppliance nva)
        {
            var psNva = NetworkResourceManagerProfile.Mapper.Map<PSNetworkVirtualAppliance>(nva);
            psNva.Tag = TagsConversionHelper.CreateTagHashtable(nva.Tags);
            return psNva;
        }
    }
}
