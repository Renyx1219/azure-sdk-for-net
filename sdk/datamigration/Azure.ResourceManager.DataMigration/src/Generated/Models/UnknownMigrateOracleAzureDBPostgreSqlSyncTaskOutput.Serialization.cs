// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal partial class UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput : IUtf8JsonSerializable, IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateOracleAzureDBPostgreSqlSyncTaskOutput IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutput(document.RootElement, options);
        }

        internal static UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput DeserializeUnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            string resultType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput(id.Value, resultType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        MigrateOracleAzureDBPostgreSqlSyncTaskOutput IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
