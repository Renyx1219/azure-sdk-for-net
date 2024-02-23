// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DelimitedTextDataset : IUtf8JsonSerializable, IJsonModel<DelimitedTextDataset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DelimitedTextDataset>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DelimitedTextDataset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextDataset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DelimitedTextDataset)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetType);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Structure != null)
            {
                writer.WritePropertyName("structure"u8);
                JsonSerializer.Serialize(writer, Structure);
            }
            if (Schema != null)
            {
                writer.WritePropertyName("schema"u8);
                JsonSerializer.Serialize(writer, Schema);
            }
            writer.WritePropertyName("linkedServiceName"u8);
            JsonSerializer.Serialize(writer, LinkedServiceName);
            if (!(Parameters is ChangeTrackingDictionary<string, EntityParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Folder != null)
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (DataLocation != null)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteObjectValue(DataLocation);
            }
            if (ColumnDelimiter != null)
            {
                writer.WritePropertyName("columnDelimiter"u8);
                JsonSerializer.Serialize(writer, ColumnDelimiter);
            }
            if (RowDelimiter != null)
            {
                writer.WritePropertyName("rowDelimiter"u8);
                JsonSerializer.Serialize(writer, RowDelimiter);
            }
            if (EncodingName != null)
            {
                writer.WritePropertyName("encodingName"u8);
                JsonSerializer.Serialize(writer, EncodingName);
            }
            if (CompressionCodec != null)
            {
                writer.WritePropertyName("compressionCodec"u8);
                JsonSerializer.Serialize(writer, CompressionCodec);
            }
            if (CompressionLevel != null)
            {
                writer.WritePropertyName("compressionLevel"u8);
                JsonSerializer.Serialize(writer, CompressionLevel);
            }
            if (QuoteChar != null)
            {
                writer.WritePropertyName("quoteChar"u8);
                JsonSerializer.Serialize(writer, QuoteChar);
            }
            if (EscapeChar != null)
            {
                writer.WritePropertyName("escapeChar"u8);
                JsonSerializer.Serialize(writer, EscapeChar);
            }
            if (FirstRowAsHeader != null)
            {
                writer.WritePropertyName("firstRowAsHeader"u8);
                JsonSerializer.Serialize(writer, FirstRowAsHeader);
            }
            if (NullValue != null)
            {
                writer.WritePropertyName("nullValue"u8);
                JsonSerializer.Serialize(writer, NullValue);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DelimitedTextDataset IJsonModel<DelimitedTextDataset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextDataset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DelimitedTextDataset)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDelimitedTextDataset(document.RootElement, options);
        }

        internal static DelimitedTextDataset DeserializeDelimitedTextDataset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryElement<IList<DatasetDataElement>>> structure = default;
            Optional<DataFactoryElement<IList<DatasetSchemaDataElement>>> schema = default;
            DataFactoryLinkedServiceReference linkedServiceName = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<DatasetFolder> folder = default;
            Optional<DatasetLocation> location = default;
            Optional<DataFactoryElement<string>> columnDelimiter = default;
            Optional<DataFactoryElement<string>> rowDelimiter = default;
            Optional<DataFactoryElement<string>> encodingName = default;
            Optional<DataFactoryElement<string>> compressionCodec = default;
            Optional<DataFactoryElement<string>> compressionLevel = default;
            Optional<DataFactoryElement<string>> quoteChar = default;
            Optional<DataFactoryElement<string>> escapeChar = default;
            Optional<DataFactoryElement<bool>> firstRowAsHeader = default;
            Optional<DataFactoryElement<string>> nullValue = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    structure = JsonSerializer.Deserialize<DataFactoryElement<IList<DatasetDataElement>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = JsonSerializer.Deserialize<DataFactoryElement<IList<DatasetSchemaDataElement>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value, options);
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("location"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            location = DatasetLocation.DeserializeDatasetLocation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("columnDelimiter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            columnDelimiter = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("rowDelimiter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rowDelimiter = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encodingName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encodingName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("compressionCodec"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compressionCodec = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("compressionLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compressionLevel = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("quoteChar"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quoteChar = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("escapeChar"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            escapeChar = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("firstRowAsHeader"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firstRowAsHeader = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("nullValue"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nullValue = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextDataset(type, description.Value, structure.Value, schema.Value, linkedServiceName, Optional.ToDictionary(parameters), Optional.ToList(annotations), folder.Value, additionalProperties, location.Value, columnDelimiter.Value, rowDelimiter.Value, encodingName.Value, compressionCodec.Value, compressionLevel.Value, quoteChar.Value, escapeChar.Value, firstRowAsHeader.Value, nullValue.Value);
        }

        BinaryData IPersistableModel<DelimitedTextDataset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextDataset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DelimitedTextDataset)} does not support '{options.Format}' format.");
            }
        }

        DelimitedTextDataset IPersistableModel<DelimitedTextDataset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextDataset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDelimitedTextDataset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DelimitedTextDataset)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DelimitedTextDataset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
