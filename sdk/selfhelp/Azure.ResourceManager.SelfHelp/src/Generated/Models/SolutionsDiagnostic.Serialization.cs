// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SolutionsDiagnostic : IUtf8JsonSerializable, IJsonModel<SolutionsDiagnostic>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SolutionsDiagnostic>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SolutionsDiagnostic>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SolutionsDiagnostic>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SolutionsDiagnostic)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SolutionId != null)
            {
                writer.WritePropertyName("solutionId"u8);
                writer.WriteStringValue(SolutionId);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (StatusDetails != null)
            {
                writer.WritePropertyName("statusDetails"u8);
                writer.WriteStringValue(StatusDetails);
            }
            if (ReplacementKey != null)
            {
                writer.WritePropertyName("replacementKey"u8);
                writer.WriteStringValue(ReplacementKey);
            }
            if (!(RequiredParameters is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("requiredParameters"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredParameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Insights is ChangeTrackingList<SelfHelpDiagnosticInsight> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("insights"u8);
                writer.WriteStartArray();
                foreach (var item in Insights)
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

        SolutionsDiagnostic IJsonModel<SolutionsDiagnostic>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SolutionsDiagnostic>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SolutionsDiagnostic)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSolutionsDiagnostic(document.RootElement, options);
        }

        internal static SolutionsDiagnostic DeserializeSolutionsDiagnostic(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> solutionId = default;
            Optional<SelfHelpDiagnosticStatus> status = default;
            Optional<string> statusDetails = default;
            Optional<string> replacementKey = default;
            Optional<IList<string>> requiredParameters = default;
            Optional<IList<SelfHelpDiagnosticInsight>> insights = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("solutionId"u8))
                {
                    solutionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SelfHelpDiagnosticStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDetails"u8))
                {
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replacementKey"u8))
                {
                    replacementKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredParameters"u8))
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
                    requiredParameters = array;
                    continue;
                }
                if (property.NameEquals("insights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SelfHelpDiagnosticInsight> array = new List<SelfHelpDiagnosticInsight>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SelfHelpDiagnosticInsight.DeserializeSelfHelpDiagnosticInsight(item, options));
                    }
                    insights = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SolutionsDiagnostic(solutionId.Value, Optional.ToNullable(status), statusDetails.Value, replacementKey.Value, Optional.ToList(requiredParameters), Optional.ToList(insights), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SolutionsDiagnostic>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SolutionsDiagnostic>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SolutionsDiagnostic)} does not support '{options.Format}' format.");
            }
        }

        SolutionsDiagnostic IPersistableModel<SolutionsDiagnostic>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SolutionsDiagnostic>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSolutionsDiagnostic(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SolutionsDiagnostic)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SolutionsDiagnostic>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
