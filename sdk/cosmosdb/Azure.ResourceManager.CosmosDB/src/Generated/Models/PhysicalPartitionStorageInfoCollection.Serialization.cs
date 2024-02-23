// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PhysicalPartitionStorageInfoCollection : IUtf8JsonSerializable, IJsonModel<PhysicalPartitionStorageInfoCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PhysicalPartitionStorageInfoCollection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PhysicalPartitionStorageInfoCollection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionStorageInfoCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PhysicalPartitionStorageInfoCollection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(PhysicalPartitionStorageInfoCollectionValue is ChangeTrackingList<PhysicalPartitionStorageInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("physicalPartitionStorageInfoCollection"u8);
                writer.WriteStartArray();
                foreach (var item in PhysicalPartitionStorageInfoCollectionValue)
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

        PhysicalPartitionStorageInfoCollection IJsonModel<PhysicalPartitionStorageInfoCollection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionStorageInfoCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PhysicalPartitionStorageInfoCollection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePhysicalPartitionStorageInfoCollection(document.RootElement, options);
        }

        internal static PhysicalPartitionStorageInfoCollection DeserializePhysicalPartitionStorageInfoCollection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PhysicalPartitionStorageInfo>> physicalPartitionStorageInfoCollection = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("physicalPartitionStorageInfoCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PhysicalPartitionStorageInfo> array = new List<PhysicalPartitionStorageInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PhysicalPartitionStorageInfo.DeserializePhysicalPartitionStorageInfo(item, options));
                    }
                    physicalPartitionStorageInfoCollection = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PhysicalPartitionStorageInfoCollection(Optional.ToList(physicalPartitionStorageInfoCollection), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PhysicalPartitionStorageInfoCollection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionStorageInfoCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PhysicalPartitionStorageInfoCollection)} does not support '{options.Format}' format.");
            }
        }

        PhysicalPartitionStorageInfoCollection IPersistableModel<PhysicalPartitionStorageInfoCollection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionStorageInfoCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePhysicalPartitionStorageInfoCollection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PhysicalPartitionStorageInfoCollection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PhysicalPartitionStorageInfoCollection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
