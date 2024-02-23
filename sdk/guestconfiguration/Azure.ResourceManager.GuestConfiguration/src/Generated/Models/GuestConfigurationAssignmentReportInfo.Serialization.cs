// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentReportInfo : IUtf8JsonSerializable, IJsonModel<GuestConfigurationAssignmentReportInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuestConfigurationAssignmentReportInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GuestConfigurationAssignmentReportInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && ReportId.HasValue)
            {
                writer.WritePropertyName("reportId"u8);
                writer.WriteStringValue(ReportId.Value);
            }
            if (Assignment != null)
            {
                writer.WritePropertyName("assignment"u8);
                writer.WriteObjectValue(Assignment);
            }
            if (Vm != null)
            {
                writer.WritePropertyName("vm"u8);
                writer.WriteObjectValue(Vm);
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && EndOn.HasValue)
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && ComplianceStatus.HasValue)
            {
                writer.WritePropertyName("complianceStatus"u8);
                writer.WriteStringValue(ComplianceStatus.Value.ToString());
            }
            if (options.Format != "W" && OperationType.HasValue)
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (!(Resources is ChangeTrackingList<AssignmentReportResourceInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
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

        GuestConfigurationAssignmentReportInfo IJsonModel<GuestConfigurationAssignmentReportInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationAssignmentReportInfo(document.RootElement, options);
        }

        internal static GuestConfigurationAssignmentReportInfo DeserializeGuestConfigurationAssignmentReportInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<Guid> reportId = default;
            Optional<GuestConfigurationAssignmentInfo> assignment = default;
            Optional<GuestConfigurationVmInfo> vm = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<AssignedGuestConfigurationMachineComplianceStatus> complianceStatus = default;
            Optional<GuestConfigurationAssignmentReportType> operationType = default;
            Optional<IList<AssignmentReportResourceInfo>> resources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reportId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("assignment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignment = GuestConfigurationAssignmentInfo.DeserializeGuestConfigurationAssignmentInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vm = GuestConfigurationVmInfo.DeserializeGuestConfigurationVmInfo(property.Value, options);
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
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new GuestConfigurationAssignmentReportType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssignmentReportResourceInfo> array = new List<AssignmentReportResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignmentReportResourceInfo.DeserializeAssignmentReportResourceInfo(item, options));
                    }
                    resources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GuestConfigurationAssignmentReportInfo(id.Value, Optional.ToNullable(reportId), assignment.Value, vm.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(complianceStatus), Optional.ToNullable(operationType), Optional.ToList(resources), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GuestConfigurationAssignmentReportInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportInfo)} does not support '{options.Format}' format.");
            }
        }

        GuestConfigurationAssignmentReportInfo IPersistableModel<GuestConfigurationAssignmentReportInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuestConfigurationAssignmentReportInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuestConfigurationAssignmentReportInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
