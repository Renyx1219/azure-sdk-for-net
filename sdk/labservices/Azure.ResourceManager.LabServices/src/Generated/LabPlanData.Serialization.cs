// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class LabPlanData : IUtf8JsonSerializable, IJsonModel<LabPlanData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabPlanData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LabPlanData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabPlanData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabPlanData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
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
            if (DefaultConnectionProfile != null)
            {
                writer.WritePropertyName("defaultConnectionProfile"u8);
                writer.WriteObjectValue(DefaultConnectionProfile);
            }
            if (DefaultAutoShutdownProfile != null)
            {
                writer.WritePropertyName("defaultAutoShutdownProfile"u8);
                writer.WriteObjectValue(DefaultAutoShutdownProfile);
            }
            if (DefaultNetworkProfile != null)
            {
                writer.WritePropertyName("defaultNetworkProfile"u8);
                writer.WriteObjectValue(DefaultNetworkProfile);
            }
            if (!(AllowedRegions is ChangeTrackingList<AzureLocation> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("allowedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SharedGalleryId != null)
            {
                writer.WritePropertyName("sharedGalleryId"u8);
                writer.WriteStringValue(SharedGalleryId);
            }
            if (SupportInfo != null)
            {
                writer.WritePropertyName("supportInfo"u8);
                writer.WriteObjectValue(SupportInfo);
            }
            if (LinkedLmsInstance != null)
            {
                writer.WritePropertyName("linkedLmsInstance"u8);
                writer.WriteStringValue(LinkedLmsInstance.AbsoluteUri);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
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

        LabPlanData IJsonModel<LabPlanData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabPlanData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabPlanData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabPlanData(document.RootElement, options);
        }

        internal static LabPlanData DeserializeLabPlanData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<LabConnectionProfile> defaultConnectionProfile = default;
            Optional<LabAutoShutdownProfile> defaultAutoShutdownProfile = default;
            Optional<LabPlanNetworkProfile> defaultNetworkProfile = default;
            Optional<IList<AzureLocation>> allowedRegions = default;
            Optional<ResourceIdentifier> sharedGalleryId = default;
            Optional<LabPlanSupportInfo> supportInfo = default;
            Optional<Uri> linkedLmsInstance = default;
            Optional<LabServicesProvisioningState> provisioningState = default;
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
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("defaultConnectionProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultConnectionProfile = LabConnectionProfile.DeserializeLabConnectionProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("defaultAutoShutdownProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultAutoShutdownProfile = LabAutoShutdownProfile.DeserializeLabAutoShutdownProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("defaultNetworkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultNetworkProfile = LabPlanNetworkProfile.DeserializeLabPlanNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("allowedRegions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureLocation> array = new List<AzureLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AzureLocation(item.GetString()));
                            }
                            allowedRegions = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedGalleryId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sharedGalleryId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportInfo = LabPlanSupportInfo.DeserializeLabPlanSupportInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("linkedLmsInstance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedLmsInstance = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToLabServicesProvisioningState();
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
            return new LabPlanData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, defaultConnectionProfile.Value, defaultAutoShutdownProfile.Value, defaultNetworkProfile.Value, Optional.ToList(allowedRegions), sharedGalleryId.Value, supportInfo.Value, linkedLmsInstance.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LabPlanData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabPlanData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LabPlanData)} does not support '{options.Format}' format.");
            }
        }

        LabPlanData IPersistableModel<LabPlanData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabPlanData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabPlanData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LabPlanData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabPlanData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
