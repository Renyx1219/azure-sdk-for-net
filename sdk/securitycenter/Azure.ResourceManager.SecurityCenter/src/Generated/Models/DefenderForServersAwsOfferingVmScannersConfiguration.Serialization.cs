// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersAwsOfferingVmScannersConfiguration : IUtf8JsonSerializable, IJsonModel<DefenderForServersAwsOfferingVmScannersConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForServersAwsOfferingVmScannersConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderForServersAwsOfferingVmScannersConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingVmScannersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingVmScannersConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CloudRoleArn != null)
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
            }
            if (ScanningMode.HasValue)
            {
                writer.WritePropertyName("scanningMode"u8);
                writer.WriteStringValue(ScanningMode.Value.ToString());
            }
            if (!(ExclusionTags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("exclusionTags"u8);
                writer.WriteStartObject();
                foreach (var item in ExclusionTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
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

        DefenderForServersAwsOfferingVmScannersConfiguration IJsonModel<DefenderForServersAwsOfferingVmScannersConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingVmScannersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingVmScannersConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersAwsOfferingVmScannersConfiguration(document.RootElement, options);
        }

        internal static DefenderForServersAwsOfferingVmScannersConfiguration DeserializeDefenderForServersAwsOfferingVmScannersConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cloudRoleArn = default;
            Optional<DefenderForServersScanningMode> scanningMode = default;
            Optional<IDictionary<string, string>> exclusionTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scanningMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scanningMode = new DefenderForServersScanningMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exclusionTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    exclusionTags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderForServersAwsOfferingVmScannersConfiguration(cloudRoleArn.Value, Optional.ToNullable(scanningMode), Optional.ToDictionary(exclusionTags), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForServersAwsOfferingVmScannersConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingVmScannersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingVmScannersConfiguration)} does not support '{options.Format}' format.");
            }
        }

        DefenderForServersAwsOfferingVmScannersConfiguration IPersistableModel<DefenderForServersAwsOfferingVmScannersConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingVmScannersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForServersAwsOfferingVmScannersConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingVmScannersConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForServersAwsOfferingVmScannersConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
