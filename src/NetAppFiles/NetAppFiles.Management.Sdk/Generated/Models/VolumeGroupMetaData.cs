// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Volume group properties
    /// </summary>
    public partial class VolumeGroupMetaData
    {
        /// <summary>
        /// Initializes a new instance of the VolumeGroupMetaData class.
        /// </summary>
        public VolumeGroupMetaData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumeGroupMetaData class.
        /// </summary>

        /// <param name="groupDescription">Group Description
        /// </param>

        /// <param name="applicationType">Application Type
        /// Possible values include: 'SAP-HANA'</param>

        /// <param name="applicationIdentifier">Application specific identifier
        /// </param>

        /// <param name="globalPlacementRules">Application specific placement rules for the volume group
        /// </param>

        /// <param name="deploymentSpecId">Application specific identifier of deployment rules for the volume group
        /// </param>

        /// <param name="volumesCount">Number of volumes in volume group
        /// </param>
        public VolumeGroupMetaData(string groupDescription = default(string), string applicationType = default(string), string applicationIdentifier = default(string), System.Collections.Generic.IList<PlacementKeyValuePairs> globalPlacementRules = default(System.Collections.Generic.IList<PlacementKeyValuePairs>), string deploymentSpecId = default(string), long? volumesCount = default(long?))

        {
            this.GroupDescription = groupDescription;
            this.ApplicationType = applicationType;
            this.ApplicationIdentifier = applicationIdentifier;
            this.GlobalPlacementRules = globalPlacementRules;
            this.DeploymentSpecId = deploymentSpecId;
            this.VolumesCount = volumesCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets group Description
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "groupDescription")]
        public string GroupDescription {get; set; }

        /// <summary>
        /// Gets or sets application Type Possible values include: &#39;SAP-HANA&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationType")]
        public string ApplicationType {get; set; }

        /// <summary>
        /// Gets or sets application specific identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationIdentifier")]
        public string ApplicationIdentifier {get; set; }

        /// <summary>
        /// Gets or sets application specific placement rules for the volume group
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "globalPlacementRules")]
        public System.Collections.Generic.IList<PlacementKeyValuePairs> GlobalPlacementRules {get; set; }

        /// <summary>
        /// Gets or sets application specific identifier of deployment rules for the
        /// volume group
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "deploymentSpecId")]
        public string DeploymentSpecId {get; set; }

        /// <summary>
        /// Gets number of volumes in volume group
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "volumesCount")]
        public long? VolumesCount {get; private set; }
    }
}