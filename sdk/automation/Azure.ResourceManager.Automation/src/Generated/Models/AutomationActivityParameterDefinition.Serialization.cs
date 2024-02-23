// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationActivityParameterDefinition : IUtf8JsonSerializable, IJsonModel<AutomationActivityParameterDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationActivityParameterDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationActivityParameterDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivityParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationActivityParameterDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (ActivityParameterType != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ActivityParameterType);
            }
            if (IsMandatory.HasValue)
            {
                writer.WritePropertyName("isMandatory"u8);
                writer.WriteBooleanValue(IsMandatory.Value);
            }
            if (IsDynamic.HasValue)
            {
                writer.WritePropertyName("isDynamic"u8);
                writer.WriteBooleanValue(IsDynamic.Value);
            }
            if (Position.HasValue)
            {
                writer.WritePropertyName("position"u8);
                writer.WriteNumberValue(Position.Value);
            }
            if (CanTakeValueFromPipeline.HasValue)
            {
                writer.WritePropertyName("valueFromPipeline"u8);
                writer.WriteBooleanValue(CanTakeValueFromPipeline.Value);
            }
            if (CanTakeValueFromPipelineByPropertyName.HasValue)
            {
                writer.WritePropertyName("valueFromPipelineByPropertyName"u8);
                writer.WriteBooleanValue(CanTakeValueFromPipelineByPropertyName.Value);
            }
            if (CanTakeValueValueFromRemainingArguments.HasValue)
            {
                writer.WritePropertyName("valueFromRemainingArguments"u8);
                writer.WriteBooleanValue(CanTakeValueValueFromRemainingArguments.Value);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(ValidationSet is ChangeTrackingList<AutomationActivityParameterValidationSet> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("validationSet"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationSet)
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

        AutomationActivityParameterDefinition IJsonModel<AutomationActivityParameterDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivityParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationActivityParameterDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationActivityParameterDefinition(document.RootElement, options);
        }

        internal static AutomationActivityParameterDefinition DeserializeAutomationActivityParameterDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<bool> isMandatory = default;
            Optional<bool> isDynamic = default;
            Optional<long> position = default;
            Optional<bool> valueFromPipeline = default;
            Optional<bool> valueFromPipelineByPropertyName = default;
            Optional<bool> valueFromRemainingArguments = default;
            Optional<string> description = default;
            Optional<IReadOnlyList<AutomationActivityParameterValidationSet>> validationSet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isMandatory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMandatory = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDynamic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDynamic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    position = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("valueFromPipeline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFromPipeline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueFromPipelineByPropertyName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFromPipelineByPropertyName = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueFromRemainingArguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFromRemainingArguments = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomationActivityParameterValidationSet> array = new List<AutomationActivityParameterValidationSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomationActivityParameterValidationSet.DeserializeAutomationActivityParameterValidationSet(item, options));
                    }
                    validationSet = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomationActivityParameterDefinition(name.Value, type.Value, Optional.ToNullable(isMandatory), Optional.ToNullable(isDynamic), Optional.ToNullable(position), Optional.ToNullable(valueFromPipeline), Optional.ToNullable(valueFromPipelineByPropertyName), Optional.ToNullable(valueFromRemainingArguments), description.Value, Optional.ToList(validationSet), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationActivityParameterDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivityParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationActivityParameterDefinition)} does not support '{options.Format}' format.");
            }
        }

        AutomationActivityParameterDefinition IPersistableModel<AutomationActivityParameterDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivityParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationActivityParameterDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationActivityParameterDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationActivityParameterDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
