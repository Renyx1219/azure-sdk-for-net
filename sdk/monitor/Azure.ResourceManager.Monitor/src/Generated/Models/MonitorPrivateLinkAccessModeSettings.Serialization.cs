// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorPrivateLinkAccessModeSettings : IUtf8JsonSerializable, IJsonModel<MonitorPrivateLinkAccessModeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorPrivateLinkAccessModeSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorPrivateLinkAccessModeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorPrivateLinkAccessModeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorPrivateLinkAccessModeSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("queryAccessMode"u8);
            writer.WriteStringValue(QueryAccessMode.ToString());
            writer.WritePropertyName("ingestionAccessMode"u8);
            writer.WriteStringValue(IngestionAccessMode.ToString());
            if (!(Exclusions is ChangeTrackingList<MonitorPrivateLinkAccessModeSettingsExclusion> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("exclusions"u8);
                writer.WriteStartArray();
                foreach (var item in Exclusions)
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

        MonitorPrivateLinkAccessModeSettings IJsonModel<MonitorPrivateLinkAccessModeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorPrivateLinkAccessModeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorPrivateLinkAccessModeSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorPrivateLinkAccessModeSettings(document.RootElement, options);
        }

        internal static MonitorPrivateLinkAccessModeSettings DeserializeMonitorPrivateLinkAccessModeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorPrivateLinkAccessMode queryAccessMode = default;
            MonitorPrivateLinkAccessMode ingestionAccessMode = default;
            Optional<IList<MonitorPrivateLinkAccessModeSettingsExclusion>> exclusions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryAccessMode"u8))
                {
                    queryAccessMode = new MonitorPrivateLinkAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingestionAccessMode"u8))
                {
                    ingestionAccessMode = new MonitorPrivateLinkAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exclusions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorPrivateLinkAccessModeSettingsExclusion> array = new List<MonitorPrivateLinkAccessModeSettingsExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorPrivateLinkAccessModeSettingsExclusion.DeserializeMonitorPrivateLinkAccessModeSettingsExclusion(item, options));
                    }
                    exclusions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorPrivateLinkAccessModeSettings(queryAccessMode, ingestionAccessMode, Optional.ToList(exclusions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorPrivateLinkAccessModeSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorPrivateLinkAccessModeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorPrivateLinkAccessModeSettings)} does not support '{options.Format}' format.");
            }
        }

        MonitorPrivateLinkAccessModeSettings IPersistableModel<MonitorPrivateLinkAccessModeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorPrivateLinkAccessModeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorPrivateLinkAccessModeSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorPrivateLinkAccessModeSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorPrivateLinkAccessModeSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
