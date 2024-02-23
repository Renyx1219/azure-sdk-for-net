// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class NetworkInterfaces : IUtf8JsonSerializable, IJsonModel<NetworkInterfaces>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaces>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkInterfaces>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaces>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaces)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && !(IPv4Addresses is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ipv4Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4Addresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(IPv6Addresses is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("ipv6Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6Addresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (MacAddress != null)
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
            }
            if (VirtualNetworkId != null)
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                writer.WriteStringValue(VirtualNetworkId);
            }
            if (options.Format != "W" && NetworkName != null)
            {
                writer.WritePropertyName("networkName"u8);
                writer.WriteStringValue(NetworkName);
            }
            if (IPv4AddressType.HasValue)
            {
                writer.WritePropertyName("ipv4AddressType"u8);
                writer.WriteStringValue(IPv4AddressType.Value.ToString());
            }
            if (IPv6AddressType.HasValue)
            {
                writer.WritePropertyName("ipv6AddressType"u8);
                writer.WriteStringValue(IPv6AddressType.Value.ToString());
            }
            if (MacAddressType.HasValue)
            {
                writer.WritePropertyName("macAddressType"u8);
                writer.WriteStringValue(MacAddressType.Value.ToString());
            }
            if (NicId != null)
            {
                writer.WritePropertyName("nicId"u8);
                writer.WriteStringValue(NicId);
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

        NetworkInterfaces IJsonModel<NetworkInterfaces>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaces>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaces)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaces(document.RootElement, options);
        }

        internal static NetworkInterfaces DeserializeNetworkInterfaces(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyList<string>> ipv4Addresses = default;
            Optional<IReadOnlyList<string>> ipv6Addresses = default;
            Optional<string> macAddress = default;
            Optional<string> virtualNetworkId = default;
            Optional<string> networkName = default;
            Optional<AllocationMethod> ipv4AddressType = default;
            Optional<AllocationMethod> ipv6AddressType = default;
            Optional<AllocationMethod> macAddressType = default;
            Optional<string> nicId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Addresses"u8))
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
                    ipv4Addresses = array;
                    continue;
                }
                if (property.NameEquals("ipv6Addresses"u8))
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
                    ipv6Addresses = array;
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualNetworkId"u8))
                {
                    virtualNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkName"u8))
                {
                    networkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4AddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv4AddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipv6AddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv6AddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("macAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    macAddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkInterfaces(name.Value, displayName.Value, Optional.ToList(ipv4Addresses), Optional.ToList(ipv6Addresses), macAddress.Value, virtualNetworkId.Value, networkName.Value, Optional.ToNullable(ipv4AddressType), Optional.ToNullable(ipv6AddressType), Optional.ToNullable(macAddressType), nicId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkInterfaces>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaces>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaces)} does not support '{options.Format}' format.");
            }
        }

        NetworkInterfaces IPersistableModel<NetworkInterfaces>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaces>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkInterfaces(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaces)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkInterfaces>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
