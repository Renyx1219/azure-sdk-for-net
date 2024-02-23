// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GraphServices.Models
{
    public partial class GraphServicesAccountResourceProperties : IUtf8JsonSerializable, IJsonModel<GraphServicesAccountResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GraphServicesAccountResourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GraphServicesAccountResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GraphServicesAccountResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GraphServicesAccountResourceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("appId"u8);
            writer.WriteStringValue(AppId);
            if (options.Format != "W" && BillingPlanId != null)
            {
                writer.WritePropertyName("billingPlanId"u8);
                writer.WriteStringValue(BillingPlanId);
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

        GraphServicesAccountResourceProperties IJsonModel<GraphServicesAccountResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GraphServicesAccountResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GraphServicesAccountResourceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGraphServicesAccountResourceProperties(document.RootElement, options);
        }

        internal static GraphServicesAccountResourceProperties DeserializeGraphServicesAccountResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GraphServicesProvisioningState> provisioningState = default;
            string appId = default;
            Optional<string> billingPlanId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new GraphServicesProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingPlanId"u8))
                {
                    billingPlanId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GraphServicesAccountResourceProperties(Optional.ToNullable(provisioningState), appId, billingPlanId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GraphServicesAccountResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GraphServicesAccountResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GraphServicesAccountResourceProperties)} does not support '{options.Format}' format.");
            }
        }

        GraphServicesAccountResourceProperties IPersistableModel<GraphServicesAccountResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GraphServicesAccountResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGraphServicesAccountResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GraphServicesAccountResourceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GraphServicesAccountResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
