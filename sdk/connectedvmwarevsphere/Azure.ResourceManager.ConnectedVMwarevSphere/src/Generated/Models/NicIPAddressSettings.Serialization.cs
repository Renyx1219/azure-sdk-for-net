// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class NicIPAddressSettings : IUtf8JsonSerializable, IJsonModel<NicIPAddressSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NicIPAddressSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NicIPAddressSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPAddressSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NicIPAddressSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && AllocationMethod != null)
            {
                writer.WritePropertyName("allocationMethod"u8);
                writer.WriteStringValue(AllocationMethod);
            }
            if (options.Format != "W" && IPAddress != null)
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (options.Format != "W" && SubnetMask != null)
            {
                writer.WritePropertyName("subnetMask"u8);
                writer.WriteStringValue(SubnetMask);
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

        NicIPAddressSettings IJsonModel<NicIPAddressSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPAddressSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NicIPAddressSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNicIPAddressSettings(document.RootElement, options);
        }

        internal static NicIPAddressSettings DeserializeNicIPAddressSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> allocationMethod = default;
            Optional<string> ipAddress = default;
            Optional<string> subnetMask = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocationMethod"u8))
                {
                    allocationMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetMask"u8))
                {
                    subnetMask = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NicIPAddressSettings(allocationMethod.Value, ipAddress.Value, subnetMask.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NicIPAddressSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPAddressSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NicIPAddressSettings)} does not support '{options.Format}' format.");
            }
        }

        NicIPAddressSettings IPersistableModel<NicIPAddressSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPAddressSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNicIPAddressSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NicIPAddressSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NicIPAddressSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
