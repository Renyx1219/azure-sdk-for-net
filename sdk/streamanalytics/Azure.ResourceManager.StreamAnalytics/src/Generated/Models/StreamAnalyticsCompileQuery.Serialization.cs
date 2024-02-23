// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsCompileQuery : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsCompileQuery>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsCompileQuery>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamAnalyticsCompileQuery>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsCompileQuery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsCompileQuery)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("query"u8);
            writer.WriteStringValue(Query);
            if (!(Inputs is ChangeTrackingList<StreamAnalyticsQueryInput> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Functions is ChangeTrackingList<StreamAnalyticsQueryFunction> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("functions"u8);
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType.ToString());
            if (CompatibilityLevel.HasValue)
            {
                writer.WritePropertyName("compatibilityLevel"u8);
                writer.WriteStringValue(CompatibilityLevel.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        StreamAnalyticsCompileQuery IJsonModel<StreamAnalyticsCompileQuery>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsCompileQuery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsCompileQuery)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsCompileQuery(document.RootElement, options);
        }

        internal static StreamAnalyticsCompileQuery DeserializeStreamAnalyticsCompileQuery(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string query = default;
            Optional<IList<StreamAnalyticsQueryInput>> inputs = default;
            Optional<IList<StreamAnalyticsQueryFunction>> functions = default;
            StreamingJobType jobType = default;
            Optional<StreamingJobCompatibilityLevel> compatibilityLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamAnalyticsQueryInput> array = new List<StreamAnalyticsQueryInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamAnalyticsQueryInput.DeserializeStreamAnalyticsQueryInput(item, options));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("functions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamAnalyticsQueryFunction> array = new List<StreamAnalyticsQueryFunction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamAnalyticsQueryFunction.DeserializeStreamAnalyticsQueryFunction(item, options));
                    }
                    functions = array;
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = new StreamingJobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("compatibilityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compatibilityLevel = new StreamingJobCompatibilityLevel(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamAnalyticsCompileQuery(query, Optional.ToList(inputs), Optional.ToList(functions), jobType, Optional.ToNullable(compatibilityLevel), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamAnalyticsCompileQuery>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsCompileQuery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsCompileQuery)} does not support '{options.Format}' format.");
            }
        }

        StreamAnalyticsCompileQuery IPersistableModel<StreamAnalyticsCompileQuery>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsCompileQuery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsCompileQuery(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsCompileQuery)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsCompileQuery>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
