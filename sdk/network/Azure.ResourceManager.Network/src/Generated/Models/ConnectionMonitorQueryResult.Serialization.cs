// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorQueryResult : IUtf8JsonSerializable, IJsonModel<ConnectionMonitorQueryResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionMonitorQueryResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectionMonitorQueryResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorQueryResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorQueryResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SourceStatus.HasValue)
            {
                writer.WritePropertyName("sourceStatus"u8);
                writer.WriteStringValue(SourceStatus.Value.ToString());
            }
            if (!(States is ChangeTrackingList<ConnectionStateSnapshot> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("states"u8);
                writer.WriteStartArray();
                foreach (var item in States)
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

        ConnectionMonitorQueryResult IJsonModel<ConnectionMonitorQueryResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorQueryResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorQueryResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorQueryResult(document.RootElement, options);
        }

        internal static ConnectionMonitorQueryResult DeserializeConnectionMonitorQueryResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ConnectionMonitorSourceStatus> sourceStatus = default;
            Optional<IReadOnlyList<ConnectionStateSnapshot>> states = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceStatus = new ConnectionMonitorSourceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("states"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionStateSnapshot> array = new List<ConnectionStateSnapshot>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionStateSnapshot.DeserializeConnectionStateSnapshot(item, options));
                    }
                    states = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectionMonitorQueryResult(Optional.ToNullable(sourceStatus), Optional.ToList(states), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectionMonitorQueryResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorQueryResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectionMonitorQueryResult)} does not support '{options.Format}' format.");
            }
        }

        ConnectionMonitorQueryResult IPersistableModel<ConnectionMonitorQueryResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorQueryResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectionMonitorQueryResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectionMonitorQueryResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectionMonitorQueryResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
