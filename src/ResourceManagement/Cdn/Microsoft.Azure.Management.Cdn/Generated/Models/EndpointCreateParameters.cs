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
    /// Endpoint properties required for new endpoint creation
    /// </summary>
    public partial class EndpointCreateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the EndpointCreateParameters class.
        /// </summary>
        public EndpointCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the EndpointCreateParameters class.
        /// </summary>
        public EndpointCreateParameters(string location, IDictionary<string, string> tags = default(IDictionary<string, string>), string originHostHeader = default(string), string originPath = default(string), IList<string> contentTypesToCompress = default(IList<string>), bool? isCompressionEnabled = default(bool?), bool? isHttpAllowed = default(bool?), bool? isHttpsAllowed = default(bool?), QueryStringCachingBehavior? queryStringCachingBehavior = default(QueryStringCachingBehavior?), IList<DeepCreatedOrigin> origins = default(IList<DeepCreatedOrigin>))
        {
            Location = location;
            Tags = tags;
            OriginHostHeader = originHostHeader;
            OriginPath = originPath;
            ContentTypesToCompress = contentTypesToCompress;
            IsCompressionEnabled = isCompressionEnabled;
            IsHttpAllowed = isHttpAllowed;
            IsHttpsAllowed = isHttpsAllowed;
            QueryStringCachingBehavior = queryStringCachingBehavior;
            Origins = origins;
        }

        /// <summary>
        /// Endpoint location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Endpoint tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The host header CDN provider will send along with content requests
        /// to origins. The default value would be the host name of the
        /// origin.
        /// </summary>
        [JsonProperty(PropertyName = "properties.originHostHeader")]
        public string OriginHostHeader { get; set; }

        /// <summary>
        /// The path used for origin requests
        /// </summary>
        [JsonProperty(PropertyName = "properties.originPath")]
        public string OriginPath { get; set; }

        /// <summary>
        /// List of content types on which compression will be applied. The
        /// value for the elements should be Internet media type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentTypesToCompress")]
        public IList<string> ContentTypesToCompress { get; set; }

        /// <summary>
        /// Indicates whether the compression is enabled. Default value is
        /// false. If compression is enabled, the content transferred from
        /// cdn endpoint to end user will be compressed. The requested
        /// content must be larger than 1 byte and smaller than 1 MB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCompressionEnabled")]
        public bool? IsCompressionEnabled { get; set; }

        /// <summary>
        /// Indicates whether http traffic is allowed on the endpoint. Default
        /// value is true. At least one protocol (http or https) must be
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHttpAllowed")]
        public bool? IsHttpAllowed { get; set; }

        /// <summary>
        /// Indicates whether https traffic is allowed on the endpoint.
        /// Default value is true. At least one protocol (http or https) must
        /// be allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHttpsAllowed")]
        public bool? IsHttpsAllowed { get; set; }

        /// <summary>
        /// Sets query string caching behavior. Possible values for this
        /// property include: 'IgnoreQueryString', 'BypassCaching',
        /// 'UseQueryString'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStringCachingBehavior")]
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }

        /// <summary>
        /// The set of origins of the CDN endpoint. When multiple origins
        /// exist, the first origin will be used as primary and rest will be
        /// used as failover options.
        /// </summary>
        [JsonProperty(PropertyName = "properties.origins")]
        public IList<DeepCreatedOrigin> Origins { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (this.Origins != null)
            {
                foreach (var element in this.Origins)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
