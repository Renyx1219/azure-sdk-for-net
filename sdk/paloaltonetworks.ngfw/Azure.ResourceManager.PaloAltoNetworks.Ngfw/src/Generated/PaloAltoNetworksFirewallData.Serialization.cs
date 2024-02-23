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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class PaloAltoNetworksFirewallData : IUtf8JsonSerializable, IJsonModel<PaloAltoNetworksFirewallData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PaloAltoNetworksFirewallData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PaloAltoNetworksFirewallData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PaloAltoNetworksFirewallData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PaloAltoNetworksFirewallData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
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
            if (PanETag.HasValue)
            {
                writer.WritePropertyName("panEtag"u8);
                writer.WriteStringValue(PanETag.Value.ToString());
            }
            writer.WritePropertyName("networkProfile"u8);
            writer.WriteObjectValue(NetworkProfile);
            if (IsPanoramaManaged.HasValue)
            {
                writer.WritePropertyName("isPanoramaManaged"u8);
                writer.WriteStringValue(IsPanoramaManaged.Value.ToString());
            }
            if (PanoramaConfig != null)
            {
                writer.WritePropertyName("panoramaConfig"u8);
                writer.WriteObjectValue(PanoramaConfig);
            }
            if (AssociatedRulestack != null)
            {
                writer.WritePropertyName("associatedRulestack"u8);
                writer.WriteObjectValue(AssociatedRulestack);
            }
            writer.WritePropertyName("dnsSettings"u8);
            writer.WriteObjectValue(DnsSettings);
            if (!(FrontEndSettings is ChangeTrackingList<FirewallFrontendSetting> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("frontEndSettings"u8);
                writer.WriteStartArray();
                foreach (var item in FrontEndSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("planData"u8);
            writer.WriteObjectValue(PlanData);
            writer.WritePropertyName("marketplaceDetails"u8);
            writer.WriteObjectValue(MarketplaceDetails);
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

        PaloAltoNetworksFirewallData IJsonModel<PaloAltoNetworksFirewallData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PaloAltoNetworksFirewallData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PaloAltoNetworksFirewallData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePaloAltoNetworksFirewallData(document.RootElement, options);
        }

        internal static PaloAltoNetworksFirewallData DeserializePaloAltoNetworksFirewallData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ETag> panETag = default;
            FirewallNetworkProfile networkProfile = default;
            Optional<FirewallBooleanType> isPanoramaManaged = default;
            Optional<FirewallPanoramaConfiguration> panoramaConfig = default;
            Optional<RulestackDetails> associatedRulestack = default;
            FirewallDnsSettings dnsSettings = default;
            Optional<IList<FirewallFrontendSetting>> frontEndSettings = default;
            Optional<FirewallProvisioningState> provisioningState = default;
            FirewallBillingPlanInfo planData = default;
            PanFirewallMarketplaceDetails marketplaceDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
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
                        if (property0.NameEquals("panEtag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            panETag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            networkProfile = FirewallNetworkProfile.DeserializeFirewallNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isPanoramaManaged"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPanoramaManaged = new FirewallBooleanType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("panoramaConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            panoramaConfig = FirewallPanoramaConfiguration.DeserializeFirewallPanoramaConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("associatedRulestack"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            associatedRulestack = RulestackDetails.DeserializeRulestackDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            dnsSettings = FirewallDnsSettings.DeserializeFirewallDnsSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("frontEndSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FirewallFrontendSetting> array = new List<FirewallFrontendSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FirewallFrontendSetting.DeserializeFirewallFrontendSetting(item, options));
                            }
                            frontEndSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FirewallProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("planData"u8))
                        {
                            planData = FirewallBillingPlanInfo.DeserializeFirewallBillingPlanInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("marketplaceDetails"u8))
                        {
                            marketplaceDetails = PanFirewallMarketplaceDetails.DeserializePanFirewallMarketplaceDetails(property0.Value, options);
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
            return new PaloAltoNetworksFirewallData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, Optional.ToNullable(panETag), networkProfile, Optional.ToNullable(isPanoramaManaged), panoramaConfig.Value, associatedRulestack.Value, dnsSettings, Optional.ToList(frontEndSettings), Optional.ToNullable(provisioningState), planData, marketplaceDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PaloAltoNetworksFirewallData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PaloAltoNetworksFirewallData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PaloAltoNetworksFirewallData)} does not support '{options.Format}' format.");
            }
        }

        PaloAltoNetworksFirewallData IPersistableModel<PaloAltoNetworksFirewallData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PaloAltoNetworksFirewallData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePaloAltoNetworksFirewallData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PaloAltoNetworksFirewallData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PaloAltoNetworksFirewallData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
