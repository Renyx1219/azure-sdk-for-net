// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class MetricAlertData : IUtf8JsonSerializable, IJsonModel<MetricAlertData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricAlertData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MetricAlertData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricAlertData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("severity"u8);
            writer.WriteNumberValue(Severity);
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("scopes"u8);
            writer.WriteStartArray();
            foreach (var item in Scopes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("evaluationFrequency"u8);
            writer.WriteStringValue(EvaluationFrequency, "P");
            writer.WritePropertyName("windowSize"u8);
            writer.WriteStringValue(WindowSize, "P");
            if (TargetResourceType.HasValue)
            {
                writer.WritePropertyName("targetResourceType"u8);
                writer.WriteStringValue(TargetResourceType.Value);
            }
            if (TargetResourceRegion.HasValue)
            {
                writer.WritePropertyName("targetResourceRegion"u8);
                writer.WriteStringValue(TargetResourceRegion.Value);
            }
            if (Criteria != null)
            {
                writer.WritePropertyName("criteria"u8);
                writer.WriteObjectValue(Criteria);
            }
            else
            {
                writer.WriteNull("criteria");
            }
            if (IsAutoMitigateEnabled.HasValue)
            {
                writer.WritePropertyName("autoMitigate"u8);
                writer.WriteBooleanValue(IsAutoMitigateEnabled.Value);
            }
            if (!(Actions is ChangeTrackingList<MetricAlertAction> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && IsMigrated.HasValue)
            {
                writer.WritePropertyName("isMigrated"u8);
                writer.WriteBooleanValue(IsMigrated.Value);
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

        MetricAlertData IJsonModel<MetricAlertData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricAlertData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricAlertData(document.RootElement, options);
        }

        internal static MetricAlertData DeserializeMetricAlertData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            int severity = default;
            bool enabled = default;
            IList<string> scopes = default;
            TimeSpan evaluationFrequency = default;
            TimeSpan windowSize = default;
            Optional<ResourceType> targetResourceType = default;
            Optional<AzureLocation> targetResourceRegion = default;
            MetricAlertCriteria criteria = default;
            Optional<bool> autoMitigate = default;
            Optional<IList<MetricAlertAction>> actions = default;
            Optional<DateTimeOffset> lastUpdatedTime = default;
            Optional<bool> isMigrated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            severity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("scopes"u8))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            scopes = array;
                            continue;
                        }
                        if (property0.NameEquals("evaluationFrequency"u8))
                        {
                            evaluationFrequency = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("windowSize"u8))
                        {
                            windowSize = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("targetResourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceType = new ResourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetResourceRegion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceRegion = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("criteria"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                criteria = null;
                                continue;
                            }
                            criteria = MetricAlertCriteria.DeserializeMetricAlertCriteria(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("autoMitigate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoMitigate = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("actions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MetricAlertAction> array = new List<MetricAlertAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MetricAlertAction.DeserializeMetricAlertAction(item, options));
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("isMigrated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isMigrated = property0.Value.GetBoolean();
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
            return new MetricAlertData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, description.Value, severity, enabled, scopes, evaluationFrequency, windowSize, Optional.ToNullable(targetResourceType), Optional.ToNullable(targetResourceRegion), criteria, Optional.ToNullable(autoMitigate), Optional.ToList(actions), Optional.ToNullable(lastUpdatedTime), Optional.ToNullable(isMigrated), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricAlertData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MetricAlertData)} does not support '{options.Format}' format.");
            }
        }

        MetricAlertData IPersistableModel<MetricAlertData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMetricAlertData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MetricAlertData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricAlertData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
