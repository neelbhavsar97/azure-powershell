using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System.Net;

namespace Microsoft.Azure.Commands.Network
{
    public abstract class VirtualApplianceSiteBaseCmdlet : NetworkBaseCmdlet
    {
        public IVirtualApplianceSitesOperations VirtualApplianceSitesClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.VirtualApplianceSites;
            }
        }

        public bool IsVirtualApplianceSitePresent(string resourceGroupName, string nvaName, string name)
        {
            try
            {
                GetVirtualApplianceSite(resourceGroupName, nvaName, name);
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

        public PSVirtualApplianceSite GetVirtualApplianceSite(string resourceGroupName, string nvaName, string name)
        {
            var nvaSite = this.VirtualApplianceSitesClient.Get(resourceGroupName, nvaName, name);

            var psSite = NetworkResourceManagerProfile.Mapper.Map<PSVirtualApplianceSite>(nvaSite);
            return psSite;
        }
        public PSVirtualApplianceSite ToPsVirtualApplianceSite(VirtualApplianceSite nvasite)
        {
            var psSite = NetworkResourceManagerProfile.Mapper.Map<PSVirtualApplianceSite>(nvasite);
            return psSite;
        }
    }
}
