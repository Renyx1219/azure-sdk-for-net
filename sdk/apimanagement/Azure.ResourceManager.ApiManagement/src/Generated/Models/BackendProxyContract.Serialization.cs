// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class BackendProxyContract : IUtf8JsonSerializable, IJsonModel<BackendProxyContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackendProxyContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackendProxyContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendProxyContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendProxyContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Username != null)
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
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

        BackendProxyContract IJsonModel<BackendProxyContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendProxyContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendProxyContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendProxyContract(document.RootElement, options);
        }

        internal static BackendProxyContract DeserializeBackendProxyContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri uri = default;
            Optional<string> username = default;
            Optional<string> password = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackendProxyContract(uri, username.Value, password.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackendProxyContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendProxyContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackendProxyContract)} does not support '{options.Format}' format.");
            }
        }

        BackendProxyContract IPersistableModel<BackendProxyContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendProxyContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackendProxyContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackendProxyContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackendProxyContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
