namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Azure Files or Blob Storage access information value for dictionary storage.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureStorageInfoValueTypeConverter))]
    public partial class AzureStorageInfoValue
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.AzureStorageInfoValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureStorageInfoValue(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).AccessKey = (string) content.GetValueForProperty("AccessKey",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).AccessKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).AccountName = (string) content.GetValueForProperty("AccountName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).AccountName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).MountPath = (string) content.GetValueForProperty("MountPath",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).MountPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).ShareName = (string) content.GetValueForProperty("ShareName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).ShareName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.AzureStorageInfoValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureStorageInfoValue(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).AccessKey = (string) content.GetValueForProperty("AccessKey",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).AccessKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).AccountName = (string) content.GetValueForProperty("AccountName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).AccountName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).MountPath = (string) content.GetValueForProperty("MountPath",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).MountPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).ShareName = (string) content.GetValueForProperty("ShareName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).ShareName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValueInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.AzureStorageInfoValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValue" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValue DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureStorageInfoValue(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.AzureStorageInfoValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValue" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValue DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureStorageInfoValue(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureStorageInfoValue" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IAzureStorageInfoValue FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Azure Files or Blob Storage access information value for dictionary storage.
    [System.ComponentModel.TypeConverter(typeof(AzureStorageInfoValueTypeConverter))]
    public partial interface IAzureStorageInfoValue

    {

    }
}