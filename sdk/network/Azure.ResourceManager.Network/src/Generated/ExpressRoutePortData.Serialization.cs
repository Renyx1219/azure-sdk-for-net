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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRoutePortData : IUtf8JsonSerializable, IJsonModel<ExpressRoutePortData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRoutePortData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExpressRoutePortData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRoutePortData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRoutePortData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (PeeringLocation != null)
            {
                writer.WritePropertyName("peeringLocation"u8);
                writer.WriteStringValue(PeeringLocation);
            }
            if (BandwidthInGbps.HasValue)
            {
                writer.WritePropertyName("bandwidthInGbps"u8);
                writer.WriteNumberValue(BandwidthInGbps.Value);
            }
            if (options.Format != "W" && ProvisionedBandwidthInGbps.HasValue)
            {
                writer.WritePropertyName("provisionedBandwidthInGbps"u8);
                writer.WriteNumberValue(ProvisionedBandwidthInGbps.Value);
            }
            if (options.Format != "W" && Mtu != null)
            {
                writer.WritePropertyName("mtu"u8);
                writer.WriteStringValue(Mtu);
            }
            if (Encapsulation.HasValue)
            {
                writer.WritePropertyName("encapsulation"u8);
                writer.WriteStringValue(Encapsulation.Value.ToString());
            }
            if (options.Format != "W" && EtherType != null)
            {
                writer.WritePropertyName("etherType"u8);
                writer.WriteStringValue(EtherType);
            }
            if (options.Format != "W" && AllocationDate != null)
            {
                writer.WritePropertyName("allocationDate"u8);
                writer.WriteStringValue(AllocationDate);
            }
            if (!(Links is ChangeTrackingList<ExpressRouteLinkData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Circuits is ChangeTrackingList<WritableSubResource> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("circuits"u8);
                writer.WriteStartArray();
                foreach (var item in Circuits)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && ResourceGuid.HasValue)
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid.Value);
            }
            if (BillingType.HasValue)
            {
                writer.WritePropertyName("billingType"u8);
                writer.WriteStringValue(BillingType.Value.ToString());
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

        ExpressRoutePortData IJsonModel<ExpressRoutePortData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRoutePortData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRoutePortData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRoutePortData(document.RootElement, options);
        }

        internal static ExpressRoutePortData DeserializeExpressRoutePortData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> peeringLocation = default;
            Optional<int> bandwidthInGbps = default;
            Optional<float> provisionedBandwidthInGbps = default;
            Optional<string> mtu = default;
            Optional<ExpressRoutePortsEncapsulation> encapsulation = default;
            Optional<string> etherType = default;
            Optional<string> allocationDate = default;
            Optional<IList<ExpressRouteLinkData>> links = default;
            Optional<IReadOnlyList<WritableSubResource>> circuits = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<Guid> resourceGuid = default;
            Optional<ExpressRoutePortsBillingType> billingType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
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
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("peeringLocation"u8))
                        {
                            peeringLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bandwidthInGbps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bandwidthInGbps = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisionedBandwidthInGbps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisionedBandwidthInGbps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("mtu"u8))
                        {
                            mtu = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encapsulation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encapsulation = new ExpressRoutePortsEncapsulation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("etherType"u8))
                        {
                            etherType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allocationDate"u8))
                        {
                            allocationDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteLinkData> array = new List<ExpressRouteLinkData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteLinkData.DeserializeExpressRouteLinkData(item, options));
                            }
                            links = array;
                            continue;
                        }
                        if (property0.NameEquals("circuits"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            circuits = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("billingType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingType = new ExpressRoutePortsBillingType(property0.Value.GetString());
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
            return new ExpressRoutePortData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), serializedAdditionalRawData, Optional.ToNullable(etag), identity, peeringLocation.Value, Optional.ToNullable(bandwidthInGbps), Optional.ToNullable(provisionedBandwidthInGbps), mtu.Value, Optional.ToNullable(encapsulation), etherType.Value, allocationDate.Value, Optional.ToList(links), Optional.ToList(circuits), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceGuid), Optional.ToNullable(billingType));
        }

        BinaryData IPersistableModel<ExpressRoutePortData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRoutePortData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRoutePortData)} does not support '{options.Format}' format.");
            }
        }

        ExpressRoutePortData IPersistableModel<ExpressRoutePortData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRoutePortData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRoutePortData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRoutePortData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRoutePortData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
