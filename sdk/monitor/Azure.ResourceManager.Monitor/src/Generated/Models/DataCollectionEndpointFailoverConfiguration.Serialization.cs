// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionEndpointFailoverConfiguration : IUtf8JsonSerializable, IJsonModel<DataCollectionEndpointFailoverConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionEndpointFailoverConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionEndpointFailoverConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointFailoverConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionEndpointFailoverConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ActiveLocation != null)
            {
                writer.WritePropertyName("activeLocation"u8);
                writer.WriteStringValue(ActiveLocation);
            }
            if (!(Locations is ChangeTrackingList<DataCollectionRuleBcdrLocationSpec> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
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

        DataCollectionEndpointFailoverConfiguration IJsonModel<DataCollectionEndpointFailoverConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointFailoverConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionEndpointFailoverConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionEndpointFailoverConfiguration(document.RootElement, options);
        }

        internal static DataCollectionEndpointFailoverConfiguration DeserializeDataCollectionEndpointFailoverConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> activeLocation = default;
            Optional<IReadOnlyList<DataCollectionRuleBcdrLocationSpec>> locations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeLocation"u8))
                {
                    activeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleBcdrLocationSpec> array = new List<DataCollectionRuleBcdrLocationSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleBcdrLocationSpec.DeserializeDataCollectionRuleBcdrLocationSpec(item, options));
                    }
                    locations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionEndpointFailoverConfiguration(activeLocation.Value, Optional.ToList(locations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionEndpointFailoverConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointFailoverConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionEndpointFailoverConfiguration)} does not support '{options.Format}' format.");
            }
        }

        DataCollectionEndpointFailoverConfiguration IPersistableModel<DataCollectionEndpointFailoverConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointFailoverConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionEndpointFailoverConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionEndpointFailoverConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionEndpointFailoverConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
