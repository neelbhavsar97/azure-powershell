using Microsoft.Azure.Management.Network.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSVirtualApplianceSite : PSChildResource
    {
        public string AddressPrefix { get; set; }
        public PSOffice365PolicyProperties O365Policy { get; set; }
        public string ProvisioningState { get; }
    }
}
