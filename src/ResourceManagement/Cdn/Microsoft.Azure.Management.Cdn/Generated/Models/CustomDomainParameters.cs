// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// CustomDomain properties required for custom domain creation or update
    /// </summary>
    public partial class CustomDomainParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomainParameters class.
        /// </summary>
        public CustomDomainParameters() { }

        /// <summary>
        /// Initializes a new instance of the CustomDomainParameters class.
        /// </summary>
        public CustomDomainParameters(string hostName)
        {
            HostName = hostName;
        }

        /// <summary>
        /// The host name of the custom domain
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
        }
    }
}
