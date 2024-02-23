// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SensitivityLabelUpdateList : IUtf8JsonSerializable, IJsonModel<SensitivityLabelUpdateList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SensitivityLabelUpdateList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SensitivityLabelUpdateList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelUpdateList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivityLabelUpdateList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Operations is ChangeTrackingList<SensitivityLabelUpdate> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("operations"u8);
                writer.WriteStartArray();
                foreach (var item in Operations)
                {
                    writer.WriteObjectValue(item);
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

        SensitivityLabelUpdateList IJsonModel<SensitivityLabelUpdateList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelUpdateList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivityLabelUpdateList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSensitivityLabelUpdateList(document.RootElement, options);
        }

        internal static SensitivityLabelUpdateList DeserializeSensitivityLabelUpdateList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<SensitivityLabelUpdate>> operations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SensitivityLabelUpdate> array = new List<SensitivityLabelUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SensitivityLabelUpdate.DeserializeSensitivityLabelUpdate(item, options));
                    }
                    operations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SensitivityLabelUpdateList(Optional.ToList(operations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SensitivityLabelUpdateList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelUpdateList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SensitivityLabelUpdateList)} does not support '{options.Format}' format.");
            }
        }

        SensitivityLabelUpdateList IPersistableModel<SensitivityLabelUpdateList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelUpdateList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSensitivityLabelUpdateList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SensitivityLabelUpdateList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SensitivityLabelUpdateList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
