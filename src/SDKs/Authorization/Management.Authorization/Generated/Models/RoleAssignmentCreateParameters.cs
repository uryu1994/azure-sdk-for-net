// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Authorization;
    using Newtonsoft.Json;

    /// <summary>
    /// Role assignment create parameters.
    /// </summary>
    public partial class RoleAssignmentCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignmentCreateParameters
        /// class.
        /// </summary>
        public RoleAssignmentCreateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleAssignmentCreateParameters
        /// class.
        /// </summary>
        /// <param name="properties">Role assignment properties.</param>
        public RoleAssignmentCreateParameters(RoleAssignmentProperties properties = default(RoleAssignmentProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets role assignment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RoleAssignmentProperties Properties { get; set; }

    }
}
