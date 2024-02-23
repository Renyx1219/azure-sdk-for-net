// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheEncryptionSettings : IUtf8JsonSerializable, IJsonModel<StorageCacheEncryptionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheEncryptionSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageCacheEncryptionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheEncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheEncryptionSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (KeyEncryptionKey != null)
            {
                writer.WritePropertyName("keyEncryptionKey"u8);
                writer.WriteObjectValue(KeyEncryptionKey);
            }
            if (EnableRotationToLatestKeyVersion.HasValue)
            {
                writer.WritePropertyName("rotationToLatestKeyVersionEnabled"u8);
                writer.WriteBooleanValue(EnableRotationToLatestKeyVersion.Value);
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

        StorageCacheEncryptionSettings IJsonModel<StorageCacheEncryptionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheEncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheEncryptionSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheEncryptionSettings(document.RootElement, options);
        }

        internal static StorageCacheEncryptionSettings DeserializeStorageCacheEncryptionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageCacheEncryptionKeyVaultKeyReference> keyEncryptionKey = default;
            Optional<bool> rotationToLatestKeyVersionEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = StorageCacheEncryptionKeyVaultKeyReference.DeserializeStorageCacheEncryptionKeyVaultKeyReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rotationToLatestKeyVersionEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rotationToLatestKeyVersionEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageCacheEncryptionSettings(keyEncryptionKey.Value, Optional.ToNullable(rotationToLatestKeyVersionEnabled), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheEncryptionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheEncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheEncryptionSettings)} does not support '{options.Format}' format.");
            }
        }

        StorageCacheEncryptionSettings IPersistableModel<StorageCacheEncryptionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheEncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheEncryptionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageCacheEncryptionSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheEncryptionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
