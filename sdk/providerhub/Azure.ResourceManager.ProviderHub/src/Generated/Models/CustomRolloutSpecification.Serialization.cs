// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CustomRolloutSpecification : IUtf8JsonSerializable, IJsonModel<CustomRolloutSpecification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomRolloutSpecification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomRolloutSpecification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomRolloutSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomRolloutSpecification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("canary"u8);
            writer.WriteObjectValue(Canary);
            if (ProviderRegistration != null)
            {
                writer.WritePropertyName("providerRegistration"u8);
                writer.WriteObjectValue(ProviderRegistration);
            }
            if (!(ResourceTypeRegistrations is ChangeTrackingList<ResourceTypeRegistrationData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("resourceTypeRegistrations"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypeRegistrations)
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

        CustomRolloutSpecification IJsonModel<CustomRolloutSpecification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomRolloutSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomRolloutSpecification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomRolloutSpecification(document.RootElement, options);
        }

        internal static CustomRolloutSpecification DeserializeCustomRolloutSpecification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TrafficRegions canary = default;
            Optional<ProviderRegistrationData> providerRegistration = default;
            Optional<IList<ResourceTypeRegistrationData>> resourceTypeRegistrations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canary"u8))
                {
                    canary = TrafficRegions.DeserializeTrafficRegions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("providerRegistration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerRegistration = ProviderRegistrationData.DeserializeProviderRegistrationData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceTypeRegistrations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeRegistrationData> array = new List<ResourceTypeRegistrationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeRegistrationData.DeserializeResourceTypeRegistrationData(item, options));
                    }
                    resourceTypeRegistrations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomRolloutSpecification(canary, providerRegistration.Value, Optional.ToList(resourceTypeRegistrations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomRolloutSpecification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomRolloutSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomRolloutSpecification)} does not support '{options.Format}' format.");
            }
        }

        CustomRolloutSpecification IPersistableModel<CustomRolloutSpecification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomRolloutSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomRolloutSpecification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomRolloutSpecification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomRolloutSpecification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
