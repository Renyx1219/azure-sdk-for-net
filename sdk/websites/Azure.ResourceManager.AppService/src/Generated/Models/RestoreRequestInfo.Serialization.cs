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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class RestoreRequestInfo : IUtf8JsonSerializable, IJsonModel<RestoreRequestInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreRequestInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestoreRequestInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreRequestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreRequestInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
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
            if (StorageAccountUri != null)
            {
                writer.WritePropertyName("storageAccountUrl"u8);
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (BlobName != null)
            {
                writer.WritePropertyName("blobName"u8);
                writer.WriteStringValue(BlobName);
            }
            if (CanOverwrite.HasValue)
            {
                writer.WritePropertyName("overwrite"u8);
                writer.WriteBooleanValue(CanOverwrite.Value);
            }
            if (SiteName != null)
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
            if (!(Databases is ChangeTrackingList<AppServiceDatabaseBackupSetting> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IgnoreConflictingHostNames.HasValue)
            {
                writer.WritePropertyName("ignoreConflictingHostNames"u8);
                writer.WriteBooleanValue(IgnoreConflictingHostNames.Value);
            }
            if (IgnoreDatabases.HasValue)
            {
                writer.WritePropertyName("ignoreDatabases"u8);
                writer.WriteBooleanValue(IgnoreDatabases.Value);
            }
            if (AppServicePlan != null)
            {
                writer.WritePropertyName("appServicePlan"u8);
                writer.WriteStringValue(AppServicePlan);
            }
            if (OperationType.HasValue)
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToSerialString());
            }
            if (AdjustConnectionStrings.HasValue)
            {
                writer.WritePropertyName("adjustConnectionStrings"u8);
                writer.WriteBooleanValue(AdjustConnectionStrings.Value);
            }
            if (HostingEnvironment != null)
            {
                writer.WritePropertyName("hostingEnvironment"u8);
                writer.WriteStringValue(HostingEnvironment);
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

        RestoreRequestInfo IJsonModel<RestoreRequestInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreRequestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreRequestInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreRequestInfo(document.RootElement, options);
        }

        internal static RestoreRequestInfo DeserializeRestoreRequestInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> storageAccountUrl = default;
            Optional<string> blobName = default;
            Optional<bool> overwrite = default;
            Optional<string> siteName = default;
            Optional<IList<AppServiceDatabaseBackupSetting>> databases = default;
            Optional<bool> ignoreConflictingHostNames = default;
            Optional<bool> ignoreDatabases = default;
            Optional<string> appServicePlan = default;
            Optional<BackupRestoreOperationType> operationType = default;
            Optional<bool> adjustConnectionStrings = default;
            Optional<string> hostingEnvironment = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("storageAccountUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobName"u8))
                        {
                            blobName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("overwrite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overwrite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("siteName"u8))
                        {
                            siteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceDatabaseBackupSetting> array = new List<AppServiceDatabaseBackupSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceDatabaseBackupSetting.DeserializeAppServiceDatabaseBackupSetting(item, options));
                            }
                            databases = array;
                            continue;
                        }
                        if (property0.NameEquals("ignoreConflictingHostNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreConflictingHostNames = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ignoreDatabases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreDatabases = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("appServicePlan"u8))
                        {
                            appServicePlan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationType = property0.Value.GetString().ToBackupRestoreOperationType();
                            continue;
                        }
                        if (property0.NameEquals("adjustConnectionStrings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adjustConnectionStrings = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironment"u8))
                        {
                            hostingEnvironment = property0.Value.GetString();
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
            return new RestoreRequestInfo(id, name, type, systemData.Value, storageAccountUrl.Value, blobName.Value, Optional.ToNullable(overwrite), siteName.Value, Optional.ToList(databases), Optional.ToNullable(ignoreConflictingHostNames), Optional.ToNullable(ignoreDatabases), appServicePlan.Value, Optional.ToNullable(operationType), Optional.ToNullable(adjustConnectionStrings), hostingEnvironment.Value, kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestoreRequestInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreRequestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestoreRequestInfo)} does not support '{options.Format}' format.");
            }
        }

        RestoreRequestInfo IPersistableModel<RestoreRequestInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreRequestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestoreRequestInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestoreRequestInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreRequestInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
