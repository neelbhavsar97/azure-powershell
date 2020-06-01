﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ------------------------------------

using System.Management.Automation;
using Commands.Security;
using Microsoft.Azure.Commands.Security.Common;
using Microsoft.Azure.Commands.SecurityCenter.Models.RegulatoryCompliance;
using Microsoft.Azure.Commands.SecurityCenter.Common;

namespace Microsoft.Azure.Commands.SecurityCenter.Cmdlets.RegulatoryCompliance
{
    [Cmdlet(VerbsCommon.Get, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "RegulatoryComplianceControl", DefaultParameterSetName = ParameterSetNames.SubscriptionLevelResource), OutputType(typeof(PSSecurityRegulatoryComplianceControl))]
    public class GetRegulatoryComplianceControl : SecurityCenterCmdletBase
    {
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelResource, Mandatory = false, HelpMessage = ParameterHelpMessages.ResourceName)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelResource, Mandatory = true, HelpMessage = ParameterHelpMessages.StandardName)]
        [ValidateNotNullOrEmpty]
        public string StandardName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ResourceId, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.ResourceId)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        public override void ExecuteCmdlet()
        {
            switch (ParameterSetName)
            {
                case ParameterSetNames.SubscriptionLevelResource:
                    if (!string.IsNullOrEmpty(Name))
                    {
                        var regulatoryComplianceControl = SecurityCenterClient.RegulatoryComplianceControls.GetWithHttpMessagesAsync(
                            StandardName, Name).GetAwaiter().GetResult().Body;
                        WriteObject(regulatoryComplianceControl.ConvertToPSType(), enumerateCollection: false);
                        break;
                    }
                    else
                    {
                        var regulatoryComplianceControls = SecurityCenterClient.RegulatoryComplianceControls.ListWithHttpMessagesAsync(
                            StandardName).GetAwaiter().GetResult().Body;
                        WriteObject(regulatoryComplianceControls.ConvertToPSType(), enumerateCollection: true);
                        break;
                    }

                case ParameterSetNames.ResourceId:
                    var regulatoryComplianceControlByResource = SecurityCenterClient.RegulatoryComplianceControls.GetWithHttpMessagesAsync(
                        AzureIdUtilities.GetRegulatoryStandardName(ResourceId),
                        AzureIdUtilities.GetRegulatoryStandardControlName(ResourceId, true))
                        .GetAwaiter().GetResult().Body;
                    WriteObject(regulatoryComplianceControlByResource.ConvertToPSType(), enumerateCollection: false);
                    break;
                default:
                    throw new PSInvalidOperationException();
            }
        }
    }
}
