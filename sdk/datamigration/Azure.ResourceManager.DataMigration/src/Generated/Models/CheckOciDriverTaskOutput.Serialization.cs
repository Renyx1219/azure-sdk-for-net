// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class CheckOciDriverTaskOutput : IUtf8JsonSerializable, IJsonModel<CheckOciDriverTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CheckOciDriverTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CheckOciDriverTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckOciDriverTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckOciDriverTaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (InstalledDriver != null)
            {
                writer.WritePropertyName("installedDriver"u8);
                writer.WriteObjectValue(InstalledDriver);
            }
            if (options.Format != "W" && !(ValidationErrors is ChangeTrackingList<ReportableException> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
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

        CheckOciDriverTaskOutput IJsonModel<CheckOciDriverTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckOciDriverTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckOciDriverTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckOciDriverTaskOutput(document.RootElement, options);
        }

        internal static CheckOciDriverTaskOutput DeserializeCheckOciDriverTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OracleOciDriverInfo> installedDriver = default;
            Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("installedDriver"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installedDriver = OracleOciDriverInfo.DeserializeOracleOciDriverInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    validationErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CheckOciDriverTaskOutput(installedDriver.Value, Optional.ToList(validationErrors), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CheckOciDriverTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckOciDriverTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CheckOciDriverTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        CheckOciDriverTaskOutput IPersistableModel<CheckOciDriverTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckOciDriverTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCheckOciDriverTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CheckOciDriverTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CheckOciDriverTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
