namespace Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Extensions;

    /// <summary>Sku Setting.</summary>
    public partial class SkuSetting
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ISkuSetting.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ISkuSetting.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ISkuSetting FromJson(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject json ? new SkuSetting(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject into a new instance of <see cref="SkuSetting" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SkuSetting(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonArray>("locations"), out var __jsonLocations) ? If( __jsonLocations as Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Location;}
            {_requiredFeature = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonArray>("requiredFeatures"), out var __jsonRequiredFeatures) ? If( __jsonRequiredFeatures as Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : RequiredFeature;}
            {_tier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonString>("tier"), out var __jsonTier) ? (string)__jsonTier : (string)Tier;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SkuSetting" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SkuSetting" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            if (null != this._location)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.XNodeArray();
                foreach( var __x in this._location )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("locations",__w);
            }
            if (null != this._requiredFeature)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.XNodeArray();
                foreach( var __s in this._requiredFeature )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("requiredFeatures",__r);
            }
            AddIf( null != (((object)this._tier)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Json.JsonString(this._tier.ToString()) : null, "tier" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}