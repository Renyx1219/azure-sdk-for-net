// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HardwareSecurityModules.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    public partial class CloudHsmClusterData : IUtf8JsonSerializable, IJsonModel<CloudHsmClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudHsmClusterData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudHsmClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudHsmClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudHsmClusterData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
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
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (AutoGeneratedDomainNameLabelScope != null)
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabelScope"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabelScope);
            }
            if (SecurityDomain != null)
            {
                writer.WritePropertyName("securityDomain"u8);
                writer.WriteObjectValue(SecurityDomain);
            }
            if (!(Hsms is ChangeTrackingList<CloudHsmProperties> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("hsms"u8);
                writer.WriteStartArray();
                foreach (var item in Hsms)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PublicNetworkAccess != null)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess);
            }
            if (!(PrivateEndpointConnections is ChangeTrackingList<HardwareSecurityModulesPrivateEndpointConnectionData> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && StatusMessage != null)
            {
                writer.WritePropertyName("statusMessage"u8);
                writer.WriteStringValue(StatusMessage);
            }
            if (RestoreProperties != null)
            {
                writer.WritePropertyName("restoreProperties"u8);
                writer.WriteObjectValue(RestoreProperties);
            }
            if (BackupProperties != null)
            {
                writer.WritePropertyName("backupProperties"u8);
                writer.WriteObjectValue(BackupProperties);
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

        CloudHsmClusterData IJsonModel<CloudHsmClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudHsmClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudHsmClusterData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudHsmClusterData(document.RootElement, options);
        }

        internal static CloudHsmClusterData DeserializeCloudHsmClusterData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CloudHsmClusterSku> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> autoGeneratedDomainNameLabelScope = default;
            Optional<CloudHsmClusterSecurityDomainProperties> securityDomain = default;
            Optional<IList<CloudHsmProperties>> hsms = default;
            Optional<string> publicNetworkAccess = default;
            Optional<IList<HardwareSecurityModulesPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<string> statusMessage = default;
            Optional<RestoreProperties> restoreProperties = default;
            Optional<BackupProperties> backupProperties = default;
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
                    sku = CloudHsmClusterSku.DeserializeCloudHsmClusterSku(property.Value, options);
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("autoGeneratedDomainNameLabelScope"u8))
                        {
                            autoGeneratedDomainNameLabelScope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("securityDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityDomain = CloudHsmClusterSecurityDomainProperties.DeserializeCloudHsmClusterSecurityDomainProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hsms"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CloudHsmProperties> array = new List<CloudHsmProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CloudHsmProperties.DeserializeCloudHsmProperties(item, options));
                            }
                            hsms = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            publicNetworkAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HardwareSecurityModulesPrivateEndpointConnectionData> array = new List<HardwareSecurityModulesPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HardwareSecurityModulesPrivateEndpointConnectionData.DeserializeHardwareSecurityModulesPrivateEndpointConnectionData(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("statusMessage"u8))
                        {
                            statusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restoreProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restoreProperties = RestoreProperties.DeserializeRestoreProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("backupProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupProperties = BackupProperties.DeserializeBackupProperties(property0.Value, options);
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
            return new CloudHsmClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), autoGeneratedDomainNameLabelScope.Value, securityDomain.Value, Optional.ToList(hsms), publicNetworkAccess.Value, Optional.ToList(privateEndpointConnections), statusMessage.Value, restoreProperties.Value, backupProperties.Value, sku.Value, identity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudHsmClusterData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudHsmClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudHsmClusterData)} does not support '{options.Format}' format.");
            }
        }

        CloudHsmClusterData IPersistableModel<CloudHsmClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudHsmClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudHsmClusterData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudHsmClusterData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudHsmClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
