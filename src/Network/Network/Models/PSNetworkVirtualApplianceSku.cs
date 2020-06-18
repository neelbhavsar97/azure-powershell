using Microsoft.Azure.Management.Network.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSNetworkVirtualApplianceSku : PSChildResource
    {
        public string Vendor { get; set; }
        public IList<string> AvailableVersions { get; set; }
        public IList<PSNetworkVirtualApplianceSkuInstances> AvailableScaleUnits { get; set; }
    }
}
