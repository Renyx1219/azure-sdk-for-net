// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationHealthErrorInfo : IUtf8JsonSerializable, IJsonModel<DataReplicationHealthErrorInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationHealthErrorInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataReplicationHealthErrorInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationHealthErrorInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationHealthErrorInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AffectedResourceType != null)
            {
                writer.WritePropertyName("affectedResourceType"u8);
                writer.WriteStringValue(AffectedResourceType);
            }
            if (!(AffectedResourceCorrelationIds is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("affectedResourceCorrelationIds"u8);
                writer.WriteStartArray();
                foreach (var item in AffectedResourceCorrelationIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ChildErrors is ChangeTrackingList<DataReplicationInnerHealthErrorInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("childErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ChildErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Code != null)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (options.Format != "W" && HealthCategory != null)
            {
                writer.WritePropertyName("healthCategory"u8);
                writer.WriteStringValue(HealthCategory);
            }
            if (options.Format != "W" && Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (options.Format != "W" && Severity != null)
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity);
            }
            if (options.Format != "W" && Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && IsCustomerResolvable.HasValue)
            {
                writer.WritePropertyName("isCustomerResolvable"u8);
                writer.WriteBooleanValue(IsCustomerResolvable.Value);
            }
            if (options.Format != "W" && Summary != null)
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (options.Format != "W" && Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Causes != null)
            {
                writer.WritePropertyName("causes"u8);
                writer.WriteStringValue(Causes);
            }
            if (options.Format != "W" && Recommendation != null)
            {
                writer.WritePropertyName("recommendation"u8);
                writer.WriteStringValue(Recommendation);
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

        DataReplicationHealthErrorInfo IJsonModel<DataReplicationHealthErrorInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationHealthErrorInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationHealthErrorInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationHealthErrorInfo(document.RootElement, options);
        }

        internal static DataReplicationHealthErrorInfo DeserializeDataReplicationHealthErrorInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> affectedResourceType = default;
            Optional<IReadOnlyList<string>> affectedResourceCorrelationIds = default;
            Optional<IReadOnlyList<DataReplicationInnerHealthErrorInfo>> childErrors = default;
            Optional<string> code = default;
            Optional<string> healthCategory = default;
            Optional<string> category = default;
            Optional<string> severity = default;
            Optional<string> source = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<bool> isCustomerResolvable = default;
            Optional<string> summary = default;
            Optional<string> message = default;
            Optional<string> causes = default;
            Optional<string> recommendation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("affectedResourceType"u8))
                {
                    affectedResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedResourceCorrelationIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    affectedResourceCorrelationIds = array;
                    continue;
                }
                if (property.NameEquals("childErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationInnerHealthErrorInfo> array = new List<DataReplicationInnerHealthErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationInnerHealthErrorInfo.DeserializeDataReplicationInnerHealthErrorInfo(item, options));
                    }
                    childErrors = array;
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthCategory"u8))
                {
                    healthCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isCustomerResolvable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCustomerResolvable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("causes"u8))
                {
                    causes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendation"u8))
                {
                    recommendation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataReplicationHealthErrorInfo(affectedResourceType.Value, Optional.ToList(affectedResourceCorrelationIds), Optional.ToList(childErrors), code.Value, healthCategory.Value, category.Value, severity.Value, source.Value, Optional.ToNullable(creationTime), Optional.ToNullable(isCustomerResolvable), summary.Value, message.Value, causes.Value, recommendation.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataReplicationHealthErrorInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationHealthErrorInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataReplicationHealthErrorInfo)} does not support '{options.Format}' format.");
            }
        }

        DataReplicationHealthErrorInfo IPersistableModel<DataReplicationHealthErrorInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationHealthErrorInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataReplicationHealthErrorInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataReplicationHealthErrorInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataReplicationHealthErrorInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
