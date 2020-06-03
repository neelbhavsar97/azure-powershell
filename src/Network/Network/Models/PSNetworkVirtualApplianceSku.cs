using Microsoft.Azure.Management.Network.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSNetworkVirtualApplianceSku : PSTopLevelResource
    {
        public string Vendor { get; }
        public IList<string> AvailableVersions { get; }
        public IList<PSNetworkVirtualApplianceSkuInstances> AvailableScaleUnits { get; set; }
    }
}
