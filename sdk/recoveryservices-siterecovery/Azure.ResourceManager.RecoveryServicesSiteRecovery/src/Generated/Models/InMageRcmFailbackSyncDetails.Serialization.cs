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
    public partial class InMageRcmFailbackSyncDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmFailbackSyncDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmFailbackSyncDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmFailbackSyncDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackSyncDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFailbackSyncDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProgressHealth.HasValue)
            {
                writer.WritePropertyName("progressHealth"u8);
                writer.WriteStringValue(ProgressHealth.Value.ToString());
            }
            if (options.Format != "W" && TransferredBytes.HasValue)
            {
                writer.WritePropertyName("transferredBytes"u8);
                writer.WriteNumberValue(TransferredBytes.Value);
            }
            if (options.Format != "W" && Last15MinutesTransferredBytes.HasValue)
            {
                writer.WritePropertyName("last15MinutesTransferredBytes"u8);
                writer.WriteNumberValue(Last15MinutesTransferredBytes.Value);
            }
            if (options.Format != "W" && LastDataTransferOn.HasValue)
            {
                writer.WritePropertyName("lastDataTransferTimeUtc"u8);
                writer.WriteStringValue(LastDataTransferOn.Value, "O");
            }
            if (options.Format != "W" && ProcessedBytes.HasValue)
            {
                writer.WritePropertyName("processedBytes"u8);
                writer.WriteNumberValue(ProcessedBytes.Value);
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && LastRefreshedOn.HasValue)
            {
                writer.WritePropertyName("lastRefreshTime"u8);
                writer.WriteStringValue(LastRefreshedOn.Value, "O");
            }
            if (options.Format != "W" && ProgressPercentage.HasValue)
            {
                writer.WritePropertyName("progressPercentage"u8);
                writer.WriteNumberValue(ProgressPercentage.Value);
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

        InMageRcmFailbackSyncDetails IJsonModel<InMageRcmFailbackSyncDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackSyncDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFailbackSyncDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFailbackSyncDetails(document.RootElement, options);
        }

        internal static InMageRcmFailbackSyncDetails DeserializeInMageRcmFailbackSyncDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryDiskReplicationProgressHealth> progressHealth = default;
            Optional<long> transferredBytes = default;
            Optional<long> last15MinutesTransferredBytes = default;
            Optional<DateTimeOffset> lastDataTransferTimeUtc = default;
            Optional<long> processedBytes = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> lastRefreshTime = default;
            Optional<int> progressPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("progressHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressHealth = new SiteRecoveryDiskReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("transferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("last15MinutesTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    last15MinutesTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastDataTransferTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastDataTransferTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("processedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processedBytes = property.Value.GetInt64();
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
                if (property.NameEquals("lastRefreshTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRefreshTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("progressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmFailbackSyncDetails(Optional.ToNullable(progressHealth), Optional.ToNullable(transferredBytes), Optional.ToNullable(last15MinutesTransferredBytes), Optional.ToNullable(lastDataTransferTimeUtc), Optional.ToNullable(processedBytes), Optional.ToNullable(startTime), Optional.ToNullable(lastRefreshTime), Optional.ToNullable(progressPercentage), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmFailbackSyncDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackSyncDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFailbackSyncDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmFailbackSyncDetails IPersistableModel<InMageRcmFailbackSyncDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackSyncDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmFailbackSyncDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFailbackSyncDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmFailbackSyncDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
