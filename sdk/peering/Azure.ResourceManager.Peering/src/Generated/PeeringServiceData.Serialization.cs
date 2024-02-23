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
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    public partial class PeeringServiceData : IUtf8JsonSerializable, IJsonModel<PeeringServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeeringServiceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PeeringServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringServiceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
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
            if (PeeringServiceLocation != null)
            {
                writer.WritePropertyName("peeringServiceLocation"u8);
                writer.WriteStringValue(PeeringServiceLocation);
            }
            if (PeeringServiceProvider != null)
            {
                writer.WritePropertyName("peeringServiceProvider"u8);
                writer.WriteStringValue(PeeringServiceProvider);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (ProviderPrimaryPeeringLocation != null)
            {
                writer.WritePropertyName("providerPrimaryPeeringLocation"u8);
                writer.WriteStringValue(ProviderPrimaryPeeringLocation);
            }
            if (ProviderBackupPeeringLocation != null)
            {
                writer.WritePropertyName("providerBackupPeeringLocation"u8);
                writer.WriteStringValue(ProviderBackupPeeringLocation);
            }
            if (LogAnalyticsWorkspaceProperties != null)
            {
                writer.WritePropertyName("logAnalyticsWorkspaceProperties"u8);
                writer.WriteObjectValue(LogAnalyticsWorkspaceProperties);
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

        PeeringServiceData IJsonModel<PeeringServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringServiceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringServiceData(document.RootElement, options);
        }

        internal static PeeringServiceData DeserializePeeringServiceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PeeringServiceSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> peeringServiceLocation = default;
            Optional<string> peeringServiceProvider = default;
            Optional<PeeringProvisioningState> provisioningState = default;
            Optional<string> providerPrimaryPeeringLocation = default;
            Optional<string> providerBackupPeeringLocation = default;
            Optional<PeeringLogAnalyticsWorkspaceProperties> logAnalyticsWorkspaceProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = PeeringServiceSku.DeserializePeeringServiceSku(property.Value, options);
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
                        if (property0.NameEquals("peeringServiceLocation"u8))
                        {
                            peeringServiceLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("peeringServiceProvider"u8))
                        {
                            peeringServiceProvider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PeeringProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("providerPrimaryPeeringLocation"u8))
                        {
                            providerPrimaryPeeringLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerBackupPeeringLocation"u8))
                        {
                            providerBackupPeeringLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsWorkspaceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logAnalyticsWorkspaceProperties = PeeringLogAnalyticsWorkspaceProperties.DeserializePeeringLogAnalyticsWorkspaceProperties(property0.Value, options);
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
            return new PeeringServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, peeringServiceLocation.Value, peeringServiceProvider.Value, Optional.ToNullable(provisioningState), providerPrimaryPeeringLocation.Value, providerBackupPeeringLocation.Value, logAnalyticsWorkspaceProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeeringServiceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PeeringServiceData)} does not support '{options.Format}' format.");
            }
        }

        PeeringServiceData IPersistableModel<PeeringServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePeeringServiceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeeringServiceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeeringServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
