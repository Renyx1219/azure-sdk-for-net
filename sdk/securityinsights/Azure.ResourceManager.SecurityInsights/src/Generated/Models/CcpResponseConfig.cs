// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> A custom response configuration for a rule. </summary>
    public partial class CcpResponseConfig
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

        /// <summary> Initializes a new instance of <see cref="CcpResponseConfig"/>. </summary>
        /// <param name="eventsJsonPaths"> The json paths, '$' char is the json root. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventsJsonPaths"/> is null. </exception>
        public CcpResponseConfig(IEnumerable<string> eventsJsonPaths)
        {
            Argument.AssertNotNull(eventsJsonPaths, nameof(eventsJsonPaths));

            EventsJsonPaths = eventsJsonPaths.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CcpResponseConfig"/>. </summary>
        /// <param name="eventsJsonPaths"> The json paths, '$' char is the json root. </param>
        /// <param name="successStatusJsonPath"> The value where the status message/code should appear in the response. </param>
        /// <param name="successStatusValue"> The the status value. </param>
        /// <param name="isGzipCompressed"> The value indicating whether the remote server support Gzip and we should expect Gzip response. </param>
        /// <param name="compressionAlgo"> The compression algorithm. </param>
        /// <param name="format"> The response format. possible values are json,csv,xml. </param>
        /// <param name="csvDelimiter"> The csv delimiter, in case the response format is CSV. </param>
        /// <param name="hasCsvBoundary"> The value indicating whether the response has CSV boundary in case the response in CSV format. </param>
        /// <param name="hasCsvHeader"> The value indicating whether the response has headers in case the response in CSV format. </param>
        /// <param name="isConvertChildPropertiesToArray"> The a value indicating whether the response isn't an array of events / logs.  By setting this flag to true it means the remote server will response with an object which each property has as a value an array of events / logs. </param>
        /// <param name="csvEscape"> Th character used to escape characters in CSV. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CcpResponseConfig(IList<string> eventsJsonPaths, string successStatusJsonPath, string successStatusValue, bool? isGzipCompressed, string compressionAlgo, string format, string csvDelimiter, bool? hasCsvBoundary, bool? hasCsvHeader, bool? isConvertChildPropertiesToArray, string csvEscape, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EventsJsonPaths = eventsJsonPaths;
            SuccessStatusJsonPath = successStatusJsonPath;
            SuccessStatusValue = successStatusValue;
            IsGzipCompressed = isGzipCompressed;
            CompressionAlgo = compressionAlgo;
            Format = format;
            CsvDelimiter = csvDelimiter;
            HasCsvBoundary = hasCsvBoundary;
            HasCsvHeader = hasCsvHeader;
            IsConvertChildPropertiesToArray = isConvertChildPropertiesToArray;
            CsvEscape = csvEscape;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CcpResponseConfig"/> for deserialization. </summary>
        internal CcpResponseConfig()
        {
        }

        /// <summary> The json paths, '$' char is the json root. </summary>
        [WirePath("eventsJsonPaths")]
        public IList<string> EventsJsonPaths { get; }
        /// <summary> The value where the status message/code should appear in the response. </summary>
        [WirePath("successStatusJsonPath")]
        public string SuccessStatusJsonPath { get; set; }
        /// <summary> The the status value. </summary>
        [WirePath("successStatusValue")]
        public string SuccessStatusValue { get; set; }
        /// <summary> The value indicating whether the remote server support Gzip and we should expect Gzip response. </summary>
        [WirePath("isGzipCompressed")]
        public bool? IsGzipCompressed { get; set; }
        /// <summary> The compression algorithm. </summary>
        [WirePath("compressionAlgo")]
        public string CompressionAlgo { get; set; }
        /// <summary> The response format. possible values are json,csv,xml. </summary>
        [WirePath("format")]
        public string Format { get; set; }
        /// <summary> The csv delimiter, in case the response format is CSV. </summary>
        [WirePath("csvDelimiter")]
        public string CsvDelimiter { get; set; }
        /// <summary> The value indicating whether the response has CSV boundary in case the response in CSV format. </summary>
        [WirePath("hasCsvBoundary")]
        public bool? HasCsvBoundary { get; set; }
        /// <summary> The value indicating whether the response has headers in case the response in CSV format. </summary>
        [WirePath("hasCsvHeader")]
        public bool? HasCsvHeader { get; set; }
        /// <summary> The a value indicating whether the response isn't an array of events / logs.  By setting this flag to true it means the remote server will response with an object which each property has as a value an array of events / logs. </summary>
        [WirePath("convertChildPropertiesToArray")]
        public bool? IsConvertChildPropertiesToArray { get; set; }
        /// <summary> Th character used to escape characters in CSV. </summary>
        [WirePath("csvEscape")]
        public string CsvEscape { get; set; }
    }
}
