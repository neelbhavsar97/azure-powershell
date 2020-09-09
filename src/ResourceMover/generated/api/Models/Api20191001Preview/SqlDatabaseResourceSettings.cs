namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Extensions;

    /// <summary>Defines the Sql Database resource settings.</summary>
    public partial class SqlDatabaseResourceSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.ISqlDatabaseResourceSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.ISqlDatabaseResourceSettingsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettings"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettings __resourceSettings = new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.ResourceSettings();

        /// <summary>
        /// The resource type. For example, the value can be Microsoft.Compute/virtualMachines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Inherited)]
        public string ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettingsInternal)__resourceSettings).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettingsInternal)__resourceSettings).ResourceType = value; }

        /// <summary>Gets or sets the target Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Inherited)]
        public string TargetResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettingsInternal)__resourceSettings).TargetResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettingsInternal)__resourceSettings).TargetResourceName = value; }

        /// <summary>Backing field for <see cref="ZoneRedundant" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ZoneRedundant? _zoneRedundant;

        /// <summary>Defines the zone redundant resource setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ZoneRedundant? ZoneRedundant { get => this._zoneRedundant; set => this._zoneRedundant = value; }

        /// <summary>Creates an new <see cref="SqlDatabaseResourceSettings" /> instance.</summary>
        public SqlDatabaseResourceSettings()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceSettings), __resourceSettings);
            await eventListener.AssertObjectIsValid(nameof(__resourceSettings), __resourceSettings);
        }
    }
    /// Defines the Sql Database resource settings.
    public partial interface ISqlDatabaseResourceSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettings
    {
        /// <summary>Defines the zone redundant resource setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Defines the zone redundant resource setting.",
        SerializedName = @"zoneRedundant",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ZoneRedundant) })]
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ZoneRedundant? ZoneRedundant { get; set; }

    }
    /// Defines the Sql Database resource settings.
    internal partial interface ISqlDatabaseResourceSettingsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettingsInternal
    {
        /// <summary>Defines the zone redundant resource setting.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ZoneRedundant? ZoneRedundant { get; set; }

    }
}