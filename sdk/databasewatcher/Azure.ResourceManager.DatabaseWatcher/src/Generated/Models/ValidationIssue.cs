// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseWatcher.Models
{
    /// <summary> The model of a health validation issue. </summary>
    public partial class ValidationIssue
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ValidationIssue"/>. </summary>
        /// <param name="errorCode"> The error code of the issue. </param>
        /// <param name="errorMessage"> The error message of the issue. </param>
        /// <param name="recommendationMessage"> The recommendation for resolving the issue. </param>
        internal ValidationIssue(string errorCode, string errorMessage, string recommendationMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            RecommendationMessage = recommendationMessage;
        }

        /// <summary> Initializes a new instance of <see cref="ValidationIssue"/>. </summary>
        /// <param name="errorCode"> The error code of the issue. </param>
        /// <param name="errorMessage"> The error message of the issue. </param>
        /// <param name="additionalDetails"> The additional details for the issue. </param>
        /// <param name="recommendationMessage"> The recommendation for resolving the issue. </param>
        /// <param name="recommendationUri"> The URL related to resolving the issue. </param>
        /// <param name="relatedResourceId"> The resource ID of the Azure resource related to the issue. </param>
        /// <param name="relatedResourceType"> The type of the Azure resource related to the issue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ValidationIssue(string errorCode, string errorMessage, string additionalDetails, string recommendationMessage, Uri recommendationUri, ResourceIdentifier relatedResourceId, string relatedResourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            AdditionalDetails = additionalDetails;
            RecommendationMessage = recommendationMessage;
            RecommendationUri = recommendationUri;
            RelatedResourceId = relatedResourceId;
            RelatedResourceType = relatedResourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ValidationIssue"/> for deserialization. </summary>
        internal ValidationIssue()
        {
        }

        /// <summary> The error code of the issue. </summary>
        public string ErrorCode { get; }
        /// <summary> The error message of the issue. </summary>
        public string ErrorMessage { get; }
        /// <summary> The additional details for the issue. </summary>
        public string AdditionalDetails { get; }
        /// <summary> The recommendation for resolving the issue. </summary>
        public string RecommendationMessage { get; }
        /// <summary> The URL related to resolving the issue. </summary>
        public Uri RecommendationUri { get; }
        /// <summary> The resource ID of the Azure resource related to the issue. </summary>
        public ResourceIdentifier RelatedResourceId { get; }
        /// <summary> The type of the Azure resource related to the issue. </summary>
        public string RelatedResourceType { get; }
    }
}
