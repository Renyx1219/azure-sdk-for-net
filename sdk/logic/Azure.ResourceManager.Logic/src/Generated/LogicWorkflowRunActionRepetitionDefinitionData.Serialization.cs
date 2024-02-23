// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    public partial class LogicWorkflowRunActionRepetitionDefinitionData : IUtf8JsonSerializable, IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunActionRepetitionDefinitionData)} does not support '{format}' format.");
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
            if (StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (EndOn.HasValue)
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Correlation != null)
            {
                writer.WritePropertyName("correlation"u8);
                writer.WriteObjectValue(Correlation);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Code != null)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Error != null)
            {
                writer.WritePropertyName("error"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Error);
#else
                using (JsonDocument document = JsonDocument.Parse(Error))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && TrackingId.HasValue)
            {
                writer.WritePropertyName("trackingId"u8);
                writer.WriteStringValue(TrackingId.Value);
            }
            if (options.Format != "W" && Inputs != null)
            {
                writer.WritePropertyName("inputs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Inputs);
#else
                using (JsonDocument document = JsonDocument.Parse(Inputs))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && InputsLink != null)
            {
                writer.WritePropertyName("inputsLink"u8);
                writer.WriteObjectValue(InputsLink);
            }
            if (options.Format != "W" && Outputs != null)
            {
                writer.WritePropertyName("outputs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Outputs);
#else
                using (JsonDocument document = JsonDocument.Parse(Outputs))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && OutputsLink != null)
            {
                writer.WritePropertyName("outputsLink"u8);
                writer.WriteObjectValue(OutputsLink);
            }
            if (options.Format != "W" && TrackedProperties != null)
            {
                writer.WritePropertyName("trackedProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TrackedProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(TrackedProperties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (!(RetryHistory is ChangeTrackingList<LogicWorkRetryHistory> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("retryHistory"u8);
                writer.WriteStartArray();
                foreach (var item in RetryHistory)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IterationCount.HasValue)
            {
                writer.WritePropertyName("iterationCount"u8);
                writer.WriteNumberValue(IterationCount.Value);
            }
            if (!(RepetitionIndexes is ChangeTrackingList<LogicWorkflowRepetitionIndex> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("repetitionIndexes"u8);
                writer.WriteStartArray();
                foreach (var item in RepetitionIndexes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        LogicWorkflowRunActionRepetitionDefinitionData IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunActionRepetitionDefinitionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRunActionRepetitionDefinitionData(document.RootElement, options);
        }

        internal static LogicWorkflowRunActionRepetitionDefinitionData DeserializeLogicWorkflowRunActionRepetitionDefinitionData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<LogicWorkflowRunActionCorrelation> correlation = default;
            Optional<LogicWorkflowStatus> status = default;
            Optional<string> code = default;
            Optional<BinaryData> error = default;
            Optional<Guid> trackingId = default;
            Optional<BinaryData> inputs = default;
            Optional<LogicContentLink> inputsLink = default;
            Optional<BinaryData> outputs = default;
            Optional<LogicContentLink> outputsLink = default;
            Optional<BinaryData> trackedProperties = default;
            Optional<IList<LogicWorkRetryHistory>> retryHistory = default;
            Optional<int> iterationCount = default;
            Optional<IList<LogicWorkflowRepetitionIndex>> repetitionIndexes = default;
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
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("correlation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            correlation = LogicWorkflowRunActionCorrelation.DeserializeLogicWorkflowRunActionCorrelation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new LogicWorkflowStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("code"u8))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("trackingId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trackingId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("inputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inputs = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("inputsLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inputsLink = LogicContentLink.DeserializeLogicContentLink(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputs = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("outputsLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputsLink = LogicContentLink.DeserializeLogicContentLink(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("trackedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trackedProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("retryHistory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LogicWorkRetryHistory> array = new List<LogicWorkRetryHistory>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LogicWorkRetryHistory.DeserializeLogicWorkRetryHistory(item, options));
                            }
                            retryHistory = array;
                            continue;
                        }
                        if (property0.NameEquals("iterationCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iterationCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("repetitionIndexes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LogicWorkflowRepetitionIndex> array = new List<LogicWorkflowRepetitionIndex>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LogicWorkflowRepetitionIndex.DeserializeLogicWorkflowRepetitionIndex(item, options));
                            }
                            repetitionIndexes = array;
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
            return new LogicWorkflowRunActionRepetitionDefinitionData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(startTime), Optional.ToNullable(endTime), correlation.Value, Optional.ToNullable(status), code.Value, error.Value, Optional.ToNullable(trackingId), inputs.Value, inputsLink.Value, outputs.Value, outputsLink.Value, trackedProperties.Value, Optional.ToList(retryHistory), Optional.ToNullable(iterationCount), Optional.ToList(repetitionIndexes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowRunActionRepetitionDefinitionData)} does not support '{options.Format}' format.");
            }
        }

        LogicWorkflowRunActionRepetitionDefinitionData IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicWorkflowRunActionRepetitionDefinitionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowRunActionRepetitionDefinitionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
