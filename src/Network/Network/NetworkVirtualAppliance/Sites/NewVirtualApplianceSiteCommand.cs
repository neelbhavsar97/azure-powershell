using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Network;
using System;
using System.Collections;
using System.Management.Automation;
using MNM = Microsoft.Azure.Management.Network.Models;
namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualApplianceSite", SupportsShouldProcess = true), OutputType(typeof(PSVirtualApplianceSite))]
    public class NewVirtualApplianceSiteCommand : VirtualApplianceSiteBaseCmdlet
    {
        
        private const string ResourceNameParameterSet = "ResourceNameParameterSet";
        private const string ResourceIdParameterSet = "ResourceIdParameterSet";

        private string NvaName;

        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceNameParameterSet,
            HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceNameParameterSet,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ResourceIdParameterSet,
            HelpMessage = "The resource id.")]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceId { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The address prefix for the site.")]
        [ValidateNotNullOrEmpty]
        public string AddresssPrefix { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Office 365 breakout policy.")]
        [ValidateNotNullOrEmpty]
        public PSOffice365PolicyProperties O365Policy { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Network virtual appliance that this site is attached to.")]
        public string NetworkVirtualApplianceId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "A hashtable which represents resource tags.")]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Do not ask for confirmation if you want to overwrite a resource")]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }


        public override void Execute()
        {
            base.Execute();
            if (ParameterSetName.Equals(ResourceIdParameterSet))
            {
                this.ResourceGroupName = GetResourceGroup(this.ResourceId);
                this.NvaName = GetResourceName(this.ResourceId, "Microsoft.Network/networkVirtualAppliances", "virtualApplianceSites");
                this.Name = GetResourceName(this.ResourceId, "virtualAppliancesites");
                string nvaRg = GetResourceGroup(NetworkVirtualApplianceId);
                if (!nvaRg.Equals(this.ResourceGroupName))
                {
                    throw new Exception("The resource group for Network Virtual Appliance is not same as that of site.");
                }
            }
            else
            {
                string nvaName = GetResourceName(NetworkVirtualApplianceId, "Microsoft.Network/networkVirtualAppliances");
                string nvaRg = GetResourceGroup(NetworkVirtualApplianceId);
                if (!nvaRg.Equals(this.ResourceGroupName))
                {
                    throw new Exception("The resource group for Network Virtual Appliance is not same as that of site.");
                }
            }
            //Console.WriteLine(this.ResourceGroupName + " " + this.Name);
            var present = this.IsVirtualApplianceSitePresent(this.ResourceGroupName, this.NvaName, this.Name);
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.OverwritingResource, Name),
                Properties.Resources.CreatingResourceMessage,
                Name,
                () =>
                {
                    var site = CreateVirtualApplianceSite();
                    if (present)
                    {
                        site = this.GetVirtualApplianceSite(this.ResourceGroupName, this.NvaName, this.Name);
                    }

                WriteObject(site);
                },
                () => present);
        }

        private PSVirtualApplianceSite CreateVirtualApplianceSite()
        {
            var psSite = new PSVirtualApplianceSite();
            psSite.Name = this.Name;
            psSite.O365Policy = this.O365Policy;
            psSite.AddressPrefix = this.AddresssPrefix;
            
            var siteModel = NetworkResourceManagerProfile.Mapper.Map<MNM.VirtualApplianceSite>(psSite);

            this.VirtualApplianceSitesClient.CreateOrUpdate(this.ResourceGroupName, this.NvaName, this.Name, siteModel);

            var getSite = this.GetVirtualApplianceSite(this.ResourceGroupName, this.NvaName, this.Name);
            return getSite;
        }
    }
}