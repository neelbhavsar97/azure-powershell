using Microsoft.Azure.Commands.Common.Compute.Version2016_04_preview.Models;
using Microsoft.Azure.Commands.Network.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualApplianceSkuProperties"), OutputType(typeof(PSVirtualApplianceSkuProperties))]
    public class NewVirtualApplianceSkuPropertiesCommand : VirtualApplianceSkuPropertiesBaseCmdlet
    {
        [Alias("Name")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = "The name of the vendor.")]
        public virtual string VendorName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = "The bundled scale unit.")]
        public virtual string BundledScaleUnit { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = "The market place version.")]
        public virtual string MarketPlaceVersion { get; set; }

        public override void Execute()
        {
            base.Execute();
            var skuProperties = new PSVirtualApplianceSkuProperties();
            skuProperties.BundledScaleUnit = this.BundledScaleUnit;
            skuProperties.MarketPlaceVersion = this.MarketPlaceVersion;
            skuProperties.Vendor = this.VendorName;
            WriteObject(skuProperties);
        }
    }
}
