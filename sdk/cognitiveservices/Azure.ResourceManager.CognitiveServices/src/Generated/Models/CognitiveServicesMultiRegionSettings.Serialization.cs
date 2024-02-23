// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesMultiRegionSettings : IUtf8JsonSerializable, IJsonModel<CognitiveServicesMultiRegionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CognitiveServicesMultiRegionSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CognitiveServicesMultiRegionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesMultiRegionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CognitiveServicesMultiRegionSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RoutingMethod.HasValue)
            {
                writer.WritePropertyName("routingMethod"u8);
                writer.WriteStringValue(RoutingMethod.Value.ToString());
            }
            if (!(Regions is ChangeTrackingList<CognitiveServicesRegionSetting> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
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

        CognitiveServicesMultiRegionSettings IJsonModel<CognitiveServicesMultiRegionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesMultiRegionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CognitiveServicesMultiRegionSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesMultiRegionSettings(document.RootElement, options);
        }

        internal static CognitiveServicesMultiRegionSettings DeserializeCognitiveServicesMultiRegionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CognitiveServicesRoutingMethod> routingMethod = default;
            Optional<IList<CognitiveServicesRegionSetting>> regions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingMethod = new CognitiveServicesRoutingMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CognitiveServicesRegionSetting> array = new List<CognitiveServicesRegionSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesRegionSetting.DeserializeCognitiveServicesRegionSetting(item, options));
                    }
                    regions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CognitiveServicesMultiRegionSettings(Optional.ToNullable(routingMethod), Optional.ToList(regions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CognitiveServicesMultiRegionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesMultiRegionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesMultiRegionSettings)} does not support '{options.Format}' format.");
            }
        }

        CognitiveServicesMultiRegionSettings IPersistableModel<CognitiveServicesMultiRegionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesMultiRegionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCognitiveServicesMultiRegionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesMultiRegionSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CognitiveServicesMultiRegionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
