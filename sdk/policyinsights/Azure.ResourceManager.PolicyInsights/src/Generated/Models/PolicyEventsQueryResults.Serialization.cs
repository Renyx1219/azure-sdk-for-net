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
    internal partial class PolicyEventsQueryResults : IUtf8JsonSerializable, IJsonModel<PolicyEventsQueryResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyEventsQueryResults>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyEventsQueryResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEventsQueryResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEventsQueryResults)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ODataContext != null)
            {
                writer.WritePropertyName("@odata.context"u8);
                writer.WriteStringValue(ODataContext);
            }
            if (ODataCount.HasValue)
            {
                writer.WritePropertyName("@odata.count"u8);
                writer.WriteNumberValue(ODataCount.Value);
            }
            if (ODataNextLink != null)
            {
                writer.WritePropertyName("@odata.nextLink"u8);
                writer.WriteStringValue(ODataNextLink);
            }
            if (!(Value is ChangeTrackingList<PolicyEvent> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        PolicyEventsQueryResults IJsonModel<PolicyEventsQueryResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEventsQueryResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEventsQueryResults)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyEventsQueryResults(document.RootElement, options);
        }

        internal static PolicyEventsQueryResults DeserializePolicyEventsQueryResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataContext = default;
            Optional<int> odataCount = default;
            Optional<string> odataNextLink = default;
            Optional<IReadOnlyList<PolicyEvent>> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolicyEvent> array = new List<PolicyEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyEvent.DeserializePolicyEvent(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyEventsQueryResults(odataContext.Value, Optional.ToNullable(odataCount), odataNextLink.Value, Optional.ToList(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyEventsQueryResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEventsQueryResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyEventsQueryResults)} does not support '{options.Format}' format.");
            }
        }

        PolicyEventsQueryResults IPersistableModel<PolicyEventsQueryResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEventsQueryResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyEventsQueryResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyEventsQueryResults)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyEventsQueryResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
