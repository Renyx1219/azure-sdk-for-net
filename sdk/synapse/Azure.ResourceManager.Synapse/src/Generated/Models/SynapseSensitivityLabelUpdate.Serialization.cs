// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSensitivityLabelUpdate : IUtf8JsonSerializable, IJsonModel<SynapseSensitivityLabelUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSensitivityLabelUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSensitivityLabelUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSensitivityLabelUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSensitivityLabelUpdate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Op.HasValue)
            {
                writer.WritePropertyName("op"u8);
                writer.WriteStringValue(Op.Value.ToSerialString());
            }
            if (Schema != null)
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteStringValue(Schema);
            }
            if (Table != null)
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(Table);
            }
            if (Column != null)
            {
                writer.WritePropertyName("column"u8);
                writer.WriteStringValue(Column);
            }
            if (SensitivityLabel != null)
            {
                writer.WritePropertyName("sensitivityLabel"u8);
                writer.WriteObjectValue(SensitivityLabel);
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

        SynapseSensitivityLabelUpdate IJsonModel<SynapseSensitivityLabelUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSensitivityLabelUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSensitivityLabelUpdate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSensitivityLabelUpdate(document.RootElement, options);
        }

        internal static SynapseSensitivityLabelUpdate DeserializeSynapseSensitivityLabelUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SynapseSensitivityLabelUpdateKind> op = default;
            Optional<string> schema = default;
            Optional<string> table = default;
            Optional<string> column = default;
            Optional<SynapseSensitivityLabelData> sensitivityLabel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("op"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            op = property0.Value.GetString().ToSynapseSensitivityLabelUpdateKind();
                            continue;
                        }
                        if (property0.NameEquals("schema"u8))
                        {
                            schema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("table"u8))
                        {
                            table = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("column"u8))
                        {
                            column = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sensitivityLabel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sensitivityLabel = SynapseSensitivityLabelData.DeserializeSynapseSensitivityLabelData(property0.Value, options);
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
            return new SynapseSensitivityLabelUpdate(id, name, type, systemData.Value, Optional.ToNullable(op), schema.Value, table.Value, column.Value, sensitivityLabel.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseSensitivityLabelUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSensitivityLabelUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSensitivityLabelUpdate)} does not support '{options.Format}' format.");
            }
        }

        SynapseSensitivityLabelUpdate IPersistableModel<SynapseSensitivityLabelUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSensitivityLabelUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSensitivityLabelUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSensitivityLabelUpdate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSensitivityLabelUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
