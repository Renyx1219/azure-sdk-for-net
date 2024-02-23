// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class PredictionResourceFormatData : IUtf8JsonSerializable, IJsonModel<PredictionResourceFormatData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PredictionResourceFormatData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PredictionResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionResourceFormatData)} does not support '{format}' format.");
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
            if (!(Description is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(DisplayName is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(InvolvedInteractionTypes is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("involvedInteractionTypes"u8);
                writer.WriteStartArray();
                foreach (var item in InvolvedInteractionTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(InvolvedKpiTypes is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("involvedKpiTypes"u8);
                writer.WriteStartArray();
                foreach (var item in InvolvedKpiTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(InvolvedRelationships is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("involvedRelationships"u8);
                writer.WriteStartArray();
                foreach (var item in InvolvedRelationships)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (NegativeOutcomeExpression != null)
            {
                writer.WritePropertyName("negativeOutcomeExpression"u8);
                writer.WriteStringValue(NegativeOutcomeExpression);
            }
            if (PositiveOutcomeExpression != null)
            {
                writer.WritePropertyName("positiveOutcomeExpression"u8);
                writer.WriteStringValue(PositiveOutcomeExpression);
            }
            if (PrimaryProfileType != null)
            {
                writer.WritePropertyName("primaryProfileType"u8);
                writer.WriteStringValue(PrimaryProfileType);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (PredictionName != null)
            {
                writer.WritePropertyName("predictionName"u8);
                writer.WriteStringValue(PredictionName);
            }
            if (ScopeExpression != null)
            {
                writer.WritePropertyName("scopeExpression"u8);
                writer.WriteStringValue(ScopeExpression);
            }
            if (options.Format != "W" && TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (AutoAnalyze.HasValue)
            {
                writer.WritePropertyName("autoAnalyze"u8);
                writer.WriteBooleanValue(AutoAnalyze.Value);
            }
            if (Mappings != null)
            {
                writer.WritePropertyName("mappings"u8);
                writer.WriteObjectValue(Mappings);
            }
            if (ScoreLabel != null)
            {
                writer.WritePropertyName("scoreLabel"u8);
                writer.WriteStringValue(ScoreLabel);
            }
            if (!(Grades is ChangeTrackingList<PredictionGradesItem> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("grades"u8);
                writer.WriteStartArray();
                foreach (var item in Grades)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && SystemGeneratedEntities != null)
            {
                writer.WritePropertyName("systemGeneratedEntities"u8);
                writer.WriteObjectValue(SystemGeneratedEntities);
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

        PredictionResourceFormatData IJsonModel<PredictionResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionResourceFormatData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionResourceFormatData(document.RootElement, options);
        }

        internal static PredictionResourceFormatData DeserializePredictionResourceFormatData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<IDictionary<string, string>> description = default;
            Optional<IDictionary<string, string>> displayName = default;
            Optional<IList<string>> involvedInteractionTypes = default;
            Optional<IList<string>> involvedKpiTypes = default;
            Optional<IList<string>> involvedRelationships = default;
            Optional<string> negativeOutcomeExpression = default;
            Optional<string> positiveOutcomeExpression = default;
            Optional<string> primaryProfileType = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> predictionName = default;
            Optional<string> scopeExpression = default;
            Optional<Guid> tenantId = default;
            Optional<bool> autoAnalyze = default;
            Optional<PredictionMappings> mappings = default;
            Optional<string> scoreLabel = default;
            Optional<IList<PredictionGradesItem>> grades = default;
            Optional<PredictionSystemGeneratedEntities> systemGeneratedEntities = default;
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
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("involvedInteractionTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            involvedInteractionTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("involvedKpiTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            involvedKpiTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("involvedRelationships"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            involvedRelationships = array;
                            continue;
                        }
                        if (property0.NameEquals("negativeOutcomeExpression"u8))
                        {
                            negativeOutcomeExpression = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("positiveOutcomeExpression"u8))
                        {
                            positiveOutcomeExpression = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primaryProfileType"u8))
                        {
                            primaryProfileType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("predictionName"u8))
                        {
                            predictionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scopeExpression"u8))
                        {
                            scopeExpression = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("autoAnalyze"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoAnalyze = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("mappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mappings = PredictionMappings.DeserializePredictionMappings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("scoreLabel"u8))
                        {
                            scoreLabel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("grades"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PredictionGradesItem> array = new List<PredictionGradesItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PredictionGradesItem.DeserializePredictionGradesItem(item, options));
                            }
                            grades = array;
                            continue;
                        }
                        if (property0.NameEquals("systemGeneratedEntities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemGeneratedEntities = PredictionSystemGeneratedEntities.DeserializePredictionSystemGeneratedEntities(property0.Value, options);
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
            return new PredictionResourceFormatData(id, name, type, systemData.Value, Optional.ToDictionary(description), Optional.ToDictionary(displayName), Optional.ToList(involvedInteractionTypes), Optional.ToList(involvedKpiTypes), Optional.ToList(involvedRelationships), negativeOutcomeExpression.Value, positiveOutcomeExpression.Value, primaryProfileType.Value, Optional.ToNullable(provisioningState), predictionName.Value, scopeExpression.Value, Optional.ToNullable(tenantId), Optional.ToNullable(autoAnalyze), mappings.Value, scoreLabel.Value, Optional.ToList(grades), systemGeneratedEntities.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PredictionResourceFormatData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PredictionResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        PredictionResourceFormatData IPersistableModel<PredictionResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePredictionResourceFormatData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PredictionResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PredictionResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
