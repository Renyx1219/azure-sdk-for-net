// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class TopologySingleResource : IUtf8JsonSerializable, IJsonModel<TopologySingleResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TopologySingleResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TopologySingleResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopologySingleResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopologySingleResource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Severity != null)
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity);
            }
            if (options.Format != "W" && RecommendationsExist.HasValue)
            {
                writer.WritePropertyName("recommendationsExist"u8);
                writer.WriteBooleanValue(RecommendationsExist.Value);
            }
            if (options.Format != "W" && NetworkZones != null)
            {
                writer.WritePropertyName("networkZones"u8);
                writer.WriteStringValue(NetworkZones);
            }
            if (options.Format != "W" && TopologyScore.HasValue)
            {
                writer.WritePropertyName("topologyScore"u8);
                writer.WriteNumberValue(TopologyScore.Value);
            }
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && !(Parents is ChangeTrackingList<TopologySingleResourceParent> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parents"u8);
                writer.WriteStartArray();
                foreach (var item in Parents)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Children is ChangeTrackingList<TopologySingleResourceChild> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("children"u8);
                writer.WriteStartArray();
                foreach (var item in Children)
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

        TopologySingleResource IJsonModel<TopologySingleResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopologySingleResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopologySingleResource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTopologySingleResource(document.RootElement, options);
        }

        internal static TopologySingleResource DeserializeTopologySingleResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> severity = default;
            Optional<bool> recommendationsExist = default;
            Optional<string> networkZones = default;
            Optional<int> topologyScore = default;
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyList<TopologySingleResourceParent>> parents = default;
            Optional<IReadOnlyList<TopologySingleResourceChild>> children = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendationsExist"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendationsExist = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("networkZones"u8))
                {
                    networkZones = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topologyScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topologyScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TopologySingleResourceParent> array = new List<TopologySingleResourceParent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologySingleResourceParent.DeserializeTopologySingleResourceParent(item, options));
                    }
                    parents = array;
                    continue;
                }
                if (property.NameEquals("children"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TopologySingleResourceChild> array = new List<TopologySingleResourceChild>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologySingleResourceChild.DeserializeTopologySingleResourceChild(item, options));
                    }
                    children = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TopologySingleResource(resourceId.Value, severity.Value, Optional.ToNullable(recommendationsExist), networkZones.Value, Optional.ToNullable(topologyScore), Optional.ToNullable(location), Optional.ToList(parents), Optional.ToList(children), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TopologySingleResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopologySingleResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TopologySingleResource)} does not support '{options.Format}' format.");
            }
        }

        TopologySingleResource IPersistableModel<TopologySingleResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopologySingleResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTopologySingleResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TopologySingleResource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TopologySingleResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
