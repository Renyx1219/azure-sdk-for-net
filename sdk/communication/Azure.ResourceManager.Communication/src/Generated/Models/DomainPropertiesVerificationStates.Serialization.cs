// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    public partial class DomainPropertiesVerificationStates : IUtf8JsonSerializable, IJsonModel<DomainPropertiesVerificationStates>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DomainPropertiesVerificationStates>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DomainPropertiesVerificationStates>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainPropertiesVerificationStates>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainPropertiesVerificationStates)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Domain != null)
            {
                writer.WritePropertyName("Domain"u8);
                writer.WriteObjectValue(Domain);
            }
            if (Spf != null)
            {
                writer.WritePropertyName("SPF"u8);
                writer.WriteObjectValue(Spf);
            }
            if (Dkim != null)
            {
                writer.WritePropertyName("DKIM"u8);
                writer.WriteObjectValue(Dkim);
            }
            if (Dkim2 != null)
            {
                writer.WritePropertyName("DKIM2"u8);
                writer.WriteObjectValue(Dkim2);
            }
            if (Dmarc != null)
            {
                writer.WritePropertyName("DMARC"u8);
                writer.WriteObjectValue(Dmarc);
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

        DomainPropertiesVerificationStates IJsonModel<DomainPropertiesVerificationStates>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainPropertiesVerificationStates>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainPropertiesVerificationStates)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainPropertiesVerificationStates(document.RootElement, options);
        }

        internal static DomainPropertiesVerificationStates DeserializeDomainPropertiesVerificationStates(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DomainVerificationStatusRecord> domain = default;
            Optional<DomainVerificationStatusRecord> spf = default;
            Optional<DomainVerificationStatusRecord> dkim = default;
            Optional<DomainVerificationStatusRecord> dkiM2 = default;
            Optional<DomainVerificationStatusRecord> dmarc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Domain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domain = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value, options);
                    continue;
                }
                if (property.NameEquals("SPF"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spf = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value, options);
                    continue;
                }
                if (property.NameEquals("DKIM"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dkim = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value, options);
                    continue;
                }
                if (property.NameEquals("DKIM2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dkiM2 = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value, options);
                    continue;
                }
                if (property.NameEquals("DMARC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dmarc = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DomainPropertiesVerificationStates(domain.Value, spf.Value, dkim.Value, dkiM2.Value, dmarc.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DomainPropertiesVerificationStates>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainPropertiesVerificationStates>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DomainPropertiesVerificationStates)} does not support '{options.Format}' format.");
            }
        }

        DomainPropertiesVerificationStates IPersistableModel<DomainPropertiesVerificationStates>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainPropertiesVerificationStates>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDomainPropertiesVerificationStates(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DomainPropertiesVerificationStates)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DomainPropertiesVerificationStates>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
