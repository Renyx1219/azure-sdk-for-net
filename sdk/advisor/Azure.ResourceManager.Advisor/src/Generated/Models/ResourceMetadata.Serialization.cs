// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Advisor.Models
{
    public partial class ResourceMetadata : IUtf8JsonSerializable, IJsonModel<ResourceMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (!(Action is ChangeTrackingDictionary<string, BinaryData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStartObject();
                foreach (var item in Action)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
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
            if (Singular != null)
            {
                writer.WritePropertyName("singular"u8);
                writer.WriteStringValue(Singular);
            }
            if (Plural != null)
            {
                writer.WritePropertyName("plural"u8);
                writer.WriteStringValue(Plural);
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

        ResourceMetadata IJsonModel<ResourceMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceMetadata(document.RootElement, options);
        }

        internal static ResourceMetadata DeserializeResourceMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceId = default;
            Optional<string> source = default;
            Optional<IDictionary<string, BinaryData>> action = default;
            Optional<string> singular = default;
            Optional<string> plural = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    action = dictionary;
                    continue;
                }
                if (property.NameEquals("singular"u8))
                {
                    singular = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("plural"u8))
                {
                    plural = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceMetadata(resourceId.Value, source.Value, Optional.ToDictionary(action), singular.Value, plural.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceMetadata)} does not support '{options.Format}' format.");
            }
        }

        ResourceMetadata IPersistableModel<ResourceMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
