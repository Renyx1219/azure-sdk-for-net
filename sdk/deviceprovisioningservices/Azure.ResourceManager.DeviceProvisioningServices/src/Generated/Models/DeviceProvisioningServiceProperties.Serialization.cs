// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServiceProperties : IUtf8JsonSerializable, IJsonModel<DeviceProvisioningServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceProvisioningServiceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceProvisioningServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceProvisioningServiceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (!(IPFilterRules is ChangeTrackingList<DeviceProvisioningServicesIPFilterRule> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ipFilterRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPFilterRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PrivateEndpointConnections is ChangeTrackingList<DeviceProvisioningServicesPrivateEndpointConnectionData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (!(IotHubs is ChangeTrackingList<IotHubDefinitionDescription> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("iotHubs"u8);
                writer.WriteStartArray();
                foreach (var item in IotHubs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AllocationPolicy.HasValue)
            {
                writer.WritePropertyName("allocationPolicy"u8);
                writer.WriteStringValue(AllocationPolicy.Value.ToString());
            }
            if (options.Format != "W" && ServiceOperationsHostName != null)
            {
                writer.WritePropertyName("serviceOperationsHostName"u8);
                writer.WriteStringValue(ServiceOperationsHostName);
            }
            if (options.Format != "W" && DeviceProvisioningHostName != null)
            {
                writer.WritePropertyName("deviceProvisioningHostName"u8);
                writer.WriteStringValue(DeviceProvisioningHostName);
            }
            if (options.Format != "W" && IdScope != null)
            {
                writer.WritePropertyName("idScope"u8);
                writer.WriteStringValue(IdScope);
            }
            if (!(AuthorizationPolicies is ChangeTrackingList<DeviceProvisioningServicesSharedAccessKey> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("authorizationPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsDataResidencyEnabled.HasValue)
            {
                writer.WritePropertyName("enableDataResidency"u8);
                writer.WriteBooleanValue(IsDataResidencyEnabled.Value);
            }
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

        DeviceProvisioningServiceProperties IJsonModel<DeviceProvisioningServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceProvisioningServiceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceProvisioningServiceProperties(document.RootElement, options);
        }

        internal static DeviceProvisioningServiceProperties DeserializeDeviceProvisioningServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DeviceProvisioningServicesState> state = default;
            Optional<DeviceProvisioningServicesPublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<DeviceProvisioningServicesIPFilterRule>> ipFilterRules = default;
            Optional<IList<DeviceProvisioningServicesPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<string> provisioningState = default;
            Optional<IList<IotHubDefinitionDescription>> iotHubs = default;
            Optional<DeviceProvisioningServicesAllocationPolicy> allocationPolicy = default;
            Optional<string> serviceOperationsHostName = default;
            Optional<string> deviceProvisioningHostName = default;
            Optional<string> idScope = default;
            Optional<IList<DeviceProvisioningServicesSharedAccessKey>> authorizationPolicies = default;
            Optional<bool> enableDataResidency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new DeviceProvisioningServicesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new DeviceProvisioningServicesPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipFilterRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesIPFilterRule> array = new List<DeviceProvisioningServicesIPFilterRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesIPFilterRule.DeserializeDeviceProvisioningServicesIPFilterRule(item, options));
                    }
                    ipFilterRules = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesPrivateEndpointConnectionData> array = new List<DeviceProvisioningServicesPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesPrivateEndpointConnectionData.DeserializeDeviceProvisioningServicesPrivateEndpointConnectionData(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iotHubs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubDefinitionDescription> array = new List<IotHubDefinitionDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubDefinitionDescription.DeserializeIotHubDefinitionDescription(item, options));
                    }
                    iotHubs = array;
                    continue;
                }
                if (property.NameEquals("allocationPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationPolicy = new DeviceProvisioningServicesAllocationPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceOperationsHostName"u8))
                {
                    serviceOperationsHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceProvisioningHostName"u8))
                {
                    deviceProvisioningHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("idScope"u8))
                {
                    idScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizationPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesSharedAccessKey> array = new List<DeviceProvisioningServicesSharedAccessKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesSharedAccessKey.DeserializeDeviceProvisioningServicesSharedAccessKey(item, options));
                    }
                    authorizationPolicies = array;
                    continue;
                }
                if (property.NameEquals("enableDataResidency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDataResidency = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeviceProvisioningServiceProperties(Optional.ToNullable(state), Optional.ToNullable(publicNetworkAccess), Optional.ToList(ipFilterRules), Optional.ToList(privateEndpointConnections), provisioningState.Value, Optional.ToList(iotHubs), Optional.ToNullable(allocationPolicy), serviceOperationsHostName.Value, deviceProvisioningHostName.Value, idScope.Value, Optional.ToList(authorizationPolicies), Optional.ToNullable(enableDataResidency), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceProvisioningServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceProvisioningServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        DeviceProvisioningServiceProperties IPersistableModel<DeviceProvisioningServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceProvisioningServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceProvisioningServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceProvisioningServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
