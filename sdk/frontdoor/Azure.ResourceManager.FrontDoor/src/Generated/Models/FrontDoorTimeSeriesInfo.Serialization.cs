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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorTimeSeriesInfo : IUtf8JsonSerializable, IJsonModel<FrontDoorTimeSeriesInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorTimeSeriesInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorTimeSeriesInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorTimeSeriesInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorTimeSeriesInfo)} does not support '{format}' format.");
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
            if (Endpoint != null)
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint.AbsoluteUri);
            }
            if (StartOn.HasValue)
            {
                writer.WritePropertyName("startDateTimeUTC"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (EndOn.HasValue)
            {
                writer.WritePropertyName("endDateTimeUTC"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (AggregationInterval.HasValue)
            {
                writer.WritePropertyName("aggregationInterval"u8);
                writer.WriteStringValue(AggregationInterval.Value.ToString());
            }
            if (TimeSeriesType.HasValue)
            {
                writer.WritePropertyName("timeseriesType"u8);
                writer.WriteStringValue(TimeSeriesType.Value.ToString());
            }
            if (Country != null)
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
            }
            if (!(TimeSeriesData is ChangeTrackingList<FrontDoorTimeSeriesDataPoint> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("timeseriesData"u8);
                writer.WriteStartArray();
                foreach (var item in TimeSeriesData)
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

        FrontDoorTimeSeriesInfo IJsonModel<FrontDoorTimeSeriesInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorTimeSeriesInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorTimeSeriesInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorTimeSeriesInfo(document.RootElement, options);
        }

        internal static FrontDoorTimeSeriesInfo DeserializeFrontDoorTimeSeriesInfo(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<Uri> endpoint = default;
            Optional<DateTimeOffset> startDateTimeUtc = default;
            Optional<DateTimeOffset> endDateTimeUtc = default;
            Optional<FrontDoorTimeSeriesInfoAggregationInterval> aggregationInterval = default;
            Optional<FrontDoorTimeSeriesType> timeSeriesType = default;
            Optional<string> country = default;
            Optional<IList<FrontDoorTimeSeriesDataPoint>> timeSeriesData = default;
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
                        if (property0.NameEquals("endpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDateTimeUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDateTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTimeUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endDateTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("aggregationInterval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aggregationInterval = new FrontDoorTimeSeriesInfoAggregationInterval(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeseriesType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeSeriesType = new FrontDoorTimeSeriesType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("country"u8))
                        {
                            country = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeseriesData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorTimeSeriesDataPoint> array = new List<FrontDoorTimeSeriesDataPoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorTimeSeriesDataPoint.DeserializeFrontDoorTimeSeriesDataPoint(item, options));
                            }
                            timeSeriesData = array;
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
            return new FrontDoorTimeSeriesInfo(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, endpoint.Value, Optional.ToNullable(startDateTimeUtc), Optional.ToNullable(endDateTimeUtc), Optional.ToNullable(aggregationInterval), Optional.ToNullable(timeSeriesType), country.Value, Optional.ToList(timeSeriesData), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorTimeSeriesInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorTimeSeriesInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorTimeSeriesInfo)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorTimeSeriesInfo IPersistableModel<FrontDoorTimeSeriesInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorTimeSeriesInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorTimeSeriesInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorTimeSeriesInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorTimeSeriesInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
