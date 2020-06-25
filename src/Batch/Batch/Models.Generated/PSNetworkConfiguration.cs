﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSNetworkConfiguration
    {
        
        internal Microsoft.Azure.Batch.NetworkConfiguration omObject;
        
        private PSPoolEndpointConfiguration endpointConfiguration;
        
        private PSPublicIPAddressConfiguration publicIPAddressConfiguration;
        
        public PSNetworkConfiguration()
        {
            this.omObject = new Microsoft.Azure.Batch.NetworkConfiguration();
        }
        
        internal PSNetworkConfiguration(Microsoft.Azure.Batch.NetworkConfiguration omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public Microsoft.Azure.Batch.Common.DynamicVNetAssignmentScope? DynamicVNetAssignmentScope
        {
            get
            {
                return this.omObject.DynamicVNetAssignmentScope;
            }
            set
            {
                this.omObject.DynamicVNetAssignmentScope = value;
            }
        }
        
        public PSPoolEndpointConfiguration EndpointConfiguration
        {
            get
            {
                if (((this.endpointConfiguration == null) 
                            && (this.omObject.EndpointConfiguration != null)))
                {
                    this.endpointConfiguration = new PSPoolEndpointConfiguration(this.omObject.EndpointConfiguration);
                }
                return this.endpointConfiguration;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.EndpointConfiguration = null;
                }
                else
                {
                    this.omObject.EndpointConfiguration = value.omObject;
                }
                this.endpointConfiguration = value;
            }
        }
        
        public PSPublicIPAddressConfiguration PublicIPAddressConfiguration
        {
            get
            {
                if (((this.publicIPAddressConfiguration == null) 
                            && (this.omObject.PublicIPAddressConfiguration != null)))
                {
                    this.publicIPAddressConfiguration = new PSPublicIPAddressConfiguration(this.omObject.PublicIPAddressConfiguration);
                }
                return this.publicIPAddressConfiguration;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.PublicIPAddressConfiguration = null;
                }
                else
                {
                    this.omObject.PublicIPAddressConfiguration = value.omObject;
                }
                this.publicIPAddressConfiguration = value;
            }
        }
        
        public string SubnetId
        {
            get
            {
                return this.omObject.SubnetId;
            }
            set
            {
                this.omObject.SubnetId = value;
            }
        }
    }
}
