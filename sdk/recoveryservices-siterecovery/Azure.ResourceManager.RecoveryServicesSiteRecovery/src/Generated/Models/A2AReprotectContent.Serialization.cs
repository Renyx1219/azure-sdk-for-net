// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AReprotectContent : IUtf8JsonSerializable, IJsonModel<A2AReprotectContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AReprotectContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AReprotectContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReprotectContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AReprotectContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RecoveryContainerId != null)
            {
                writer.WritePropertyName("recoveryContainerId"u8);
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (!(VmDisks is ChangeTrackingList<A2AVmDiskDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RecoveryResourceGroupId != null)
            {
                writer.WritePropertyName("recoveryResourceGroupId"u8);
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            if (RecoveryCloudServiceId != null)
            {
                writer.WritePropertyName("recoveryCloudServiceId"u8);
                writer.WriteStringValue(RecoveryCloudServiceId);
            }
            if (RecoveryAvailabilitySetId != null)
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (PolicyId != null)
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        A2AReprotectContent IJsonModel<A2AReprotectContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReprotectContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AReprotectContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AReprotectContent(document.RootElement, options);
        }

        internal static A2AReprotectContent DeserializeA2AReprotectContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> recoveryContainerId = default;
            Optional<IList<A2AVmDiskDetails>> vmDisks = default;
            Optional<ResourceIdentifier> recoveryResourceGroupId = default;
            Optional<string> recoveryCloudServiceId = default;
            Optional<ResourceIdentifier> recoveryAvailabilitySetId = default;
            Optional<ResourceIdentifier> policyId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AVmDiskDetails> array = new List<A2AVmDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AVmDiskDetails.DeserializeA2AVmDiskDetails(item, options));
                    }
                    vmDisks = array;
                    continue;
                }
                if (property.NameEquals("recoveryResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryCloudServiceId"u8))
                {
                    recoveryCloudServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AReprotectContent(instanceType, serializedAdditionalRawData, recoveryContainerId.Value, Optional.ToList(vmDisks), recoveryResourceGroupId.Value, recoveryCloudServiceId.Value, recoveryAvailabilitySetId.Value, policyId.Value);
        }

        BinaryData IPersistableModel<A2AReprotectContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReprotectContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AReprotectContent)} does not support '{options.Format}' format.");
            }
        }

        A2AReprotectContent IPersistableModel<A2AReprotectContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReprotectContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AReprotectContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AReprotectContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AReprotectContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
