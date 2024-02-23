// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DetectorAbnormalTimePeriod : IUtf8JsonSerializable, IJsonModel<DetectorAbnormalTimePeriod>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DetectorAbnormalTimePeriod>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DetectorAbnormalTimePeriod>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorAbnormalTimePeriod>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DetectorAbnormalTimePeriod)} does not support '{format}' format.");
            }

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
            if (Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Priority.HasValue)
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (!(MetaData is ChangeTrackingList<IList<AppServiceNameValuePair>> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("metaData"u8);
                writer.WriteStartArray();
                foreach (var item in MetaData)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (IssueType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IssueType.Value.ToSerialString());
            }
            if (!(Solutions is ChangeTrackingList<DiagnosticSolution> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("solutions"u8);
                writer.WriteStartArray();
                foreach (var item in Solutions)
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

        DetectorAbnormalTimePeriod IJsonModel<DetectorAbnormalTimePeriod>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorAbnormalTimePeriod>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DetectorAbnormalTimePeriod)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectorAbnormalTimePeriod(document.RootElement, options);
        }

        internal static DetectorAbnormalTimePeriod DeserializeDetectorAbnormalTimePeriod(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> message = default;
            Optional<string> source = default;
            Optional<double> priority = default;
            Optional<IList<IList<AppServiceNameValuePair>>> metaData = default;
            Optional<DetectorIssueType> type = default;
            Optional<IList<DiagnosticSolution>> solutions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("metaData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<AppServiceNameValuePair>> array = new List<IList<AppServiceNameValuePair>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<AppServiceNameValuePair> array0 = new List<AppServiceNameValuePair>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item0, options));
                            }
                            array.Add(array0);
                        }
                    }
                    metaData = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToDetectorIssueType();
                    continue;
                }
                if (property.NameEquals("solutions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiagnosticSolution> array = new List<DiagnosticSolution>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticSolution.DeserializeDiagnosticSolution(item, options));
                    }
                    solutions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DetectorAbnormalTimePeriod(Optional.ToNullable(startTime), Optional.ToNullable(endTime), message.Value, source.Value, Optional.ToNullable(priority), Optional.ToList(metaData), Optional.ToNullable(type), Optional.ToList(solutions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DetectorAbnormalTimePeriod>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorAbnormalTimePeriod>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DetectorAbnormalTimePeriod)} does not support '{options.Format}' format.");
            }
        }

        DetectorAbnormalTimePeriod IPersistableModel<DetectorAbnormalTimePeriod>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorAbnormalTimePeriod>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDetectorAbnormalTimePeriod(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DetectorAbnormalTimePeriod)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DetectorAbnormalTimePeriod>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
