// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kubernetes.Models
{
    public partial class CredentialResults : IUtf8JsonSerializable, IJsonModel<CredentialResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CredentialResults>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CredentialResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CredentialResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CredentialResults)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && HybridConnectionConfig != null)
            {
                writer.WritePropertyName("hybridConnectionConfig"u8);
                writer.WriteObjectValue(HybridConnectionConfig);
            }
            if (options.Format != "W" && !(Kubeconfigs is ChangeTrackingList<CredentialResult> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("kubeconfigs"u8);
                writer.WriteStartArray();
                foreach (var item in Kubeconfigs)
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

        CredentialResults IJsonModel<CredentialResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CredentialResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CredentialResults)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCredentialResults(document.RootElement, options);
        }

        internal static CredentialResults DeserializeCredentialResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HybridConnectionConfig> hybridConnectionConfig = default;
            Optional<IReadOnlyList<CredentialResult>> kubeconfigs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hybridConnectionConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hybridConnectionConfig = HybridConnectionConfig.DeserializeHybridConnectionConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kubeconfigs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CredentialResult> array = new List<CredentialResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CredentialResult.DeserializeCredentialResult(item, options));
                    }
                    kubeconfigs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CredentialResults(hybridConnectionConfig.Value, Optional.ToList(kubeconfigs), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CredentialResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CredentialResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CredentialResults)} does not support '{options.Format}' format.");
            }
        }

        CredentialResults IPersistableModel<CredentialResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CredentialResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCredentialResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CredentialResults)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CredentialResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
