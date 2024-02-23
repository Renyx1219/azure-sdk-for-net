// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    public partial class ContainerServiceMaintenanceConfigurationData : IUtf8JsonSerializable, IJsonModel<ContainerServiceMaintenanceConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceMaintenanceConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceMaintenanceConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceConfigurationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(TimesInWeek is ChangeTrackingList<ContainerServiceTimeInWeek> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("timeInWeek"u8);
                writer.WriteStartArray();
                foreach (var item in TimesInWeek)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(NotAllowedTimes is ChangeTrackingList<ContainerServiceTimeSpan> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("notAllowedTime"u8);
                writer.WriteStartArray();
                foreach (var item in NotAllowedTimes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (MaintenanceWindow != null)
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow);
            }
            writer.WriteEndObject();
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

        ContainerServiceMaintenanceConfigurationData IJsonModel<ContainerServiceMaintenanceConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceConfigurationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceConfigurationData(document.RootElement, options);
        }

        internal static ContainerServiceMaintenanceConfigurationData DeserializeContainerServiceMaintenanceConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<ContainerServiceTimeInWeek>> timeInWeek = default;
            Optional<IList<ContainerServiceTimeSpan>> notAllowedTime = default;
            Optional<ContainerServiceMaintenanceWindow> maintenanceWindow = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("timeInWeek"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerServiceTimeInWeek> array = new List<ContainerServiceTimeInWeek>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerServiceTimeInWeek.DeserializeContainerServiceTimeInWeek(item, options));
                            }
                            timeInWeek = array;
                            continue;
                        }
                        if (property0.NameEquals("notAllowedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerServiceTimeSpan> array = new List<ContainerServiceTimeSpan>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerServiceTimeSpan.DeserializeContainerServiceTimeSpan(item, options));
                            }
                            notAllowedTime = array;
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = ContainerServiceMaintenanceWindow.DeserializeContainerServiceMaintenanceWindow(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceMaintenanceConfigurationData(id, name, type, systemData.Value, Optional.ToList(timeInWeek), Optional.ToList(notAllowedTime), maintenanceWindow.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceMaintenanceConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceMaintenanceConfigurationData IPersistableModel<ContainerServiceMaintenanceConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceMaintenanceConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceMaintenanceConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
