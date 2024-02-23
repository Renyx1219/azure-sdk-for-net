// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    public partial class MapsAccountProperties : IUtf8JsonSerializable, IJsonModel<MapsAccountProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapsAccountProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MapsAccountProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsAccountProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && UniqueId.HasValue)
            {
                writer.WritePropertyName("uniqueId"u8);
                writer.WriteStringValue(UniqueId.Value);
            }
            if (DisableLocalAuth.HasValue)
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (!(LinkedResources is ChangeTrackingList<MapsLinkedResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("linkedResources"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedResources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Cors != null)
            {
                writer.WritePropertyName("cors"u8);
                writer.WriteObjectValue(Cors);
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

        MapsAccountProperties IJsonModel<MapsAccountProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsAccountProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsAccountProperties(document.RootElement, options);
        }

        internal static MapsAccountProperties DeserializeMapsAccountProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> uniqueId = default;
            Optional<bool> disableLocalAuth = default;
            Optional<string> provisioningState = default;
            Optional<IList<MapsLinkedResource>> linkedResources = default;
            Optional<CorsRules> cors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uniqueId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uniqueId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapsLinkedResource> array = new List<MapsLinkedResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsLinkedResource.DeserializeMapsLinkedResource(item, options));
                    }
                    linkedResources = array;
                    continue;
                }
                if (property.NameEquals("cors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cors = CorsRules.DeserializeCorsRules(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MapsAccountProperties(Optional.ToNullable(uniqueId), Optional.ToNullable(disableLocalAuth), provisioningState.Value, Optional.ToList(linkedResources), cors.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapsAccountProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MapsAccountProperties)} does not support '{options.Format}' format.");
            }
        }

        MapsAccountProperties IPersistableModel<MapsAccountProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMapsAccountProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MapsAccountProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MapsAccountProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
