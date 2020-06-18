namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215
{
    using Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.PowerShell;

    /// <summary>Class representing a read only following database.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReadOnlyFollowingDatabaseTypeConverter))]
    public partial class ReadOnlyFollowingDatabase
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.ReadOnlyFollowingDatabase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReadOnlyFollowingDatabase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.ReadOnlyFollowingDatabase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReadOnlyFollowingDatabase(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReadOnlyFollowingDatabase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.ReadOnlyFollowingDatabase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReadOnlyFollowingDatabase(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.ReadOnlyFollowingDatabasePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).Statistics = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseStatistics) content.GetValueForProperty("Statistics",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).Statistics, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.DatabaseStatisticsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).AttachedDatabaseConfigurationName = (string) content.GetValueForProperty("AttachedDatabaseConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).AttachedDatabaseConfigurationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).HotCachePeriod = (global::System.TimeSpan?) content.GetValueForProperty("HotCachePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).HotCachePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).LeaderClusterResourceId = (string) content.GetValueForProperty("LeaderClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).LeaderClusterResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).PrincipalsModificationKind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalsModificationKind?) content.GetValueForProperty("PrincipalsModificationKind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).PrincipalsModificationKind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalsModificationKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).SoftDeletePeriod = (global::System.TimeSpan?) content.GetValueForProperty("SoftDeletePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).SoftDeletePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).StatisticsSize = (float?) content.GetValueForProperty("StatisticsSize",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).StatisticsSize, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.ReadOnlyFollowingDatabase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReadOnlyFollowingDatabase(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.ReadOnlyFollowingDatabasePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).Statistics = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IDatabaseStatistics) content.GetValueForProperty("Statistics",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).Statistics, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.DatabaseStatisticsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).AttachedDatabaseConfigurationName = (string) content.GetValueForProperty("AttachedDatabaseConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).AttachedDatabaseConfigurationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).HotCachePeriod = (global::System.TimeSpan?) content.GetValueForProperty("HotCachePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).HotCachePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).LeaderClusterResourceId = (string) content.GetValueForProperty("LeaderClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).LeaderClusterResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).PrincipalsModificationKind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalsModificationKind?) content.GetValueForProperty("PrincipalsModificationKind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).PrincipalsModificationKind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalsModificationKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).SoftDeletePeriod = (global::System.TimeSpan?) content.GetValueForProperty("SoftDeletePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).SoftDeletePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).StatisticsSize = (float?) content.GetValueForProperty("StatisticsSize",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200215.IReadOnlyFollowingDatabaseInternal)this).StatisticsSize, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Class representing a read only following database.
    [System.ComponentModel.TypeConverter(typeof(ReadOnlyFollowingDatabaseTypeConverter))]
    public partial interface IReadOnlyFollowingDatabase

    {

    }
}