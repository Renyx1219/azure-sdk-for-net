// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class TopicTypeData : IUtf8JsonSerializable, IJsonModel<TopicTypeData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TopicTypeData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TopicTypeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopicTypeData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Provider != null)
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (ResourceRegionType.HasValue)
            {
                writer.WritePropertyName("resourceRegionType"u8);
                writer.WriteStringValue(ResourceRegionType.Value.ToString());
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (!(SupportedLocations is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedLocations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SourceResourceFormat != null)
            {
                writer.WritePropertyName("sourceResourceFormat"u8);
                writer.WriteStringValue(SourceResourceFormat);
            }
            if (!(SupportedScopesForSource is ChangeTrackingList<TopicTypeSourceScope> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("supportedScopesForSource"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedScopesForSource)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (AreRegionalAndGlobalSourcesSupported.HasValue)
            {
                writer.WritePropertyName("areRegionalAndGlobalSourcesSupported"u8);
                writer.WriteBooleanValue(AreRegionalAndGlobalSourcesSupported.Value);
            }
            if (!(AdditionalEnforcedPermissions is ChangeTrackingList<TopicTypeAdditionalEnforcedPermission> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("additionalEnforcedPermissions"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalEnforcedPermissions)
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

        TopicTypeData IJsonModel<TopicTypeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopicTypeData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTopicTypeData(document.RootElement, options);
        }

        internal static TopicTypeData DeserializeTopicTypeData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provider = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<EventGridResourceRegionType> resourceRegionType = default;
            Optional<TopicTypeProvisioningState> provisioningState = default;
            Optional<IList<string>> supportedLocations = default;
            Optional<string> sourceResourceFormat = default;
            Optional<IList<TopicTypeSourceScope>> supportedScopesForSource = default;
            Optional<bool> areRegionalAndGlobalSourcesSupported = default;
            Optional<IList<TopicTypeAdditionalEnforcedPermission>> additionalEnforcedPermissions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provider"u8))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceRegionType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceRegionType = new EventGridResourceRegionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new TopicTypeProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportedLocations"u8))
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
                            supportedLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceFormat"u8))
                        {
                            sourceResourceFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("supportedScopesForSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TopicTypeSourceScope> array = new List<TopicTypeSourceScope>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new TopicTypeSourceScope(item.GetString()));
                            }
                            supportedScopesForSource = array;
                            continue;
                        }
                        if (property0.NameEquals("areRegionalAndGlobalSourcesSupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            areRegionalAndGlobalSourcesSupported = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("additionalEnforcedPermissions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TopicTypeAdditionalEnforcedPermission> array = new List<TopicTypeAdditionalEnforcedPermission>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TopicTypeAdditionalEnforcedPermission.DeserializeTopicTypeAdditionalEnforcedPermission(item, options));
                            }
                            additionalEnforcedPermissions = array;
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
            return new TopicTypeData(id, name, type, systemData.Value, provider.Value, displayName.Value, description.Value, Optional.ToNullable(resourceRegionType), Optional.ToNullable(provisioningState), Optional.ToList(supportedLocations), sourceResourceFormat.Value, Optional.ToList(supportedScopesForSource), Optional.ToNullable(areRegionalAndGlobalSourcesSupported), Optional.ToList(additionalEnforcedPermissions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TopicTypeData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TopicTypeData)} does not support '{options.Format}' format.");
            }
        }

        TopicTypeData IPersistableModel<TopicTypeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTopicTypeData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TopicTypeData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TopicTypeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
