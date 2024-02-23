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
    public partial class MachineLearningSharedPrivateLinkResource : IUtf8JsonSerializable, IJsonModel<MachineLearningSharedPrivateLinkResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSharedPrivateLinkResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningSharedPrivateLinkResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSharedPrivateLinkResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSharedPrivateLinkResource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (GroupId != null)
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (PrivateLinkResourceId != null)
            {
                writer.WritePropertyName("privateLinkResourceId"u8);
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (RequestMessage != null)
            {
                writer.WritePropertyName("requestMessage"u8);
                writer.WriteStringValue(RequestMessage);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        MachineLearningSharedPrivateLinkResource IJsonModel<MachineLearningSharedPrivateLinkResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSharedPrivateLinkResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSharedPrivateLinkResource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSharedPrivateLinkResource(document.RootElement, options);
        }

        internal static MachineLearningSharedPrivateLinkResource DeserializeMachineLearningSharedPrivateLinkResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> groupId = default;
            Optional<ResourceIdentifier> privateLinkResourceId = default;
            Optional<string> requestMessage = default;
            Optional<MachineLearningPrivateEndpointServiceConnectionStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("groupId"u8))
                        {
                            groupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestMessage"u8))
                        {
                            requestMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new MachineLearningPrivateEndpointServiceConnectionStatus(property0.Value.GetString());
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
            return new MachineLearningSharedPrivateLinkResource(name.Value, groupId.Value, privateLinkResourceId.Value, requestMessage.Value, Optional.ToNullable(status), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningSharedPrivateLinkResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSharedPrivateLinkResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSharedPrivateLinkResource)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningSharedPrivateLinkResource IPersistableModel<MachineLearningSharedPrivateLinkResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSharedPrivateLinkResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningSharedPrivateLinkResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSharedPrivateLinkResource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSharedPrivateLinkResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
