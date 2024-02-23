// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class ServerEditionCapabilityV2 : IUtf8JsonSerializable, IJsonModel<ServerEditionCapabilityV2>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerEditionCapabilityV2>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServerEditionCapabilityV2>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEditionCapabilityV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEditionCapabilityV2)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && DefaultSku != null)
            {
                writer.WritePropertyName("defaultSku"u8);
                writer.WriteStringValue(DefaultSku);
            }
            if (options.Format != "W" && DefaultStorageSize.HasValue)
            {
                writer.WritePropertyName("defaultStorageSize"u8);
                writer.WriteNumberValue(DefaultStorageSize.Value);
            }
            if (options.Format != "W" && !(SupportedStorageEditions is ChangeTrackingList<MySqlFlexibleServerStorageEditionCapability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedStorageEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedStorageEditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(SupportedSkus is ChangeTrackingList<SkuCapabilityV2> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("supportedSkus"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedSkus)
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

        ServerEditionCapabilityV2 IJsonModel<ServerEditionCapabilityV2>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEditionCapabilityV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEditionCapabilityV2)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerEditionCapabilityV2(document.RootElement, options);
        }

        internal static ServerEditionCapabilityV2 DeserializeServerEditionCapabilityV2(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> defaultSku = default;
            Optional<int> defaultStorageSize = default;
            Optional<IReadOnlyList<MySqlFlexibleServerStorageEditionCapability>> supportedStorageEditions = default;
            Optional<IReadOnlyList<SkuCapabilityV2>> supportedSkus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultSku"u8))
                {
                    defaultSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultStorageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultStorageSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("supportedStorageEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerStorageEditionCapability> array = new List<MySqlFlexibleServerStorageEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerStorageEditionCapability.DeserializeMySqlFlexibleServerStorageEditionCapability(item, options));
                    }
                    supportedStorageEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedSkus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SkuCapabilityV2> array = new List<SkuCapabilityV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuCapabilityV2.DeserializeSkuCapabilityV2(item, options));
                    }
                    supportedSkus = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServerEditionCapabilityV2(name.Value, defaultSku.Value, Optional.ToNullable(defaultStorageSize), Optional.ToList(supportedStorageEditions), Optional.ToList(supportedSkus), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerEditionCapabilityV2>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEditionCapabilityV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerEditionCapabilityV2)} does not support '{options.Format}' format.");
            }
        }

        ServerEditionCapabilityV2 IPersistableModel<ServerEditionCapabilityV2>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEditionCapabilityV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerEditionCapabilityV2(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerEditionCapabilityV2)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerEditionCapabilityV2>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
