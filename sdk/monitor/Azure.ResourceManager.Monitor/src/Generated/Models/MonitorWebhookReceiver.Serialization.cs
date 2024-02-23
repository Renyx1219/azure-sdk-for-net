// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorWebhookReceiver : IUtf8JsonSerializable, IJsonModel<MonitorWebhookReceiver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorWebhookReceiver>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorWebhookReceiver>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWebhookReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWebhookReceiver)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("serviceUri"u8);
            writer.WriteStringValue(ServiceUri.AbsoluteUri);
            if (UseCommonAlertSchema.HasValue)
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            if (UseAadAuth.HasValue)
            {
                writer.WritePropertyName("useAadAuth"u8);
                writer.WriteBooleanValue(UseAadAuth.Value);
            }
            if (ObjectId != null)
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId);
            }
            if (IdentifierUri != null)
            {
                writer.WritePropertyName("identifierUri"u8);
                writer.WriteStringValue(IdentifierUri.AbsoluteUri);
            }
            if (TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
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

        MonitorWebhookReceiver IJsonModel<MonitorWebhookReceiver>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWebhookReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWebhookReceiver)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorWebhookReceiver(document.RootElement, options);
        }

        internal static MonitorWebhookReceiver DeserializeMonitorWebhookReceiver(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Uri serviceUri = default;
            Optional<bool> useCommonAlertSchema = default;
            Optional<bool> useAadAuth = default;
            Optional<string> objectId = default;
            Optional<Uri> identifierUri = default;
            Optional<Guid> tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUri"u8))
                {
                    serviceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("useAadAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useAadAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identifierUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identifierUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorWebhookReceiver(name, serviceUri, Optional.ToNullable(useCommonAlertSchema), Optional.ToNullable(useAadAuth), objectId.Value, identifierUri.Value, Optional.ToNullable(tenantId), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorWebhookReceiver>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWebhookReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorWebhookReceiver)} does not support '{options.Format}' format.");
            }
        }

        MonitorWebhookReceiver IPersistableModel<MonitorWebhookReceiver>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWebhookReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorWebhookReceiver(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorWebhookReceiver)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorWebhookReceiver>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
