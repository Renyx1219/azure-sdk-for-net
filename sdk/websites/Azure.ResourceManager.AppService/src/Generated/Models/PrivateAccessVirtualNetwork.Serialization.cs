// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class PrivateAccessVirtualNetwork : IUtf8JsonSerializable, IJsonModel<PrivateAccessVirtualNetwork>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateAccessVirtualNetwork>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateAccessVirtualNetwork>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateAccessVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateAccessVirtualNetwork)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Key.HasValue)
            {
                writer.WritePropertyName("key"u8);
                writer.WriteNumberValue(Key.Value);
            }
            if (ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (!(Subnets is ChangeTrackingList<PrivateAccessSubnet> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("subnets"u8);
                writer.WriteStartArray();
                foreach (var item in Subnets)
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

        PrivateAccessVirtualNetwork IJsonModel<PrivateAccessVirtualNetwork>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateAccessVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateAccessVirtualNetwork)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateAccessVirtualNetwork(document.RootElement, options);
        }

        internal static PrivateAccessVirtualNetwork DeserializePrivateAccessVirtualNetwork(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<int> key = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<IList<PrivateAccessSubnet>> subnets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    key = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateAccessSubnet> array = new List<PrivateAccessSubnet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateAccessSubnet.DeserializePrivateAccessSubnet(item, options));
                    }
                    subnets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateAccessVirtualNetwork(name.Value, Optional.ToNullable(key), resourceId.Value, Optional.ToList(subnets), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateAccessVirtualNetwork>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateAccessVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateAccessVirtualNetwork)} does not support '{options.Format}' format.");
            }
        }

        PrivateAccessVirtualNetwork IPersistableModel<PrivateAccessVirtualNetwork>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateAccessVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateAccessVirtualNetwork(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateAccessVirtualNetwork)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateAccessVirtualNetwork>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
