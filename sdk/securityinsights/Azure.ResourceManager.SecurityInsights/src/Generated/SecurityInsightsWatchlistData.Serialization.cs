// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsWatchlistData : IUtf8JsonSerializable, IJsonModel<SecurityInsightsWatchlistData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsWatchlistData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsWatchlistData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsWatchlistData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsWatchlistData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
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
            if (WatchlistId.HasValue)
            {
                writer.WritePropertyName("watchlistId"u8);
                writer.WriteStringValue(WatchlistId.Value);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Provider != null)
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            if (Source.HasValue)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (UpdatedOn.HasValue)
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (CreatedBy != null)
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteObjectValue(CreatedBy);
            }
            if (UpdatedBy != null)
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteObjectValue(UpdatedBy);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (WatchlistType != null)
            {
                writer.WritePropertyName("watchlistType"u8);
                writer.WriteStringValue(WatchlistType);
            }
            if (WatchlistAlias != null)
            {
                writer.WritePropertyName("watchlistAlias"u8);
                writer.WriteStringValue(WatchlistAlias);
            }
            if (IsDeleted.HasValue)
            {
                writer.WritePropertyName("isDeleted"u8);
                writer.WriteBooleanValue(IsDeleted.Value);
            }
            if (!(Labels is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultDuration.HasValue)
            {
                writer.WritePropertyName("defaultDuration"u8);
                writer.WriteStringValue(DefaultDuration.Value, "P");
            }
            if (TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (NumberOfLinesToSkip.HasValue)
            {
                writer.WritePropertyName("numberOfLinesToSkip"u8);
                writer.WriteNumberValue(NumberOfLinesToSkip.Value);
            }
            if (RawContent != null)
            {
                writer.WritePropertyName("rawContent"u8);
                writer.WriteStringValue(RawContent);
            }
            if (ItemsSearchKey != null)
            {
                writer.WritePropertyName("itemsSearchKey"u8);
                writer.WriteStringValue(ItemsSearchKey);
            }
            if (ContentType != null)
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType);
            }
            if (UploadStatus != null)
            {
                writer.WritePropertyName("uploadStatus"u8);
                writer.WriteStringValue(UploadStatus);
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

        SecurityInsightsWatchlistData IJsonModel<SecurityInsightsWatchlistData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsWatchlistData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsWatchlistData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsWatchlistData(document.RootElement, options);
        }

        internal static SecurityInsightsWatchlistData DeserializeSecurityInsightsWatchlistData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> watchlistId = default;
            Optional<string> displayName = default;
            Optional<string> provider = default;
            Optional<Source> source = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            Optional<SecurityInsightsUserInfo> createdBy = default;
            Optional<SecurityInsightsUserInfo> updatedBy = default;
            Optional<string> description = default;
            Optional<string> watchlistType = default;
            Optional<string> watchlistAlias = default;
            Optional<bool> isDeleted = default;
            Optional<IList<string>> labels = default;
            Optional<TimeSpan> defaultDuration = default;
            Optional<Guid> tenantId = default;
            Optional<int> numberOfLinesToSkip = default;
            Optional<string> rawContent = default;
            Optional<string> itemsSearchKey = default;
            Optional<string> contentType = default;
            Optional<string> uploadStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("watchlistId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            watchlistId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provider"u8))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new Source(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdBy = SecurityInsightsUserInfo.DeserializeSecurityInsightsUserInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedBy = SecurityInsightsUserInfo.DeserializeSecurityInsightsUserInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("watchlistType"u8))
                        {
                            watchlistType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("watchlistAlias"u8))
                        {
                            watchlistAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDeleted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDeleted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("numberOfLinesToSkip"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfLinesToSkip = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rawContent"u8))
                        {
                            rawContent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("itemsSearchKey"u8))
                        {
                            itemsSearchKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentType"u8))
                        {
                            contentType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uploadStatus"u8))
                        {
                            uploadStatus = property0.Value.GetString();
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
            return new SecurityInsightsWatchlistData(id, name, type, systemData.Value, Optional.ToNullable(watchlistId), displayName.Value, provider.Value, Optional.ToNullable(source), Optional.ToNullable(created), Optional.ToNullable(updated), createdBy.Value, updatedBy.Value, description.Value, watchlistType.Value, watchlistAlias.Value, Optional.ToNullable(isDeleted), Optional.ToList(labels), Optional.ToNullable(defaultDuration), Optional.ToNullable(tenantId), Optional.ToNullable(numberOfLinesToSkip), rawContent.Value, itemsSearchKey.Value, contentType.Value, uploadStatus.Value, Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsWatchlistData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsWatchlistData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsWatchlistData)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsWatchlistData IPersistableModel<SecurityInsightsWatchlistData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsWatchlistData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsWatchlistData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsWatchlistData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsWatchlistData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
