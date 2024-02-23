// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    public partial class FarmBeatsUpdateProperties : IUtf8JsonSerializable, IJsonModel<FarmBeatsUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FarmBeatsUpdateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FarmBeatsUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FarmBeatsUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FarmBeatsUpdateProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SensorIntegration != null)
            {
                writer.WritePropertyName("sensorIntegration"u8);
                writer.WriteObjectValue(SensorIntegration);
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        FarmBeatsUpdateProperties IJsonModel<FarmBeatsUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FarmBeatsUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FarmBeatsUpdateProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFarmBeatsUpdateProperties(document.RootElement, options);
        }

        internal static FarmBeatsUpdateProperties DeserializeFarmBeatsUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SensorIntegration> sensorIntegration = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensorIntegration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensorIntegration = SensorIntegration.DeserializeSensorIntegration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FarmBeatsUpdateProperties(sensorIntegration.Value, Optional.ToNullable(publicNetworkAccess), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FarmBeatsUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FarmBeatsUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FarmBeatsUpdateProperties)} does not support '{options.Format}' format.");
            }
        }

        FarmBeatsUpdateProperties IPersistableModel<FarmBeatsUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FarmBeatsUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFarmBeatsUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FarmBeatsUpdateProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FarmBeatsUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
