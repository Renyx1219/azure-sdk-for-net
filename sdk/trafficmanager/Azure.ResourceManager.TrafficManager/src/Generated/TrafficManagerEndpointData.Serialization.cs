// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    public partial class TrafficManagerEndpointData : IUtf8JsonSerializable, IJsonModel<TrafficManagerEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficManagerEndpointData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrafficManagerEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerEndpointData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (TargetResourceId != null)
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Target != null)
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (EndpointStatus.HasValue)
            {
                writer.WritePropertyName("endpointStatus"u8);
                writer.WriteStringValue(EndpointStatus.Value.ToString());
            }
            if (Weight.HasValue)
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (Priority.HasValue)
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (EndpointLocation != null)
            {
                writer.WritePropertyName("endpointLocation"u8);
                writer.WriteStringValue(EndpointLocation);
            }
            if (EndpointMonitorStatus.HasValue)
            {
                writer.WritePropertyName("endpointMonitorStatus"u8);
                writer.WriteStringValue(EndpointMonitorStatus.Value.ToString());
            }
            if (MinChildEndpoints.HasValue)
            {
                if (MinChildEndpoints != null)
                {
                    writer.WritePropertyName("minChildEndpoints"u8);
                    writer.WriteNumberValue(MinChildEndpoints.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpoints");
                }
            }
            if (MinChildEndpointsIPv4.HasValue)
            {
                if (MinChildEndpointsIPv4 != null)
                {
                    writer.WritePropertyName("minChildEndpointsIPv4"u8);
                    writer.WriteNumberValue(MinChildEndpointsIPv4.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpointsIPv4");
                }
            }
            if (MinChildEndpointsIPv6.HasValue)
            {
                if (MinChildEndpointsIPv6 != null)
                {
                    writer.WritePropertyName("minChildEndpointsIPv6"u8);
                    writer.WriteNumberValue(MinChildEndpointsIPv6.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpointsIPv6");
                }
            }
            if (!(GeoMapping is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("geoMapping"u8);
                writer.WriteStartArray();
                foreach (var item in GeoMapping)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Subnets is ChangeTrackingList<TrafficManagerEndpointSubnetInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("subnets"u8);
                writer.WriteStartArray();
                foreach (var item in Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(CustomHeaders is ChangeTrackingList<TrafficManagerEndpointCustomHeaderInfo> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("customHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in CustomHeaders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AlwaysServe.HasValue)
            {
                writer.WritePropertyName("alwaysServe"u8);
                writer.WriteStringValue(AlwaysServe.Value.ToString());
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

        TrafficManagerEndpointData IJsonModel<TrafficManagerEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerEndpointData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerEndpointData(document.RootElement, options);
        }

        internal static TrafficManagerEndpointData DeserializeTrafficManagerEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<ResourceIdentifier> targetResourceId = default;
            Optional<string> target = default;
            Optional<TrafficManagerEndpointStatus> endpointStatus = default;
            Optional<long> weight = default;
            Optional<long> priority = default;
            Optional<string> endpointLocation = default;
            Optional<TrafficManagerEndpointMonitorStatus> endpointMonitorStatus = default;
            Optional<long?> minChildEndpoints = default;
            Optional<long?> minChildEndpointsIPv4 = default;
            Optional<long?> minChildEndpointsIPv6 = default;
            Optional<IList<string>> geoMapping = default;
            Optional<IList<TrafficManagerEndpointSubnetInfo>> subnets = default;
            Optional<IList<TrafficManagerEndpointCustomHeaderInfo>> customHeaders = default;
            Optional<TrafficManagerEndpointAlwaysServeStatus> alwaysServe = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointStatus = new TrafficManagerEndpointStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weight = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("endpointLocation"u8))
                        {
                            endpointLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointMonitorStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointMonitorStatus = new TrafficManagerEndpointMonitorStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpoints = null;
                                continue;
                            }
                            minChildEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpointsIPv4"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpointsIPv4 = null;
                                continue;
                            }
                            minChildEndpointsIPv4 = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpointsIPv6"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpointsIPv6 = null;
                                continue;
                            }
                            minChildEndpointsIPv6 = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("geoMapping"u8))
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
                            geoMapping = array;
                            continue;
                        }
                        if (property0.NameEquals("subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficManagerEndpointSubnetInfo> array = new List<TrafficManagerEndpointSubnetInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficManagerEndpointSubnetInfo.DeserializeTrafficManagerEndpointSubnetInfo(item, options));
                            }
                            subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("customHeaders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficManagerEndpointCustomHeaderInfo> array = new List<TrafficManagerEndpointCustomHeaderInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficManagerEndpointCustomHeaderInfo.DeserializeTrafficManagerEndpointCustomHeaderInfo(item, options));
                            }
                            customHeaders = array;
                            continue;
                        }
                        if (property0.NameEquals("alwaysServe"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alwaysServe = new TrafficManagerEndpointAlwaysServeStatus(property0.Value.GetString());
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
            return new TrafficManagerEndpointData(id.Value, name.Value, Optional.ToNullable(type), serializedAdditionalRawData, targetResourceId.Value, target.Value, Optional.ToNullable(endpointStatus), Optional.ToNullable(weight), Optional.ToNullable(priority), endpointLocation.Value, Optional.ToNullable(endpointMonitorStatus), Optional.ToNullable(minChildEndpoints), Optional.ToNullable(minChildEndpointsIPv4), Optional.ToNullable(minChildEndpointsIPv6), Optional.ToList(geoMapping), Optional.ToList(subnets), Optional.ToList(customHeaders), Optional.ToNullable(alwaysServe));
        }

        BinaryData IPersistableModel<TrafficManagerEndpointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerEndpointData)} does not support '{options.Format}' format.");
            }
        }

        TrafficManagerEndpointData IPersistableModel<TrafficManagerEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrafficManagerEndpointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerEndpointData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficManagerEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
