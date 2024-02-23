// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppJwtClaimChecks : IUtf8JsonSerializable, IJsonModel<ContainerAppJwtClaimChecks>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJwtClaimChecks>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppJwtClaimChecks>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJwtClaimChecks>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJwtClaimChecks)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(AllowedGroups is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AllowedClientApplications is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("allowedClientApplications"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedClientApplications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        ContainerAppJwtClaimChecks IJsonModel<ContainerAppJwtClaimChecks>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJwtClaimChecks>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJwtClaimChecks)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJwtClaimChecks(document.RootElement, options);
        }

        internal static ContainerAppJwtClaimChecks DeserializeContainerAppJwtClaimChecks(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> allowedGroups = default;
            Optional<IList<string>> allowedClientApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedGroups"u8))
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
                    allowedGroups = array;
                    continue;
                }
                if (property.NameEquals("allowedClientApplications"u8))
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
                    allowedClientApplications = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppJwtClaimChecks(Optional.ToList(allowedGroups), Optional.ToList(allowedClientApplications), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppJwtClaimChecks>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJwtClaimChecks>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJwtClaimChecks)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppJwtClaimChecks IPersistableModel<ContainerAppJwtClaimChecks>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJwtClaimChecks>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJwtClaimChecks(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJwtClaimChecks)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJwtClaimChecks>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
