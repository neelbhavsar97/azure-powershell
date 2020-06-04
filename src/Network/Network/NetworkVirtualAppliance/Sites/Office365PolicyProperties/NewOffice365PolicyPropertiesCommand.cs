using Microsoft.Azure.Commands.Network.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Office365PolicyProperties"), OutputType(typeof(PSOffice365PolicyProperties))]
    public class NewOffice365PolicyPropertiesCommand : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = "Optimize ")]
        public SwitchParameter Allow { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = "The bundled scale unit.")]
        public SwitchParameter Optimize { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = "The market place version.")]
        public SwitchParameter Default { get; set; }

        public override void Execute()
        {
            base.Execute();
            var o365Policy = new PSOffice365PolicyProperties();
            o365Policy.BreakOutCategories = new PSBreakOutCategoryPolicies();
            o365Policy.BreakOutCategories.Allow = this.Allow;
            o365Policy.BreakOutCategories.Optimize = this.Optimize;
            o365Policy.BreakOutCategories.DefaultProperty = this.Default;
            WriteObject(o365Policy);
        }
    }
}
