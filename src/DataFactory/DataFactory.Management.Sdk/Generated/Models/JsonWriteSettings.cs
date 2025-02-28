// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Json write settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("JsonWriteSettings")]
    public partial class JsonWriteSettings : FormatWriteSettings
    {
        /// <summary>
        /// Initializes a new instance of the JsonWriteSettings class.
        /// </summary>
        public JsonWriteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonWriteSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="filePattern">File pattern of JSON. This setting
        /// controls the way a collection of JSON objects will be treated. The
        /// default value is 'setOfObjects'. It is case-sensitive.</param>
        public JsonWriteSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object filePattern = default(object))
            : base(additionalProperties)
        {
            FilePattern = filePattern;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets file pattern of JSON. This setting controls the way a
        /// collection of JSON objects will be treated. The default value is
        /// 'setOfObjects'. It is case-sensitive.
        /// </summary>
        [JsonProperty(PropertyName = "filePattern")]
        public object FilePattern { get; set; }

    }
}
