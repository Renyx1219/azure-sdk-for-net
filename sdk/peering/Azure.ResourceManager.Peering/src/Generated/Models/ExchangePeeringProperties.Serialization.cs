// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class ExchangePeeringProperties : IUtf8JsonSerializable, IJsonModel<ExchangePeeringProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExchangePeeringProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExchangePeeringProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangePeeringProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExchangePeeringProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Connections is ChangeTrackingList<PeeringExchangeConnection> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("connections"u8);
                writer.WriteStartArray();
                foreach (var item in Connections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PeerAsn != null)
            {
                writer.WritePropertyName("peerAsn"u8);
                JsonSerializer.Serialize(writer, PeerAsn);
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

        ExchangePeeringProperties IJsonModel<ExchangePeeringProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangePeeringProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExchangePeeringProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExchangePeeringProperties(document.RootElement, options);
        }

        internal static ExchangePeeringProperties DeserializeExchangePeeringProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<PeeringExchangeConnection>> connections = default;
            Optional<WritableSubResource> peerAsn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringExchangeConnection> array = new List<PeeringExchangeConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringExchangeConnection.DeserializePeeringExchangeConnection(item, options));
                    }
                    connections = array;
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExchangePeeringProperties(Optional.ToList(connections), peerAsn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExchangePeeringProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangePeeringProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExchangePeeringProperties)} does not support '{options.Format}' format.");
            }
        }

        ExchangePeeringProperties IPersistableModel<ExchangePeeringProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangePeeringProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExchangePeeringProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExchangePeeringProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExchangePeeringProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
