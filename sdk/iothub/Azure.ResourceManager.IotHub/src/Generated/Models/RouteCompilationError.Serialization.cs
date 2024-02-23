// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RouteCompilationError : IUtf8JsonSerializable, IJsonModel<RouteCompilationError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouteCompilationError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RouteCompilationError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteCompilationError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouteCompilationError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Severity.HasValue)
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Location != null)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteObjectValue(Location);
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

        RouteCompilationError IJsonModel<RouteCompilationError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteCompilationError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouteCompilationError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouteCompilationError(document.RootElement, options);
        }

        internal static RouteCompilationError DeserializeRouteCompilationError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> message = default;
            Optional<RouteErrorSeverity> severity = default;
            Optional<RouteErrorRange> location = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new RouteErrorSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = RouteErrorRange.DeserializeRouteErrorRange(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouteCompilationError(message.Value, Optional.ToNullable(severity), location.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouteCompilationError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteCompilationError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RouteCompilationError)} does not support '{options.Format}' format.");
            }
        }

        RouteCompilationError IPersistableModel<RouteCompilationError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteCompilationError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouteCompilationError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RouteCompilationError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouteCompilationError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
