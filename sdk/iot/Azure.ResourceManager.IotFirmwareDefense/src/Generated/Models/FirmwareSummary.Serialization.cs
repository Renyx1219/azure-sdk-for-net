// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class FirmwareSummary : IUtf8JsonSerializable, IJsonModel<FirmwareSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirmwareSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirmwareSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirmwareSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ExtractedSize.HasValue)
            {
                if (ExtractedSize != null)
                {
                    writer.WritePropertyName("extractedSize"u8);
                    writer.WriteNumberValue(ExtractedSize.Value);
                }
                else
                {
                    writer.WriteNull("extractedSize");
                }
            }
            if (FileSize.HasValue)
            {
                if (FileSize != null)
                {
                    writer.WritePropertyName("fileSize"u8);
                    writer.WriteNumberValue(FileSize.Value);
                }
                else
                {
                    writer.WriteNull("fileSize");
                }
            }
            if (ExtractedFileCount.HasValue)
            {
                if (ExtractedFileCount != null)
                {
                    writer.WritePropertyName("extractedFileCount"u8);
                    writer.WriteNumberValue(ExtractedFileCount.Value);
                }
                else
                {
                    writer.WriteNull("extractedFileCount");
                }
            }
            if (ComponentCount.HasValue)
            {
                if (ComponentCount != null)
                {
                    writer.WritePropertyName("componentCount"u8);
                    writer.WriteNumberValue(ComponentCount.Value);
                }
                else
                {
                    writer.WriteNull("componentCount");
                }
            }
            if (BinaryCount.HasValue)
            {
                if (BinaryCount != null)
                {
                    writer.WritePropertyName("binaryCount"u8);
                    writer.WriteNumberValue(BinaryCount.Value);
                }
                else
                {
                    writer.WriteNull("binaryCount");
                }
            }
            if (AnalysisTimeSeconds.HasValue)
            {
                if (AnalysisTimeSeconds != null)
                {
                    writer.WritePropertyName("analysisTimeSeconds"u8);
                    writer.WriteNumberValue(AnalysisTimeSeconds.Value);
                }
                else
                {
                    writer.WriteNull("analysisTimeSeconds");
                }
            }
            if (RootFileSystems.HasValue)
            {
                if (RootFileSystems != null)
                {
                    writer.WritePropertyName("rootFileSystems"u8);
                    writer.WriteNumberValue(RootFileSystems.Value);
                }
                else
                {
                    writer.WriteNull("rootFileSystems");
                }
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

        FirmwareSummary IJsonModel<FirmwareSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirmwareSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirmwareSummary(document.RootElement, options);
        }

        internal static FirmwareSummary DeserializeFirmwareSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long?> extractedSize = default;
            Optional<long?> fileSize = default;
            Optional<long?> extractedFileCount = default;
            Optional<long?> componentCount = default;
            Optional<long?> binaryCount = default;
            Optional<long?> analysisTimeSeconds = default;
            Optional<long?> rootFileSystems = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extractedSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        extractedSize = null;
                        continue;
                    }
                    extractedSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fileSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fileSize = null;
                        continue;
                    }
                    fileSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("extractedFileCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        extractedFileCount = null;
                        continue;
                    }
                    extractedFileCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("componentCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        componentCount = null;
                        continue;
                    }
                    componentCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("binaryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        binaryCount = null;
                        continue;
                    }
                    binaryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("analysisTimeSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        analysisTimeSeconds = null;
                        continue;
                    }
                    analysisTimeSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rootFileSystems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rootFileSystems = null;
                        continue;
                    }
                    rootFileSystems = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirmwareSummary(Optional.ToNullable(extractedSize), Optional.ToNullable(fileSize), Optional.ToNullable(extractedFileCount), Optional.ToNullable(componentCount), Optional.ToNullable(binaryCount), Optional.ToNullable(analysisTimeSeconds), Optional.ToNullable(rootFileSystems), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirmwareSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirmwareSummary)} does not support '{options.Format}' format.");
            }
        }

        FirmwareSummary IPersistableModel<FirmwareSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirmwareSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirmwareSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirmwareSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
