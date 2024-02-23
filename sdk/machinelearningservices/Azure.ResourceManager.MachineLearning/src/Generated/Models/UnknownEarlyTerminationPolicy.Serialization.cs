// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownEarlyTerminationPolicy : IUtf8JsonSerializable, IJsonModel<MachineLearningEarlyTerminationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEarlyTerminationPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningEarlyTerminationPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEarlyTerminationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEarlyTerminationPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DelayEvaluation.HasValue)
            {
                writer.WritePropertyName("delayEvaluation"u8);
                writer.WriteNumberValue(DelayEvaluation.Value);
            }
            if (EvaluationInterval.HasValue)
            {
                writer.WritePropertyName("evaluationInterval"u8);
                writer.WriteNumberValue(EvaluationInterval.Value);
            }
            writer.WritePropertyName("policyType"u8);
            writer.WriteStringValue(PolicyType.ToString());
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

        MachineLearningEarlyTerminationPolicy IJsonModel<MachineLearningEarlyTerminationPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEarlyTerminationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEarlyTerminationPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEarlyTerminationPolicy(document.RootElement, options);
        }

        internal static UnknownEarlyTerminationPolicy DeserializeUnknownEarlyTerminationPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> delayEvaluation = default;
            Optional<int> evaluationInterval = default;
            EarlyTerminationPolicyType policyType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delayEvaluation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delayEvaluation = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("evaluationInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyType"u8))
                {
                    policyType = new EarlyTerminationPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownEarlyTerminationPolicy(Optional.ToNullable(delayEvaluation), Optional.ToNullable(evaluationInterval), policyType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningEarlyTerminationPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEarlyTerminationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEarlyTerminationPolicy)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningEarlyTerminationPolicy IPersistableModel<MachineLearningEarlyTerminationPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEarlyTerminationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningEarlyTerminationPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEarlyTerminationPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningEarlyTerminationPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
