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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnGatewayNatRuleData : IUtf8JsonSerializable, IJsonModel<VpnGatewayNatRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnGatewayNatRuleData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnGatewayNatRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayNatRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnGatewayNatRuleData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (VpnNatRuleType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(VpnNatRuleType.Value.ToString());
            }
            if (Mode.HasValue)
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (!(InternalMappings is ChangeTrackingList<VpnNatRuleMapping> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("internalMappings"u8);
                writer.WriteStartArray();
                foreach (var item in InternalMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExternalMappings is ChangeTrackingList<VpnNatRuleMapping> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("externalMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IPConfigurationId != null)
            {
                writer.WritePropertyName("ipConfigurationId"u8);
                writer.WriteStringValue(IPConfigurationId);
            }
            if (options.Format != "W" && !(EgressVpnSiteLinkConnections is ChangeTrackingList<WritableSubResource> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("egressVpnSiteLinkConnections"u8);
                writer.WriteStartArray();
                foreach (var item in EgressVpnSiteLinkConnections)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(IngressVpnSiteLinkConnections is ChangeTrackingList<WritableSubResource> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("ingressVpnSiteLinkConnections"u8);
                writer.WriteStartArray();
                foreach (var item in IngressVpnSiteLinkConnections)
                {
                    JsonSerializer.Serialize(writer, item);
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

        VpnGatewayNatRuleData IJsonModel<VpnGatewayNatRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayNatRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnGatewayNatRuleData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnGatewayNatRuleData(document.RootElement, options);
        }

        internal static VpnGatewayNatRuleData DeserializeVpnGatewayNatRuleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<VpnNatRuleType> type0 = default;
            Optional<VpnNatRuleMode> mode = default;
            Optional<IList<VpnNatRuleMapping>> internalMappings = default;
            Optional<IList<VpnNatRuleMapping>> externalMappings = default;
            Optional<string> ipConfigurationId = default;
            Optional<IReadOnlyList<WritableSubResource>> egressVpnSiteLinkConnections = default;
            Optional<IReadOnlyList<WritableSubResource>> ingressVpnSiteLinkConnections = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new VpnNatRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mode = new VpnNatRuleMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("internalMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item, options));
                            }
                            internalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("externalMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item, options));
                            }
                            externalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurationId"u8))
                        {
                            ipConfigurationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("egressVpnSiteLinkConnections"u8))
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
                            egressVpnSiteLinkConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("ingressVpnSiteLinkConnections"u8))
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
                            ingressVpnSiteLinkConnections = array;
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
            return new VpnGatewayNatRuleData(id.Value, name.Value, Optional.ToNullable(type), serializedAdditionalRawData, Optional.ToNullable(etag), Optional.ToNullable(provisioningState), Optional.ToNullable(type0), Optional.ToNullable(mode), Optional.ToList(internalMappings), Optional.ToList(externalMappings), ipConfigurationId.Value, Optional.ToList(egressVpnSiteLinkConnections), Optional.ToList(ingressVpnSiteLinkConnections));
        }

        BinaryData IPersistableModel<VpnGatewayNatRuleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayNatRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnGatewayNatRuleData)} does not support '{options.Format}' format.");
            }
        }

        VpnGatewayNatRuleData IPersistableModel<VpnGatewayNatRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayNatRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnGatewayNatRuleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnGatewayNatRuleData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnGatewayNatRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
