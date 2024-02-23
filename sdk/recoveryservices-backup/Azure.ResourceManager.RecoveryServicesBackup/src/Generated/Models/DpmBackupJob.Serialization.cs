// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class DpmBackupJob : IUtf8JsonSerializable, IJsonModel<DpmBackupJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DpmBackupJob>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DpmBackupJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DpmBackupJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DpmBackupJob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Duration.HasValue)
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            if (DpmServerName != null)
            {
                writer.WritePropertyName("dpmServerName"u8);
                writer.WriteStringValue(DpmServerName);
            }
            if (ContainerName != null)
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (ContainerType != null)
            {
                writer.WritePropertyName("containerType"u8);
                writer.WriteStringValue(ContainerType);
            }
            if (WorkloadType != null)
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            if (!(ActionsInfo is ChangeTrackingList<JobSupportedAction> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("actionsInfo"u8);
                writer.WriteStartArray();
                foreach (var item in ActionsInfo)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (!(ErrorDetails is ChangeTrackingList<DpmErrorInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("errorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ErrorDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ExtendedInfo != null)
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (EntityFriendlyName != null)
            {
                writer.WritePropertyName("entityFriendlyName"u8);
                writer.WriteStringValue(EntityFriendlyName);
            }
            if (BackupManagementType.HasValue)
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Operation != null)
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (EndOn.HasValue)
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (ActivityId != null)
            {
                writer.WritePropertyName("activityId"u8);
                writer.WriteStringValue(ActivityId);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType);
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

        DpmBackupJob IJsonModel<DpmBackupJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DpmBackupJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DpmBackupJob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDpmBackupJob(document.RootElement, options);
        }

        internal static DpmBackupJob DeserializeDpmBackupJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> duration = default;
            Optional<string> dpmServerName = default;
            Optional<string> containerName = default;
            Optional<string> containerType = default;
            Optional<string> workloadType = default;
            Optional<IList<JobSupportedAction>> actionsInfo = default;
            Optional<IList<DpmErrorInfo>> errorDetails = default;
            Optional<DpmBackupJobExtendedInfo> extendedInfo = default;
            Optional<string> entityFriendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> operation = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> activityId = default;
            string jobType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("dpmServerName"u8))
                {
                    dpmServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JobSupportedAction> array = new List<JobSupportedAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToJobSupportedAction());
                    }
                    actionsInfo = array;
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DpmErrorInfo> array = new List<DpmErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DpmErrorInfo.DeserializeDpmErrorInfo(item, options));
                    }
                    errorDetails = array;
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = DpmBackupJobExtendedInfo.DeserializeDpmBackupJobExtendedInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("entityFriendlyName"u8))
                {
                    entityFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activityId"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DpmBackupJob(entityFriendlyName.Value, Optional.ToNullable(backupManagementType), operation.Value, status.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), activityId.Value, jobType, serializedAdditionalRawData, Optional.ToNullable(duration), dpmServerName.Value, containerName.Value, containerType.Value, workloadType.Value, Optional.ToList(actionsInfo), Optional.ToList(errorDetails), extendedInfo.Value);
        }

        BinaryData IPersistableModel<DpmBackupJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DpmBackupJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DpmBackupJob)} does not support '{options.Format}' format.");
            }
        }

        DpmBackupJob IPersistableModel<DpmBackupJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DpmBackupJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDpmBackupJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DpmBackupJob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DpmBackupJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
