// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class CostManagementAlertPatch : IUtf8JsonSerializable, IJsonModel<CostManagementAlertPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CostManagementAlertPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CostManagementAlertPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementAlertPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CostManagementAlertPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Definition != null)
            {
                writer.WritePropertyName("definition"u8);
                writer.WriteObjectValue(Definition);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Source.HasValue)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (Details != null)
            {
                writer.WritePropertyName("details"u8);
                writer.WriteObjectValue(Details);
            }
            if (CostEntityId != null)
            {
                writer.WritePropertyName("costEntityId"u8);
                writer.WriteStringValue(CostEntityId);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (CloseOn.HasValue)
            {
                writer.WritePropertyName("closeTime"u8);
                writer.WriteStringValue(CloseOn.Value, "O");
            }
            if (ModifiedOn.HasValue)
            {
                writer.WritePropertyName("modificationTime"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (StatusModificationUserName != null)
            {
                writer.WritePropertyName("statusModificationUserName"u8);
                writer.WriteStringValue(StatusModificationUserName);
            }
            if (StatusModifiedOn.HasValue)
            {
                writer.WritePropertyName("statusModificationTime"u8);
                writer.WriteStringValue(StatusModifiedOn.Value, "O");
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

        CostManagementAlertPatch IJsonModel<CostManagementAlertPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementAlertPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CostManagementAlertPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCostManagementAlertPatch(document.RootElement, options);
        }

        internal static CostManagementAlertPatch DeserializeCostManagementAlertPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AlertPropertiesDefinition> definition = default;
            Optional<string> description = default;
            Optional<CostManagementAlertSource> source = default;
            Optional<AlertPropertiesDetails> details = default;
            Optional<string> costEntityId = default;
            Optional<CostManagementAlertStatus> status = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> closeTime = default;
            Optional<DateTimeOffset> modificationTime = default;
            Optional<string> statusModificationUserName = default;
            Optional<DateTimeOffset> statusModificationTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("definition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            definition = AlertPropertiesDefinition.DeserializeAlertPropertiesDefinition(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new CostManagementAlertSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            details = AlertPropertiesDetails.DeserializeAlertPropertiesDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("costEntityId"u8))
                        {
                            costEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new CostManagementAlertStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("closeTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            closeTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modificationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modificationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("statusModificationUserName"u8))
                        {
                            statusModificationUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statusModificationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            statusModificationTime = property0.Value.GetDateTimeOffset("O");
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
            return new CostManagementAlertPatch(definition.Value, description.Value, Optional.ToNullable(source), details.Value, costEntityId.Value, Optional.ToNullable(status), Optional.ToNullable(creationTime), Optional.ToNullable(closeTime), Optional.ToNullable(modificationTime), statusModificationUserName.Value, Optional.ToNullable(statusModificationTime), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CostManagementAlertPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementAlertPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CostManagementAlertPatch)} does not support '{options.Format}' format.");
            }
        }

        CostManagementAlertPatch IPersistableModel<CostManagementAlertPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementAlertPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCostManagementAlertPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CostManagementAlertPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CostManagementAlertPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
