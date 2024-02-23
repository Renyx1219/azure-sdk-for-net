// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class FiltersConfiguration : IUtf8JsonSerializable, IJsonModel<FiltersConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FiltersConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FiltersConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FiltersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FiltersConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(IncludedEventTypes is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("includedEventTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedEventTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Filters is ChangeTrackingList<EventGridFilter> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
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

        FiltersConfiguration IJsonModel<FiltersConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FiltersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FiltersConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFiltersConfiguration(document.RootElement, options);
        }

        internal static FiltersConfiguration DeserializeFiltersConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> includedEventTypes = default;
            Optional<IList<EventGridFilter>> filters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includedEventTypes"u8))
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
                    includedEventTypes = array;
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventGridFilter> array = new List<EventGridFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventGridFilter.DeserializeEventGridFilter(item, options));
                    }
                    filters = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FiltersConfiguration(Optional.ToList(includedEventTypes), Optional.ToList(filters), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FiltersConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FiltersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FiltersConfiguration)} does not support '{options.Format}' format.");
            }
        }

        FiltersConfiguration IPersistableModel<FiltersConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FiltersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFiltersConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FiltersConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FiltersConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
