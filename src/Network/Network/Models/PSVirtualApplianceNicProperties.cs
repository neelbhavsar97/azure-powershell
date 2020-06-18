using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSVirtualApplianceNicProperties
    {
        public string Name { get; set; }
        public string PublicIpAddress { get; set; }
        public string PrivateIpAddress { get; set; }
    }
}
