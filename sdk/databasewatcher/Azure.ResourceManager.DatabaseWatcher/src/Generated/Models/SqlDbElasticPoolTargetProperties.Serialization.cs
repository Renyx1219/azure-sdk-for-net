// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseWatcher.Models
{
    public partial class SqlDbElasticPoolTargetProperties : IUtf8JsonSerializable, IJsonModel<SqlDbElasticPoolTargetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlDbElasticPoolTargetProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlDbElasticPoolTargetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDbElasticPoolTargetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlDbElasticPoolTargetProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("sqlEpResourceId"u8);
            writer.WriteStringValue(SqlEpResourceId);
            writer.WritePropertyName("anchorDatabaseResourceId"u8);
            writer.WriteStringValue(AnchorDatabaseResourceId);
            if (Optional.IsDefined(ReadIntent))
            {
                writer.WritePropertyName("readIntent"u8);
                writer.WriteBooleanValue(ReadIntent.Value);
            }
        }

        SqlDbElasticPoolTargetProperties IJsonModel<SqlDbElasticPoolTargetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDbElasticPoolTargetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlDbElasticPoolTargetProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlDbElasticPoolTargetProperties(document.RootElement, options);
        }

        internal static SqlDbElasticPoolTargetProperties DeserializeSqlDbElasticPoolTargetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier sqlEpResourceId = default;
            ResourceIdentifier anchorDatabaseResourceId = default;
            bool? readIntent = default;
            string targetType = default;
            TargetAuthenticationType targetAuthenticationType = default;
            VaultSecret targetVault = default;
            string connectionServerName = default;
            ResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlEpResourceId"u8))
                {
                    sqlEpResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("anchorDatabaseResourceId"u8))
                {
                    anchorDatabaseResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readIntent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readIntent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetType"u8))
                {
                    targetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAuthenticationType"u8))
                {
                    targetAuthenticationType = new TargetAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVault = VaultSecret.DeserializeVaultSecret(property.Value, options);
                    continue;
                }
                if (property.NameEquals("connectionServerName"u8))
                {
                    connectionServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlDbElasticPoolTargetProperties(
                targetType,
                targetAuthenticationType,
                targetVault,
                connectionServerName,
                provisioningState,
                serializedAdditionalRawData,
                sqlEpResourceId,
                anchorDatabaseResourceId,
                readIntent);
        }

        BinaryData IPersistableModel<SqlDbElasticPoolTargetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDbElasticPoolTargetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlDbElasticPoolTargetProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SqlDbElasticPoolTargetProperties IPersistableModel<SqlDbElasticPoolTargetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDbElasticPoolTargetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlDbElasticPoolTargetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlDbElasticPoolTargetProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlDbElasticPoolTargetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
