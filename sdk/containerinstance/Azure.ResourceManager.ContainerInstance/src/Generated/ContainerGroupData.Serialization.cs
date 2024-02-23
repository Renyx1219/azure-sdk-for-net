// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerInstance
{
    public partial class ContainerGroupData : IUtf8JsonSerializable, IJsonModel<ContainerGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerGroupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Zones is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
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
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WritePropertyName("containers"u8);
            writer.WriteStartArray();
            foreach (var item in Containers)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(ImageRegistryCredentials is ChangeTrackingList<ContainerGroupImageRegistryCredential> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("imageRegistryCredentials"u8);
                writer.WriteStartArray();
                foreach (var item in ImageRegistryCredentials)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RestartPolicy.HasValue)
            {
                writer.WritePropertyName("restartPolicy"u8);
                writer.WriteStringValue(RestartPolicy.Value.ToString());
            }
            if (IPAddress != null)
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteObjectValue(IPAddress);
            }
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
            if (!(Volumes is ChangeTrackingList<ContainerVolume> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && InstanceView != null)
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView);
            }
            if (Diagnostics != null)
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteObjectValue(Diagnostics);
            }
            if (!(SubnetIds is ChangeTrackingList<ContainerGroupSubnetId> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("subnetIds"u8);
                writer.WriteStartArray();
                foreach (var item in SubnetIds)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DnsConfig != null)
            {
                writer.WritePropertyName("dnsConfig"u8);
                writer.WriteObjectValue(DnsConfig);
            }
            if (Sku.HasValue)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku.Value.ToString());
            }
            if (EncryptionProperties != null)
            {
                writer.WritePropertyName("encryptionProperties"u8);
                writer.WriteObjectValue(EncryptionProperties);
            }
            if (!(InitContainers is ChangeTrackingList<InitContainerDefinitionContent> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Extensions is ChangeTrackingList<DeploymentExtensionSpec> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ConfidentialComputeProperties != null)
            {
                writer.WritePropertyName("confidentialComputeProperties"u8);
                writer.WriteObjectValue(ConfidentialComputeProperties);
            }
            if (Priority.HasValue)
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteStringValue(Priority.Value.ToString());
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

        ContainerGroupData IJsonModel<ContainerGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupData(document.RootElement, options);
        }

        internal static ContainerGroupData DeserializeContainerGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> zones = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provisioningState = default;
            IList<ContainerInstanceContainer> containers = default;
            Optional<IList<ContainerGroupImageRegistryCredential>> imageRegistryCredentials = default;
            Optional<ContainerGroupRestartPolicy> restartPolicy = default;
            Optional<ContainerGroupIPAddress> ipAddress = default;
            ContainerInstanceOperatingSystemType osType = default;
            Optional<IList<ContainerVolume>> volumes = default;
            Optional<ContainerGroupInstanceView> instanceView = default;
            Optional<ContainerGroupDiagnostics> diagnostics = default;
            Optional<IList<ContainerGroupSubnetId>> subnetIds = default;
            Optional<ContainerGroupDnsConfiguration> dnsConfig = default;
            Optional<ContainerGroupSku> sku = default;
            Optional<ContainerGroupEncryptionProperties> encryptionProperties = default;
            Optional<IList<InitContainerDefinitionContent>> initContainers = default;
            Optional<IList<DeploymentExtensionSpec>> extensions = default;
            Optional<ConfidentialComputeProperties> confidentialComputeProperties = default;
            Optional<ContainerGroupPriority> priority = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
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
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containers"u8))
                        {
                            List<ContainerInstanceContainer> array = new List<ContainerInstanceContainer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerInstanceContainer.DeserializeContainerInstanceContainer(item, options));
                            }
                            containers = array;
                            continue;
                        }
                        if (property0.NameEquals("imageRegistryCredentials"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerGroupImageRegistryCredential> array = new List<ContainerGroupImageRegistryCredential>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerGroupImageRegistryCredential.DeserializeContainerGroupImageRegistryCredential(item, options));
                            }
                            imageRegistryCredentials = array;
                            continue;
                        }
                        if (property0.NameEquals("restartPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restartPolicy = new ContainerGroupRestartPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipAddress = ContainerGroupIPAddress.DeserializeContainerGroupIPAddress(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = new ContainerInstanceOperatingSystemType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("volumes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerVolume> array = new List<ContainerVolume>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerVolume.DeserializeContainerVolume(item, options));
                            }
                            volumes = array;
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = ContainerGroupInstanceView.DeserializeContainerGroupInstanceView(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("diagnostics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnostics = ContainerGroupDiagnostics.DeserializeContainerGroupDiagnostics(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("subnetIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerGroupSubnetId> array = new List<ContainerGroupSubnetId>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerGroupSubnetId.DeserializeContainerGroupSubnetId(item, options));
                            }
                            subnetIds = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsConfig = ContainerGroupDnsConfiguration.DeserializeContainerGroupDnsConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = new ContainerGroupSku(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryptionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionProperties = ContainerGroupEncryptionProperties.DeserializeContainerGroupEncryptionProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("initContainers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<InitContainerDefinitionContent> array = new List<InitContainerDefinitionContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InitContainerDefinitionContent.DeserializeInitContainerDefinitionContent(item, options));
                            }
                            initContainers = array;
                            continue;
                        }
                        if (property0.NameEquals("extensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeploymentExtensionSpec> array = new List<DeploymentExtensionSpec>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeploymentExtensionSpec.DeserializeDeploymentExtensionSpec(item, options));
                            }
                            extensions = array;
                            continue;
                        }
                        if (property0.NameEquals("confidentialComputeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidentialComputeProperties = ConfidentialComputeProperties.DeserializeConfidentialComputeProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = new ContainerGroupPriority(property0.Value.GetString());
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
            return new ContainerGroupData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToList(zones), identity, provisioningState.Value, containers, Optional.ToList(imageRegistryCredentials), Optional.ToNullable(restartPolicy), ipAddress.Value, osType, Optional.ToList(volumes), instanceView.Value, diagnostics.Value, Optional.ToList(subnetIds), dnsConfig.Value, Optional.ToNullable(sku), encryptionProperties.Value, Optional.ToList(initContainers), Optional.ToList(extensions), confidentialComputeProperties.Value, Optional.ToNullable(priority), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupData)} does not support '{options.Format}' format.");
            }
        }

        ContainerGroupData IPersistableModel<ContainerGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
