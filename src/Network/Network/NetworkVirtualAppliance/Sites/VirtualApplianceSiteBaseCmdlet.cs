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
            var nvasite = this.VirtualApplianceSitesClient.Get(resourceGroupName, nvaName, name);

            var psSite = NetworkResourceManagerProfile.Mapper.Map<PSVirtualApplianceSite>(nvasite);
            psSite.ResourceGroupName = resourceGroupName;
            return psSite;
        }
        public PSVirtualApplianceSite ToPsVirtualApplianceSite(VirtualApplianceSite nvasite)
        {
            var psSite = NetworkResourceManagerProfile.Mapper.Map<PSVirtualApplianceSite>(nvasite);
            return psSite;
        }
    }
}
