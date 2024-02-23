// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class TrialMatcherPatientResult : IUtf8JsonSerializable, IJsonModel<TrialMatcherPatientResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrialMatcherPatientResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrialMatcherPatientResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherPatientResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrialMatcherPatientResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("inferences"u8);
            writer.WriteStartArray();
            foreach (var item in Inferences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(NeededClinicalInfo is ChangeTrackingList<ExtendedClinicalCodedElement> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("neededClinicalInfo"u8);
                writer.WriteStartArray();
                foreach (var item in NeededClinicalInfo)
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

        TrialMatcherPatientResult IJsonModel<TrialMatcherPatientResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherPatientResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrialMatcherPatientResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrialMatcherPatientResult(document.RootElement, options);
        }

        internal static TrialMatcherPatientResult DeserializeTrialMatcherPatientResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            IReadOnlyList<TrialMatcherInference> inferences = default;
            Optional<IReadOnlyList<ExtendedClinicalCodedElement>> neededClinicalInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inferences"u8))
                {
                    List<TrialMatcherInference> array = new List<TrialMatcherInference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrialMatcherInference.DeserializeTrialMatcherInference(item, options));
                    }
                    inferences = array;
                    continue;
                }
                if (property.NameEquals("neededClinicalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExtendedClinicalCodedElement> array = new List<ExtendedClinicalCodedElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtendedClinicalCodedElement.DeserializeExtendedClinicalCodedElement(item, options));
                    }
                    neededClinicalInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrialMatcherPatientResult(id, inferences, Optional.ToList(neededClinicalInfo), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrialMatcherPatientResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherPatientResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrialMatcherPatientResult)} does not support '{options.Format}' format.");
            }
        }

        TrialMatcherPatientResult IPersistableModel<TrialMatcherPatientResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherPatientResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrialMatcherPatientResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrialMatcherPatientResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrialMatcherPatientResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrialMatcherPatientResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTrialMatcherPatientResult(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
