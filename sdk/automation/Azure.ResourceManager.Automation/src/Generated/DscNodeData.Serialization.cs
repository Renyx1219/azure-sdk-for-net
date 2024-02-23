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
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class DscNodeData : IUtf8JsonSerializable, IJsonModel<DscNodeData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscNodeData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DscNodeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscNodeData)} does not support '{format}' format.");
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
            if (LastSeenOn.HasValue)
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeenOn.Value, "O");
            }
            if (RegistrationOn.HasValue)
            {
                writer.WritePropertyName("registrationTime"u8);
                writer.WriteStringValue(RegistrationOn.Value, "O");
            }
            if (IP != null)
            {
                writer.WritePropertyName("ip"u8);
                writer.WriteStringValue(IP);
            }
            if (AccountId != null)
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (NodeId != null)
            {
                writer.WritePropertyName("nodeId"u8);
                writer.WriteStringValue(NodeId);
            }
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (TotalCount.HasValue)
            {
                writer.WritePropertyName("totalCount"u8);
                writer.WriteNumberValue(TotalCount.Value);
            }
            if (!(ExtensionHandler is ChangeTrackingList<DscNodeExtensionHandlerAssociationProperty> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("extensionHandler"u8);
                writer.WriteStartArray();
                foreach (var item in ExtensionHandler)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("nodeConfiguration"u8);
            writer.WriteStartObject();
            if (NamePropertiesNodeConfigurationName != null)
            {
                if (NamePropertiesNodeConfigurationName != null)
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(NamePropertiesNodeConfigurationName);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            writer.WriteEndObject();
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

        DscNodeData IJsonModel<DscNodeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscNodeData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscNodeData(document.RootElement, options);
        }

        internal static DscNodeData DeserializeDscNodeData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<DateTimeOffset> lastSeen = default;
            Optional<DateTimeOffset> registrationTime = default;
            Optional<string> ip = default;
            Optional<string> accountId = default;
            Optional<string> status = default;
            Optional<string> nodeId = default;
            Optional<ETag> etag = default;
            Optional<int> totalCount = default;
            Optional<IList<DscNodeExtensionHandlerAssociationProperty>> extensionHandler = default;
            Optional<string> name0 = default;
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
                        if (property0.NameEquals("lastSeen"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSeen = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("registrationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("ip"u8))
                        {
                            ip = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountId"u8))
                        {
                            accountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeId"u8))
                        {
                            nodeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("etag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            etag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("totalCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("extensionHandler"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DscNodeExtensionHandlerAssociationProperty> array = new List<DscNodeExtensionHandlerAssociationProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DscNodeExtensionHandlerAssociationProperty.DeserializeDscNodeExtensionHandlerAssociationProperty(item, options));
                            }
                            extensionHandler = array;
                            continue;
                        }
                        if (property0.NameEquals("nodeConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("name"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        name0 = null;
                                        continue;
                                    }
                                    name0 = property1.Value.GetString();
                                    continue;
                                }
                            }
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
            return new DscNodeData(id, name, type, systemData.Value, Optional.ToNullable(lastSeen), Optional.ToNullable(registrationTime), ip.Value, accountId.Value, status.Value, nodeId.Value, Optional.ToNullable(etag), Optional.ToNullable(totalCount), Optional.ToList(extensionHandler), name0.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscNodeData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DscNodeData)} does not support '{options.Format}' format.");
            }
        }

        DscNodeData IPersistableModel<DscNodeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDscNodeData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscNodeData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscNodeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
