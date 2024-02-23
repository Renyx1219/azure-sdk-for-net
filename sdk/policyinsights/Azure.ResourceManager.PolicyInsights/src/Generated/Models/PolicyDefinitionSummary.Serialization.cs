// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyDefinitionSummary : IUtf8JsonSerializable, IJsonModel<PolicyDefinitionSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyDefinitionSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyDefinitionSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyDefinitionSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyDefinitionSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PolicyDefinitionId != null)
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (PolicyDefinitionReferenceId != null)
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (!(PolicyDefinitionGroupNames is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("policyDefinitionGroupNames"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitionGroupNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Effect != null)
            {
                writer.WritePropertyName("effect"u8);
                writer.WriteStringValue(Effect);
            }
            if (Results != null)
            {
                writer.WritePropertyName("results"u8);
                writer.WriteObjectValue(Results);
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

        PolicyDefinitionSummary IJsonModel<PolicyDefinitionSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyDefinitionSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyDefinitionSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyDefinitionSummary(document.RootElement, options);
        }

        internal static PolicyDefinitionSummary DeserializePolicyDefinitionSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> policyDefinitionId = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<IReadOnlyList<string>> policyDefinitionGroupNames = default;
            Optional<string> effect = default;
            Optional<PolicySummaryResults> results = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionGroupNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    policyDefinitionGroupNames = array;
                    continue;
                }
                if (property.NameEquals("effect"u8))
                {
                    effect = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = PolicySummaryResults.DeserializePolicySummaryResults(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyDefinitionSummary(policyDefinitionId.Value, policyDefinitionReferenceId.Value, Optional.ToList(policyDefinitionGroupNames), effect.Value, results.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyDefinitionSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyDefinitionSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyDefinitionSummary)} does not support '{options.Format}' format.");
            }
        }

        PolicyDefinitionSummary IPersistableModel<PolicyDefinitionSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyDefinitionSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyDefinitionSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyDefinitionSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyDefinitionSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
