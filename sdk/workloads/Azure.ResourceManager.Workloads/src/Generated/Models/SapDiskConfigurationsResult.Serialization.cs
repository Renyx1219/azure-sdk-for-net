// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapDiskConfigurationsResult : IUtf8JsonSerializable, IJsonModel<SapDiskConfigurationsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapDiskConfigurationsResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapDiskConfigurationsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiskConfigurationsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapDiskConfigurationsResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(VolumeConfigurations is ChangeTrackingDictionary<string, SapDiskConfiguration> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("volumeConfigurations"u8);
                writer.WriteStartObject();
                foreach (var item in VolumeConfigurations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        SapDiskConfigurationsResult IJsonModel<SapDiskConfigurationsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiskConfigurationsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapDiskConfigurationsResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapDiskConfigurationsResult(document.RootElement, options);
        }

        internal static SapDiskConfigurationsResult DeserializeSapDiskConfigurationsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, SapDiskConfiguration>> volumeConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SapDiskConfiguration> dictionary = new Dictionary<string, SapDiskConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SapDiskConfiguration.DeserializeSapDiskConfiguration(property0.Value, options));
                    }
                    volumeConfigurations = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapDiskConfigurationsResult(Optional.ToDictionary(volumeConfigurations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapDiskConfigurationsResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiskConfigurationsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapDiskConfigurationsResult)} does not support '{options.Format}' format.");
            }
        }

        SapDiskConfigurationsResult IPersistableModel<SapDiskConfigurationsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiskConfigurationsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapDiskConfigurationsResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapDiskConfigurationsResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapDiskConfigurationsResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
