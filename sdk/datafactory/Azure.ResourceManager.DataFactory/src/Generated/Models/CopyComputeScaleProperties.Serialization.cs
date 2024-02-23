// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CopyComputeScaleProperties : IUtf8JsonSerializable, IJsonModel<CopyComputeScaleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CopyComputeScaleProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CopyComputeScaleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyComputeScaleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyComputeScaleProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DataIntegrationUnit.HasValue)
            {
                writer.WritePropertyName("dataIntegrationUnit"u8);
                writer.WriteNumberValue(DataIntegrationUnit.Value);
            }
            if (TimeToLive.HasValue)
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLive.Value);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        CopyComputeScaleProperties IJsonModel<CopyComputeScaleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyComputeScaleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyComputeScaleProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyComputeScaleProperties(document.RootElement, options);
        }

        internal static CopyComputeScaleProperties DeserializeCopyComputeScaleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> dataIntegrationUnit = default;
            Optional<int> timeToLive = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataIntegrationUnit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataIntegrationUnit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CopyComputeScaleProperties(Optional.ToNullable(dataIntegrationUnit), Optional.ToNullable(timeToLive), additionalProperties);
        }

        BinaryData IPersistableModel<CopyComputeScaleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyComputeScaleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CopyComputeScaleProperties)} does not support '{options.Format}' format.");
            }
        }

        CopyComputeScaleProperties IPersistableModel<CopyComputeScaleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyComputeScaleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCopyComputeScaleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CopyComputeScaleProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CopyComputeScaleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
