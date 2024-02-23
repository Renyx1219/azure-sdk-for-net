// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountOutboundEnvironmentEndpoint : IUtf8JsonSerializable, IJsonModel<BatchAccountOutboundEnvironmentEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountOutboundEnvironmentEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountOutboundEnvironmentEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountOutboundEnvironmentEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountOutboundEnvironmentEndpoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (options.Format != "W" && !(Endpoints is ChangeTrackingList<BatchAccountEndpointDependency> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        BatchAccountOutboundEnvironmentEndpoint IJsonModel<BatchAccountOutboundEnvironmentEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountOutboundEnvironmentEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountOutboundEnvironmentEndpoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountOutboundEnvironmentEndpoint(document.RootElement, options);
        }

        internal static BatchAccountOutboundEnvironmentEndpoint DeserializeBatchAccountOutboundEnvironmentEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> category = default;
            Optional<IReadOnlyList<BatchAccountEndpointDependency>> endpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchAccountEndpointDependency> array = new List<BatchAccountEndpointDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchAccountEndpointDependency.DeserializeBatchAccountEndpointDependency(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountOutboundEnvironmentEndpoint(category.Value, Optional.ToList(endpoints), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountOutboundEnvironmentEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountOutboundEnvironmentEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAccountOutboundEnvironmentEndpoint)} does not support '{options.Format}' format.");
            }
        }

        BatchAccountOutboundEnvironmentEndpoint IPersistableModel<BatchAccountOutboundEnvironmentEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountOutboundEnvironmentEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountOutboundEnvironmentEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAccountOutboundEnvironmentEndpoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountOutboundEnvironmentEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
