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
    public partial class FilteringOperations : IUtf8JsonSerializable, IJsonModel<FilteringOperations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FilteringOperations>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FilteringOperations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilteringOperations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FilteringOperations)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Deinterlace != null)
            {
                writer.WritePropertyName("deinterlace"u8);
                writer.WriteObjectValue(Deinterlace);
            }
            if (Rotation.HasValue)
            {
                writer.WritePropertyName("rotation"u8);
                writer.WriteStringValue(Rotation.Value.ToString());
            }
            if (Crop != null)
            {
                writer.WritePropertyName("crop"u8);
                writer.WriteObjectValue(Crop);
            }
            if (FadeIn != null)
            {
                writer.WritePropertyName("fadeIn"u8);
                writer.WriteObjectValue(FadeIn);
            }
            if (FadeOut != null)
            {
                writer.WritePropertyName("fadeOut"u8);
                writer.WriteObjectValue(FadeOut);
            }
            if (!(Overlays is ChangeTrackingList<MediaOverlayBase> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("overlays"u8);
                writer.WriteStartArray();
                foreach (var item in Overlays)
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

        FilteringOperations IJsonModel<FilteringOperations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilteringOperations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FilteringOperations)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFilteringOperations(document.RootElement, options);
        }

        internal static FilteringOperations DeserializeFilteringOperations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DeinterlaceSettings> deinterlace = default;
            Optional<RotationSetting> rotation = default;
            Optional<RectangularWindow> crop = default;
            Optional<FadeOptions> fadeIn = default;
            Optional<FadeOptions> fadeOut = default;
            Optional<IList<MediaOverlayBase>> overlays = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deinterlace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deinterlace = DeinterlaceSettings.DeserializeDeinterlaceSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rotation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rotation = new RotationSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("crop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crop = RectangularWindow.DeserializeRectangularWindow(property.Value, options);
                    continue;
                }
                if (property.NameEquals("fadeIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeIn = FadeOptions.DeserializeFadeOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("fadeOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeOut = FadeOptions.DeserializeFadeOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("overlays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaOverlayBase> array = new List<MediaOverlayBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaOverlayBase.DeserializeMediaOverlayBase(item, options));
                    }
                    overlays = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FilteringOperations(deinterlace.Value, Optional.ToNullable(rotation), crop.Value, fadeIn.Value, fadeOut.Value, Optional.ToList(overlays), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FilteringOperations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilteringOperations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FilteringOperations)} does not support '{options.Format}' format.");
            }
        }

        FilteringOperations IPersistableModel<FilteringOperations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilteringOperations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFilteringOperations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FilteringOperations)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FilteringOperations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
