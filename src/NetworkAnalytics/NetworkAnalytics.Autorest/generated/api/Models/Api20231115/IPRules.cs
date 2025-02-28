// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
    public partial class IPRules :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IIPRules,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IIPRulesInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>The action of virtual network rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Action { get => this._action; set => this._action = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>IP Rules Value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="IPRules" /> instance.</summary>
        public IPRules()
        {

        }
    }
    /// IP rule with specific IP or IP range in CIDR format.
    public partial interface IIPRules :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>The action of virtual network rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The action of virtual network rule.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        string Action { get; set; }
        /// <summary>IP Rules Value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP Rules Value",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// IP rule with specific IP or IP range in CIDR format.
    internal partial interface IIPRulesInternal

    {
        /// <summary>The action of virtual network rule.</summary>
        string Action { get; set; }
        /// <summary>IP Rules Value</summary>
        string Value { get; set; }

    }
}