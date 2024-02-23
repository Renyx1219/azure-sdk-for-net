// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ScaleInPolicy : IUtf8JsonSerializable, IJsonModel<ScaleInPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScaleInPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScaleInPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScaleInPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScaleInPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Rules is ChangeTrackingList<VirtualMachineScaleSetScaleInRule> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (ForceDeletion.HasValue)
            {
                writer.WritePropertyName("forceDeletion"u8);
                writer.WriteBooleanValue(ForceDeletion.Value);
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

        ScaleInPolicy IJsonModel<ScaleInPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScaleInPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScaleInPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScaleInPolicy(document.RootElement, options);
        }

        internal static ScaleInPolicy DeserializeScaleInPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<VirtualMachineScaleSetScaleInRule>> rules = default;
            Optional<bool> forceDeletion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineScaleSetScaleInRule> array = new List<VirtualMachineScaleSetScaleInRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VirtualMachineScaleSetScaleInRule(item.GetString()));
                    }
                    rules = array;
                    continue;
                }
                if (property.NameEquals("forceDeletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceDeletion = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScaleInPolicy(Optional.ToList(rules), Optional.ToNullable(forceDeletion), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScaleInPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScaleInPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScaleInPolicy)} does not support '{options.Format}' format.");
            }
        }

        ScaleInPolicy IPersistableModel<ScaleInPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScaleInPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScaleInPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScaleInPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScaleInPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
