// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterApiServerAccessProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterApiServerAccessProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterApiServerAccessProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterApiServerAccessProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterApiServerAccessProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterApiServerAccessProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(AuthorizedIPRanges is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("authorizedIPRanges"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (EnablePrivateCluster.HasValue)
            {
                writer.WritePropertyName("enablePrivateCluster"u8);
                writer.WriteBooleanValue(EnablePrivateCluster.Value);
            }
            if (PrivateDnsZone != null)
            {
                writer.WritePropertyName("privateDNSZone"u8);
                writer.WriteStringValue(PrivateDnsZone);
            }
            if (EnablePrivateClusterPublicFqdn.HasValue)
            {
                writer.WritePropertyName("enablePrivateClusterPublicFQDN"u8);
                writer.WriteBooleanValue(EnablePrivateClusterPublicFqdn.Value);
            }
            if (DisableRunCommand.HasValue)
            {
                writer.WritePropertyName("disableRunCommand"u8);
                writer.WriteBooleanValue(DisableRunCommand.Value);
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

        ManagedClusterApiServerAccessProfile IJsonModel<ManagedClusterApiServerAccessProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterApiServerAccessProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterApiServerAccessProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterApiServerAccessProfile(document.RootElement, options);
        }

        internal static ManagedClusterApiServerAccessProfile DeserializeManagedClusterApiServerAccessProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> authorizedIPRanges = default;
            Optional<bool> enablePrivateCluster = default;
            Optional<string> privateDnsZone = default;
            Optional<bool> enablePrivateClusterPublicFQDN = default;
            Optional<bool> disableRunCommand = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizedIPRanges"u8))
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
                    authorizedIPRanges = array;
                    continue;
                }
                if (property.NameEquals("enablePrivateCluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePrivateCluster = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("privateDNSZone"u8))
                {
                    privateDnsZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enablePrivateClusterPublicFQDN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePrivateClusterPublicFQDN = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableRunCommand"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableRunCommand = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterApiServerAccessProfile(Optional.ToList(authorizedIPRanges), Optional.ToNullable(enablePrivateCluster), privateDnsZone.Value, Optional.ToNullable(enablePrivateClusterPublicFQDN), Optional.ToNullable(disableRunCommand), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterApiServerAccessProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterApiServerAccessProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterApiServerAccessProfile)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterApiServerAccessProfile IPersistableModel<ManagedClusterApiServerAccessProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterApiServerAccessProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterApiServerAccessProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterApiServerAccessProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterApiServerAccessProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
