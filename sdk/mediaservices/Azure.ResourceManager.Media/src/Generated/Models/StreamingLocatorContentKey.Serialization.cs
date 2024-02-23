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
    public partial class StreamingLocatorContentKey : IUtf8JsonSerializable, IJsonModel<StreamingLocatorContentKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingLocatorContentKey>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingLocatorContentKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingLocatorContentKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingLocatorContentKey)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (options.Format != "W" && KeyType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(KeyType.Value.ToString());
            }
            if (LabelReferenceInStreamingPolicy != null)
            {
                writer.WritePropertyName("labelReferenceInStreamingPolicy"u8);
                writer.WriteStringValue(LabelReferenceInStreamingPolicy);
            }
            if (Value != null)
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (options.Format != "W" && PolicyName != null)
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (options.Format != "W" && !(Tracks is ChangeTrackingList<MediaTrackSelection> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tracks"u8);
                writer.WriteStartArray();
                foreach (var item in Tracks)
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

        StreamingLocatorContentKey IJsonModel<StreamingLocatorContentKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingLocatorContentKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingLocatorContentKey)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingLocatorContentKey(document.RootElement, options);
        }

        internal static StreamingLocatorContentKey DeserializeStreamingLocatorContentKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            Optional<StreamingLocatorContentKeyType> type = default;
            Optional<string> labelReferenceInStreamingPolicy = default;
            Optional<string> value = default;
            Optional<string> policyName = default;
            Optional<IReadOnlyList<MediaTrackSelection>> tracks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new StreamingLocatorContentKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labelReferenceInStreamingPolicy"u8))
                {
                    labelReferenceInStreamingPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tracks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaTrackSelection> array = new List<MediaTrackSelection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaTrackSelection.DeserializeMediaTrackSelection(item, options));
                    }
                    tracks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingLocatorContentKey(id, Optional.ToNullable(type), labelReferenceInStreamingPolicy.Value, value.Value, policyName.Value, Optional.ToList(tracks), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingLocatorContentKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingLocatorContentKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingLocatorContentKey)} does not support '{options.Format}' format.");
            }
        }

        StreamingLocatorContentKey IPersistableModel<StreamingLocatorContentKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingLocatorContentKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingLocatorContentKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingLocatorContentKey)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingLocatorContentKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
