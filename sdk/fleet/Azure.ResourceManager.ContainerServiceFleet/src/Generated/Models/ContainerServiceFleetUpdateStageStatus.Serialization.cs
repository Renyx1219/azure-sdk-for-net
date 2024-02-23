// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    public partial class ContainerServiceFleetUpdateStageStatus : IUtf8JsonSerializable, IJsonModel<ContainerServiceFleetUpdateStageStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceFleetUpdateStageStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceFleetUpdateStageStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateStageStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateStageStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && !(Groups is ChangeTrackingList<ContainerServiceFleetUpdateGroupStatus> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("groups"u8);
                writer.WriteStartArray();
                foreach (var item in Groups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && AfterStageWaitStatus != null)
            {
                writer.WritePropertyName("afterStageWaitStatus"u8);
                writer.WriteObjectValue(AfterStageWaitStatus);
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

        ContainerServiceFleetUpdateStageStatus IJsonModel<ContainerServiceFleetUpdateStageStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateStageStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateStageStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceFleetUpdateStageStatus(document.RootElement, options);
        }

        internal static ContainerServiceFleetUpdateStageStatus DeserializeContainerServiceFleetUpdateStageStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerServiceFleetUpdateStatus> status = default;
            Optional<string> name = default;
            Optional<IReadOnlyList<ContainerServiceFleetUpdateGroupStatus>> groups = default;
            Optional<ContainerServiceFleetWaitStatus> afterStageWaitStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ContainerServiceFleetUpdateStatus.DeserializeContainerServiceFleetUpdateStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceFleetUpdateGroupStatus> array = new List<ContainerServiceFleetUpdateGroupStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceFleetUpdateGroupStatus.DeserializeContainerServiceFleetUpdateGroupStatus(item, options));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("afterStageWaitStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    afterStageWaitStatus = ContainerServiceFleetWaitStatus.DeserializeContainerServiceFleetWaitStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceFleetUpdateStageStatus(status.Value, name.Value, Optional.ToList(groups), afterStageWaitStatus.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceFleetUpdateStageStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateStageStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateStageStatus)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceFleetUpdateStageStatus IPersistableModel<ContainerServiceFleetUpdateStageStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateStageStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceFleetUpdateStageStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateStageStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceFleetUpdateStageStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
