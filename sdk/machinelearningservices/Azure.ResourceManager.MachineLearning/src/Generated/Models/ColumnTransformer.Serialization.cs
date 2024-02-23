// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ColumnTransformer : IUtf8JsonSerializable, IJsonModel<ColumnTransformer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ColumnTransformer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ColumnTransformer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ColumnTransformer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ColumnTransformer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Fields is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                if (Fields != null)
                {
                    writer.WritePropertyName("fields"u8);
                    writer.WriteStartArray();
                    foreach (var item in Fields)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("fields");
                }
            }
            if (Parameters != null)
            {
                if (Parameters != null)
                {
                    writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                    using (JsonDocument document = JsonDocument.Parse(Parameters))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                else
                {
                    writer.WriteNull("parameters");
                }
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

        ColumnTransformer IJsonModel<ColumnTransformer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ColumnTransformer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ColumnTransformer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeColumnTransformer(document.RootElement, options);
        }

        internal static ColumnTransformer DeserializeColumnTransformer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> fields = default;
            Optional<BinaryData> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fields = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parameters = null;
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ColumnTransformer(Optional.ToList(fields), parameters.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ColumnTransformer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ColumnTransformer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ColumnTransformer)} does not support '{options.Format}' format.");
            }
        }

        ColumnTransformer IPersistableModel<ColumnTransformer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ColumnTransformer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeColumnTransformer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ColumnTransformer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ColumnTransformer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
