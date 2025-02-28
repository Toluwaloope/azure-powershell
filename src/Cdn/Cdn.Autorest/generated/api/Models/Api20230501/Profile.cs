// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>A profile is a logical grouping of endpoints that share the same settings.</summary>
    public partial class Profile :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.TrackedResource();

        /// <summary>Key-Value pair representing additional properties for profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesExtendedProperties ExtendedProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ExtendedProperty; }

        /// <summary>The Id of the frontdoor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string FrontDoorId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).FrontDoorId; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentity _identity;

        /// <summary>Managed service identity (system assigned and/or user assigned identities).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedServiceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedServiceIdentityType)""); }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>
        /// Kind of the profile. Used by portal to differentiate traditional CDN profile and new AFD profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for ExtendedProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesExtendedProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.ExtendedProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ExtendedProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ExtendedProperty = value; }

        /// <summary>Internal Acessors for FrontDoorId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.FrontDoorId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).FrontDoorId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).FrontDoorId = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Kind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.Kind { get => this._kind; set { {_kind = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ProfileProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ResourceState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.ResourceState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ResourceState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ResourceState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISku Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? OriginResponseTimeoutSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).OriginResponseTimeoutSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).OriginResponseTimeoutSecond = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileProperties _property;

        /// <summary>The JSON object that contains the properties required to create a profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ProfileProperties()); set => this._property = value; }

        /// <summary>Provisioning status of the profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.FormatTable]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Resource status of the profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? ResourceState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesInternal)Property).ResourceState; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISku _sku;

        /// <summary>
        /// The pricing tier (defines Azure Front Door Standard or Premium or a CDN provider, feature list and rate) of the profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.Sku()); set => this._sku = value; }

        /// <summary>Name of the pricing tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName? SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISkuInternal)Sku).Name = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName)""); }

        /// <summary>Read only system data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>An identifier for the identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>An identifier for the identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__trackedResource).Type; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResourceInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="Profile" /> instance.</summary>
        public Profile()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// A profile is a logical grouping of endpoints that share the same settings.
    public partial interface IProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResource
    {
        /// <summary>Key-Value pair representing additional properties for profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Key-Value pair representing additional properties for profiles.",
        SerializedName = @"extendedProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesExtendedProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesExtendedProperties ExtendedProperty { get;  }
        /// <summary>The Id of the frontdoor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Id of the frontdoor.",
        SerializedName = @"frontDoorId",
        PossibleTypes = new [] { typeof(string) })]
        string FrontDoorId { get;  }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedServiceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedServiceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// Kind of the profile. Used by portal to differentiate traditional CDN profile and new AFD profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Kind of the profile. Used by portal to differentiate traditional CDN profile and new AFD profile.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string Kind { get;  }
        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.",
        SerializedName = @"originResponseTimeoutSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? OriginResponseTimeoutSecond { get; set; }
        /// <summary>Provisioning status of the profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning status of the profile.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? ProvisioningState { get;  }
        /// <summary>Resource status of the profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource status of the profile.",
        SerializedName = @"resourceState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? ResourceState { get;  }
        /// <summary>Name of the pricing tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the pricing tier.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName? SkuName { get; set; }

    }
    /// A profile is a logical grouping of endpoints that share the same settings.
    internal partial interface IProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ITrackedResourceInternal
    {
        /// <summary>Key-Value pair representing additional properties for profiles.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfilePropertiesExtendedProperties ExtendedProperty { get; set; }
        /// <summary>The Id of the frontdoor.</summary>
        string FrontDoorId { get; set; }
        /// <summary>Managed service identity (system assigned and/or user assigned identities).</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedServiceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// Kind of the profile. Used by portal to differentiate traditional CDN profile and new AFD profile.
        /// </summary>
        string Kind { get; set; }
        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        int? OriginResponseTimeoutSecond { get; set; }
        /// <summary>The JSON object that contains the properties required to create a profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IProfileProperties Property { get; set; }
        /// <summary>Provisioning status of the profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? ProvisioningState { get; set; }
        /// <summary>Resource status of the profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? ResourceState { get; set; }
        /// <summary>
        /// The pricing tier (defines Azure Front Door Standard or Premium or a CDN provider, feature list and rate) of the profile.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISku Sku { get; set; }
        /// <summary>Name of the pricing tier.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName? SkuName { get; set; }

    }
}