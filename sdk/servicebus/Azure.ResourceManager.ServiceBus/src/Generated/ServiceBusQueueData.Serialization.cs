// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusQueueData : IUtf8JsonSerializable, IJsonModel<ServiceBusQueueData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusQueueData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusQueueData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusQueueData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusQueueData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && CountDetails != null)
            {
                writer.WritePropertyName("countDetails"u8);
                writer.WriteObjectValue(CountDetails);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && UpdatedOn.HasValue)
            {
                writer.WritePropertyName("updatedAt"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (options.Format != "W" && AccessedOn.HasValue)
            {
                writer.WritePropertyName("accessedAt"u8);
                writer.WriteStringValue(AccessedOn.Value, "O");
            }
            if (options.Format != "W" && SizeInBytes.HasValue)
            {
                writer.WritePropertyName("sizeInBytes"u8);
                writer.WriteNumberValue(SizeInBytes.Value);
            }
            if (options.Format != "W" && MessageCount.HasValue)
            {
                writer.WritePropertyName("messageCount"u8);
                writer.WriteNumberValue(MessageCount.Value);
            }
            if (LockDuration.HasValue)
            {
                writer.WritePropertyName("lockDuration"u8);
                writer.WriteStringValue(LockDuration.Value, "P");
            }
            if (MaxSizeInMegabytes.HasValue)
            {
                writer.WritePropertyName("maxSizeInMegabytes"u8);
                writer.WriteNumberValue(MaxSizeInMegabytes.Value);
            }
            if (MaxMessageSizeInKilobytes.HasValue)
            {
                writer.WritePropertyName("maxMessageSizeInKilobytes"u8);
                writer.WriteNumberValue(MaxMessageSizeInKilobytes.Value);
            }
            if (RequiresDuplicateDetection.HasValue)
            {
                writer.WritePropertyName("requiresDuplicateDetection"u8);
                writer.WriteBooleanValue(RequiresDuplicateDetection.Value);
            }
            if (RequiresSession.HasValue)
            {
                writer.WritePropertyName("requiresSession"u8);
                writer.WriteBooleanValue(RequiresSession.Value);
            }
            if (DefaultMessageTimeToLive.HasValue)
            {
                writer.WritePropertyName("defaultMessageTimeToLive"u8);
                writer.WriteStringValue(DefaultMessageTimeToLive.Value, "P");
            }
            if (DeadLetteringOnMessageExpiration.HasValue)
            {
                writer.WritePropertyName("deadLetteringOnMessageExpiration"u8);
                writer.WriteBooleanValue(DeadLetteringOnMessageExpiration.Value);
            }
            if (DuplicateDetectionHistoryTimeWindow.HasValue)
            {
                writer.WritePropertyName("duplicateDetectionHistoryTimeWindow"u8);
                writer.WriteStringValue(DuplicateDetectionHistoryTimeWindow.Value, "P");
            }
            if (MaxDeliveryCount.HasValue)
            {
                writer.WritePropertyName("maxDeliveryCount"u8);
                writer.WriteNumberValue(MaxDeliveryCount.Value);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (EnableBatchedOperations.HasValue)
            {
                writer.WritePropertyName("enableBatchedOperations"u8);
                writer.WriteBooleanValue(EnableBatchedOperations.Value);
            }
            if (AutoDeleteOnIdle.HasValue)
            {
                writer.WritePropertyName("autoDeleteOnIdle"u8);
                writer.WriteStringValue(AutoDeleteOnIdle.Value, "P");
            }
            if (EnablePartitioning.HasValue)
            {
                writer.WritePropertyName("enablePartitioning"u8);
                writer.WriteBooleanValue(EnablePartitioning.Value);
            }
            if (EnableExpress.HasValue)
            {
                writer.WritePropertyName("enableExpress"u8);
                writer.WriteBooleanValue(EnableExpress.Value);
            }
            if (ForwardTo != null)
            {
                writer.WritePropertyName("forwardTo"u8);
                writer.WriteStringValue(ForwardTo);
            }
            if (ForwardDeadLetteredMessagesTo != null)
            {
                writer.WritePropertyName("forwardDeadLetteredMessagesTo"u8);
                writer.WriteStringValue(ForwardDeadLetteredMessagesTo);
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

        ServiceBusQueueData IJsonModel<ServiceBusQueueData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusQueueData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusQueueData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusQueueData(document.RootElement, options);
        }

        internal static ServiceBusQueueData DeserializeServiceBusQueueData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<MessageCountDetails> countDetails = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<DateTimeOffset> accessedAt = default;
            Optional<long> sizeInBytes = default;
            Optional<long> messageCount = default;
            Optional<TimeSpan> lockDuration = default;
            Optional<int> maxSizeInMegabytes = default;
            Optional<long> maxMessageSizeInKilobytes = default;
            Optional<bool> requiresDuplicateDetection = default;
            Optional<bool> requiresSession = default;
            Optional<TimeSpan> defaultMessageTimeToLive = default;
            Optional<bool> deadLetteringOnMessageExpiration = default;
            Optional<TimeSpan> duplicateDetectionHistoryTimeWindow = default;
            Optional<int> maxDeliveryCount = default;
            Optional<ServiceBusMessagingEntityStatus> status = default;
            Optional<bool> enableBatchedOperations = default;
            Optional<TimeSpan> autoDeleteOnIdle = default;
            Optional<bool> enablePartitioning = default;
            Optional<bool> enableExpress = default;
            Optional<string> forwardTo = default;
            Optional<string> forwardDeadLetteredMessagesTo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("countDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            countDetails = MessageCountDetails.DeserializeMessageCountDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sizeInBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sizeInBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("messageCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            messageCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("lockDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lockDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("maxSizeInMegabytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxSizeInMegabytes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxMessageSizeInKilobytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxMessageSizeInKilobytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("requiresDuplicateDetection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requiresDuplicateDetection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("requiresSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requiresSession = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultMessageTimeToLive"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultMessageTimeToLive = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("deadLetteringOnMessageExpiration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deadLetteringOnMessageExpiration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("duplicateDetectionHistoryTimeWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            duplicateDetectionHistoryTimeWindow = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("maxDeliveryCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDeliveryCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToServiceBusMessagingEntityStatus();
                            continue;
                        }
                        if (property0.NameEquals("enableBatchedOperations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBatchedOperations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoDeleteOnIdle"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoDeleteOnIdle = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("enablePartitioning"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePartitioning = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableExpress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableExpress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("forwardTo"u8))
                        {
                            forwardTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("forwardDeadLetteredMessagesTo"u8))
                        {
                            forwardDeadLetteredMessagesTo = property0.Value.GetString();
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
            return new ServiceBusQueueData(id, name, type, systemData.Value, countDetails.Value, Optional.ToNullable(createdAt), Optional.ToNullable(updatedAt), Optional.ToNullable(accessedAt), Optional.ToNullable(sizeInBytes), Optional.ToNullable(messageCount), Optional.ToNullable(lockDuration), Optional.ToNullable(maxSizeInMegabytes), Optional.ToNullable(maxMessageSizeInKilobytes), Optional.ToNullable(requiresDuplicateDetection), Optional.ToNullable(requiresSession), Optional.ToNullable(defaultMessageTimeToLive), Optional.ToNullable(deadLetteringOnMessageExpiration), Optional.ToNullable(duplicateDetectionHistoryTimeWindow), Optional.ToNullable(maxDeliveryCount), Optional.ToNullable(status), Optional.ToNullable(enableBatchedOperations), Optional.ToNullable(autoDeleteOnIdle), Optional.ToNullable(enablePartitioning), Optional.ToNullable(enableExpress), forwardTo.Value, forwardDeadLetteredMessagesTo.Value, Optional.ToNullable(location), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceBusQueueData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusQueueData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusQueueData)} does not support '{options.Format}' format.");
            }
        }

        ServiceBusQueueData IPersistableModel<ServiceBusQueueData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusQueueData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusQueueData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusQueueData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusQueueData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
