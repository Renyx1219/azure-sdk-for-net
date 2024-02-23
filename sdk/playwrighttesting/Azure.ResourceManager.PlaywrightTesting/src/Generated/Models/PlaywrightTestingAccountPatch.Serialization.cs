// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PlaywrightTesting.Models
{
    public partial class PlaywrightTestingAccountPatch : IUtf8JsonSerializable, IJsonModel<PlaywrightTestingAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlaywrightTestingAccountPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PlaywrightTestingAccountPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightTestingAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlaywrightTestingAccountPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (RegionalAffinity.HasValue)
            {
                writer.WritePropertyName("regionalAffinity"u8);
                writer.WriteStringValue(RegionalAffinity.Value.ToString());
            }
            if (ScalableExecution.HasValue)
            {
                writer.WritePropertyName("scalableExecution"u8);
                writer.WriteStringValue(ScalableExecution.Value.ToString());
            }
            if (Reporting.HasValue)
            {
                writer.WritePropertyName("reporting"u8);
                writer.WriteStringValue(Reporting.Value.ToString());
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

        PlaywrightTestingAccountPatch IJsonModel<PlaywrightTestingAccountPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightTestingAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlaywrightTestingAccountPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlaywrightTestingAccountPatch(document.RootElement, options);
        }

        internal static PlaywrightTestingAccountPatch DeserializePlaywrightTestingAccountPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<EnablementStatus> regionalAffinity = default;
            Optional<EnablementStatus> scalableExecution = default;
            Optional<EnablementStatus> reporting = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
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
                        if (property0.NameEquals("regionalAffinity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            regionalAffinity = new EnablementStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scalableExecution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scalableExecution = new EnablementStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reporting"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reporting = new EnablementStatus(property0.Value.GetString());
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
            return new PlaywrightTestingAccountPatch(Optional.ToDictionary(tags), Optional.ToNullable(regionalAffinity), Optional.ToNullable(scalableExecution), Optional.ToNullable(reporting), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PlaywrightTestingAccountPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightTestingAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PlaywrightTestingAccountPatch)} does not support '{options.Format}' format.");
            }
        }

        PlaywrightTestingAccountPatch IPersistableModel<PlaywrightTestingAccountPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightTestingAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePlaywrightTestingAccountPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlaywrightTestingAccountPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlaywrightTestingAccountPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
