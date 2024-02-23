// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterUpgradeDeltaHealthPolicy : IUtf8JsonSerializable, IJsonModel<ClusterUpgradeDeltaHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterUpgradeDeltaHealthPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterUpgradeDeltaHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpgradeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterUpgradeDeltaHealthPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("maxPercentDeltaUnhealthyNodes"u8);
            writer.WriteNumberValue(MaxPercentDeltaUnhealthyNodes);
            writer.WritePropertyName("maxPercentUpgradeDomainDeltaUnhealthyNodes"u8);
            writer.WriteNumberValue(MaxPercentUpgradeDomainDeltaUnhealthyNodes);
            writer.WritePropertyName("maxPercentDeltaUnhealthyApplications"u8);
            writer.WriteNumberValue(MaxPercentDeltaUnhealthyApplications);
            if (!(ApplicationDeltaHealthPolicies is ChangeTrackingDictionary<string, ApplicationDeltaHealthPolicy> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("applicationDeltaHealthPolicies"u8);
                writer.WriteStartObject();
                foreach (var item in ApplicationDeltaHealthPolicies)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        ClusterUpgradeDeltaHealthPolicy IJsonModel<ClusterUpgradeDeltaHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpgradeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterUpgradeDeltaHealthPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterUpgradeDeltaHealthPolicy(document.RootElement, options);
        }

        internal static ClusterUpgradeDeltaHealthPolicy DeserializeClusterUpgradeDeltaHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int maxPercentDeltaUnhealthyNodes = default;
            int maxPercentUpgradeDomainDeltaUnhealthyNodes = default;
            int maxPercentDeltaUnhealthyApplications = default;
            Optional<IDictionary<string, ApplicationDeltaHealthPolicy>> applicationDeltaHealthPolicies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentDeltaUnhealthyNodes"u8))
                {
                    maxPercentDeltaUnhealthyNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUpgradeDomainDeltaUnhealthyNodes"u8))
                {
                    maxPercentUpgradeDomainDeltaUnhealthyNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentDeltaUnhealthyApplications"u8))
                {
                    maxPercentDeltaUnhealthyApplications = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("applicationDeltaHealthPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ApplicationDeltaHealthPolicy> dictionary = new Dictionary<string, ApplicationDeltaHealthPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ApplicationDeltaHealthPolicy.DeserializeApplicationDeltaHealthPolicy(property0.Value, options));
                    }
                    applicationDeltaHealthPolicies = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterUpgradeDeltaHealthPolicy(maxPercentDeltaUnhealthyNodes, maxPercentUpgradeDomainDeltaUnhealthyNodes, maxPercentDeltaUnhealthyApplications, Optional.ToDictionary(applicationDeltaHealthPolicies), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterUpgradeDeltaHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpgradeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterUpgradeDeltaHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        ClusterUpgradeDeltaHealthPolicy IPersistableModel<ClusterUpgradeDeltaHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpgradeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterUpgradeDeltaHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterUpgradeDeltaHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterUpgradeDeltaHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
