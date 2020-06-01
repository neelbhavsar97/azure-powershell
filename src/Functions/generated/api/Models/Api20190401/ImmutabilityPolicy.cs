namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>
    /// The ImmutabilityPolicy property of a blob container, including Id, resource name, resource type, Etag.
    /// </summary>
    public partial class ImmutabilityPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResource __azureEntityResource = new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.AzureEntityResource();

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>
        /// The ETag HTTP response header. This is an opaque string. You can use it to detect whether the resource has changed between
        /// requests. In particular, you can pass the ETag to one of the If-Match or If-None-Match headers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; set => this._eTag = value; }

        /// <summary>Resource Etag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal)__azureEntityResource).Etag; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Id; }

        /// <summary>
        /// The immutability period for the blobs in the container since the policy creation, in days.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public int ImmutabilityPeriodSinceCreationInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyPropertyInternal)Property).ImmutabilityPeriodSinceCreationInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyPropertyInternal)Property).ImmutabilityPeriodSinceCreationInDay = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal.Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal)__azureEntityResource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal)__azureEntityResource).Etag = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyProperty Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ImmutabilityPolicyProperty()); set { {_property = value;} } }

        /// <summary>Internal Acessors for State</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyInternal.State { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyPropertyInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyPropertyInternal)Property).State = value; }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyProperty _property;

        /// <summary>The properties of an ImmutabilityPolicy of a blob container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyProperty Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ImmutabilityPolicyProperty()); set => this._property = value; }

        /// <summary>
        /// The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyPropertyInternal)Property).State; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceInternal)__azureEntityResource).Type; }

        /// <summary>Creates an new <see cref="ImmutabilityPolicy" /> instance.</summary>
        public ImmutabilityPolicy()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("ETag", out var __eTagHeader))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyInternal)this).ETag = System.Linq.Enumerable.FirstOrDefault(__eTagHeader) is string __headerETagHeader ? __headerETagHeader : (string)null;
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureEntityResource), __azureEntityResource);
            await eventListener.AssertObjectIsValid(nameof(__azureEntityResource), __azureEntityResource);
        }
    }
    /// The ImmutabilityPolicy property of a blob container, including Id, resource name, resource type, Etag.
    public partial interface IImmutabilityPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResource
    {
        /// <summary>
        /// The ETag HTTP response header. This is an opaque string. You can use it to detect whether the resource has changed between
        /// requests. In particular, you can pass the ETag to one of the If-Match or If-None-Match headers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ETag HTTP response header. This is an opaque string. You can use it to detect whether the resource has changed between requests. In particular, you can pass the ETag to one of the If-Match or If-None-Match headers.",
        SerializedName = @"ETag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get; set; }
        /// <summary>
        /// The immutability period for the blobs in the container since the policy creation, in days.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The immutability period for the blobs in the container since the policy creation, in days.",
        SerializedName = @"immutabilityPeriodSinceCreationInDays",
        PossibleTypes = new [] { typeof(int) })]
        int ImmutabilityPeriodSinceCreationInDay { get; set; }
        /// <summary>
        /// The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState? State { get;  }

    }
    /// The ImmutabilityPolicy property of a blob container, including Id, resource name, resource type, Etag.
    internal partial interface IImmutabilityPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal
    {
        /// <summary>
        /// The ETag HTTP response header. This is an opaque string. You can use it to detect whether the resource has changed between
        /// requests. In particular, you can pass the ETag to one of the If-Match or If-None-Match headers.
        /// </summary>
        string ETag { get; set; }
        /// <summary>
        /// The immutability period for the blobs in the container since the policy creation, in days.
        /// </summary>
        int ImmutabilityPeriodSinceCreationInDay { get; set; }
        /// <summary>The properties of an ImmutabilityPolicy of a blob container.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyProperty Property { get; set; }
        /// <summary>
        /// The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState? State { get; set; }

    }
}