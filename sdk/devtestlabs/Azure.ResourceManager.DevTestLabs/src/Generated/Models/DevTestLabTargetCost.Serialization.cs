// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabTargetCost : IUtf8JsonSerializable, IJsonModel<DevTestLabTargetCost>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabTargetCost>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabTargetCost>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabTargetCost>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabTargetCost)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Target.HasValue)
            {
                writer.WritePropertyName("target"u8);
                writer.WriteNumberValue(Target.Value);
            }
            if (!(CostThresholds is ChangeTrackingList<DevTestLabCostThreshold> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("costThresholds"u8);
                writer.WriteStartArray();
                foreach (var item in CostThresholds)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (CycleStartOn.HasValue)
            {
                writer.WritePropertyName("cycleStartDateTime"u8);
                writer.WriteStringValue(CycleStartOn.Value, "O");
            }
            if (CycleEndOn.HasValue)
            {
                writer.WritePropertyName("cycleEndDateTime"u8);
                writer.WriteStringValue(CycleEndOn.Value, "O");
            }
            if (CycleType.HasValue)
            {
                writer.WritePropertyName("cycleType"u8);
                writer.WriteStringValue(CycleType.Value.ToString());
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

        DevTestLabTargetCost IJsonModel<DevTestLabTargetCost>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabTargetCost>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabTargetCost)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabTargetCost(document.RootElement, options);
        }

        internal static DevTestLabTargetCost DeserializeDevTestLabTargetCost(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DevTestLabTargetCostStatus> status = default;
            Optional<int> target = default;
            Optional<IList<DevTestLabCostThreshold>> costThresholds = default;
            Optional<DateTimeOffset> cycleStartDateTime = default;
            Optional<DateTimeOffset> cycleEndDateTime = default;
            Optional<DevTestLabReportingCycleType> cycleType = default;
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
                    status = new DevTestLabTargetCostStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("costThresholds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabCostThreshold> array = new List<DevTestLabCostThreshold>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabCostThreshold.DeserializeDevTestLabCostThreshold(item, options));
                    }
                    costThresholds = array;
                    continue;
                }
                if (property.NameEquals("cycleStartDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cycleStartDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cycleEndDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cycleEndDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cycleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cycleType = new DevTestLabReportingCycleType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabTargetCost(Optional.ToNullable(status), Optional.ToNullable(target), Optional.ToList(costThresholds), Optional.ToNullable(cycleStartDateTime), Optional.ToNullable(cycleEndDateTime), Optional.ToNullable(cycleType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabTargetCost>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabTargetCost>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabTargetCost)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabTargetCost IPersistableModel<DevTestLabTargetCost>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabTargetCost>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabTargetCost(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabTargetCost)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabTargetCost>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
