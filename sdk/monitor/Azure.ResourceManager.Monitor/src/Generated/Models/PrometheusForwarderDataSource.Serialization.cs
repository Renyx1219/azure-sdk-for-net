// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class PrometheusForwarderDataSource : IUtf8JsonSerializable, IJsonModel<PrometheusForwarderDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrometheusForwarderDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrometheusForwarderDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrometheusForwarderDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrometheusForwarderDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Streams is ChangeTrackingList<DataCollectionRuleKnownPrometheusForwarderDataSourceStream> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("streams"u8);
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(LabelIncludeFilter is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("labelIncludeFilter"u8);
                writer.WriteStartObject();
                foreach (var item in LabelIncludeFilter)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        PrometheusForwarderDataSource IJsonModel<PrometheusForwarderDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrometheusForwarderDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrometheusForwarderDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrometheusForwarderDataSource(document.RootElement, options);
        }

        internal static PrometheusForwarderDataSource DeserializePrometheusForwarderDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DataCollectionRuleKnownPrometheusForwarderDataSourceStream>> streams = default;
            Optional<IDictionary<string, string>> labelIncludeFilter = default;
            Optional<string> name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleKnownPrometheusForwarderDataSourceStream> array = new List<DataCollectionRuleKnownPrometheusForwarderDataSourceStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DataCollectionRuleKnownPrometheusForwarderDataSourceStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("labelIncludeFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labelIncludeFilter = dictionary;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrometheusForwarderDataSource(Optional.ToList(streams), Optional.ToDictionary(labelIncludeFilter), name.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrometheusForwarderDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrometheusForwarderDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrometheusForwarderDataSource)} does not support '{options.Format}' format.");
            }
        }

        PrometheusForwarderDataSource IPersistableModel<PrometheusForwarderDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrometheusForwarderDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrometheusForwarderDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrometheusForwarderDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrometheusForwarderDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
