// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers
{
    public partial class HDInsightClusterPoolData : IUtf8JsonSerializable, IJsonModel<HDInsightClusterPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterPoolData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightClusterPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterPoolData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && DeploymentId != null)
            {
                writer.WritePropertyName("deploymentId"u8);
                writer.WriteStringValue(DeploymentId);
            }
            if (ManagedResourceGroupName != null)
            {
                writer.WritePropertyName("managedResourceGroupName"u8);
                writer.WriteStringValue(ManagedResourceGroupName);
            }
            if (options.Format != "W" && AksManagedResourceGroupName != null)
            {
                writer.WritePropertyName("aksManagedResourceGroupName"u8);
                writer.WriteStringValue(AksManagedResourceGroupName);
            }
            if (ClusterPoolProfile != null)
            {
                writer.WritePropertyName("clusterPoolProfile"u8);
                writer.WriteObjectValue(ClusterPoolProfile);
            }
            if (ComputeProfile != null)
            {
                writer.WritePropertyName("computeProfile"u8);
                writer.WriteObjectValue(ComputeProfile);
            }
            if (options.Format != "W" && AksClusterProfile != null)
            {
                writer.WritePropertyName("aksClusterProfile"u8);
                writer.WriteObjectValue(AksClusterProfile);
            }
            if (NetworkProfile != null)
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (LogAnalyticsProfile != null)
            {
                writer.WritePropertyName("logAnalyticsProfile"u8);
                writer.WriteObjectValue(LogAnalyticsProfile);
            }
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        HDInsightClusterPoolData IJsonModel<HDInsightClusterPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterPoolData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterPoolData(document.RootElement, options);
        }

        internal static HDInsightClusterPoolData DeserializeHDInsightClusterPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HDInsightProvisioningStatus> provisioningState = default;
            Optional<string> deploymentId = default;
            Optional<string> managedResourceGroupName = default;
            Optional<string> aksManagedResourceGroupName = default;
            Optional<ClusterPoolProfile> clusterPoolProfile = default;
            Optional<ClusterPoolComputeProfile> computeProfile = default;
            Optional<AksClusterProfile> aksClusterProfile = default;
            Optional<ClusterPoolNetworkProfile> networkProfile = default;
            Optional<ClusterPoolLogAnalyticsProfile> logAnalyticsProfile = default;
            Optional<string> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                            provisioningState = new HDInsightProvisioningStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentId"u8))
                        {
                            deploymentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupName"u8))
                        {
                            managedResourceGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aksManagedResourceGroupName"u8))
                        {
                            aksManagedResourceGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterPoolProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterPoolProfile = ClusterPoolProfile.DeserializeClusterPoolProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("computeProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeProfile = ClusterPoolComputeProfile.DeserializeClusterPoolComputeProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("aksClusterProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aksClusterProfile = AksClusterProfile.DeserializeAksClusterProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = ClusterPoolNetworkProfile.DeserializeClusterPoolNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logAnalyticsProfile = ClusterPoolLogAnalyticsProfile.DeserializeClusterPoolLogAnalyticsProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
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
            return new HDInsightClusterPoolData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), deploymentId.Value, managedResourceGroupName.Value, aksManagedResourceGroupName.Value, clusterPoolProfile.Value, computeProfile.Value, aksClusterProfile.Value, networkProfile.Value, logAnalyticsProfile.Value, status.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterPoolData)} does not support '{options.Format}' format.");
            }
        }

        HDInsightClusterPoolData IPersistableModel<HDInsightClusterPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightClusterPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterPoolData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
