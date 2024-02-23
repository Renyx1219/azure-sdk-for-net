// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaTrackSelection : IUtf8JsonSerializable, IJsonModel<MediaTrackSelection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaTrackSelection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaTrackSelection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaTrackSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaTrackSelection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(TrackSelections is ChangeTrackingList<TrackPropertyCondition> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("trackSelections"u8);
                writer.WriteStartArray();
                foreach (var item in TrackSelections)
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

        MediaTrackSelection IJsonModel<MediaTrackSelection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaTrackSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaTrackSelection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaTrackSelection(document.RootElement, options);
        }

        internal static MediaTrackSelection DeserializeMediaTrackSelection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<TrackPropertyCondition>> trackSelections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackSelections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TrackPropertyCondition> array = new List<TrackPropertyCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrackPropertyCondition.DeserializeTrackPropertyCondition(item, options));
                    }
                    trackSelections = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaTrackSelection(Optional.ToList(trackSelections), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaTrackSelection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaTrackSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaTrackSelection)} does not support '{options.Format}' format.");
            }
        }

        MediaTrackSelection IPersistableModel<MediaTrackSelection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaTrackSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaTrackSelection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaTrackSelection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaTrackSelection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
