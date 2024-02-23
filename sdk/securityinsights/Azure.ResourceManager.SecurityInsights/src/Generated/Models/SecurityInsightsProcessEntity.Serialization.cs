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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsProcessEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsProcessEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsProcessEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsProcessEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsProcessEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsProcessEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            if (options.Format != "W" && !(AdditionalData is ChangeTrackingDictionary<string, BinaryData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && AccountEntityId != null)
            {
                writer.WritePropertyName("accountEntityId"u8);
                writer.WriteStringValue(AccountEntityId);
            }
            if (options.Format != "W" && CommandLine != null)
            {
                writer.WritePropertyName("commandLine"u8);
                writer.WriteStringValue(CommandLine);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTimeUtc"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (ElevationToken.HasValue)
            {
                writer.WritePropertyName("elevationToken"u8);
                writer.WriteStringValue(ElevationToken.Value.ToSerialString());
            }
            if (options.Format != "W" && HostEntityId != null)
            {
                writer.WritePropertyName("hostEntityId"u8);
                writer.WriteStringValue(HostEntityId);
            }
            if (options.Format != "W" && HostLogonSessionEntityId != null)
            {
                writer.WritePropertyName("hostLogonSessionEntityId"u8);
                writer.WriteStringValue(HostLogonSessionEntityId);
            }
            if (options.Format != "W" && ImageFileEntityId != null)
            {
                writer.WritePropertyName("imageFileEntityId"u8);
                writer.WriteStringValue(ImageFileEntityId);
            }
            if (options.Format != "W" && ParentProcessEntityId != null)
            {
                writer.WritePropertyName("parentProcessEntityId"u8);
                writer.WriteStringValue(ParentProcessEntityId);
            }
            if (options.Format != "W" && ProcessId != null)
            {
                writer.WritePropertyName("processId"u8);
                writer.WriteStringValue(ProcessId);
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

        SecurityInsightsProcessEntity IJsonModel<SecurityInsightsProcessEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsProcessEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsProcessEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsProcessEntity(document.RootElement, options);
        }

        internal static SecurityInsightsProcessEntity DeserializeSecurityInsightsProcessEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> accountEntityId = default;
            Optional<string> commandLine = default;
            Optional<DateTimeOffset> creationTimeUtc = default;
            Optional<SecurityInsightsProcessElevationToken> elevationToken = default;
            Optional<string> hostEntityId = default;
            Optional<string> hostLogonSessionEntityId = default;
            Optional<string> imageFileEntityId = default;
            Optional<string> parentProcessEntityId = default;
            Optional<string> processId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountEntityId"u8))
                        {
                            accountEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("commandLine"u8))
                        {
                            commandLine = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("elevationToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            elevationToken = property0.Value.GetString().ToSecurityInsightsProcessElevationToken();
                            continue;
                        }
                        if (property0.NameEquals("hostEntityId"u8))
                        {
                            hostEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostLogonSessionEntityId"u8))
                        {
                            hostLogonSessionEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageFileEntityId"u8))
                        {
                            imageFileEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parentProcessEntityId"u8))
                        {
                            parentProcessEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("processId"u8))
                        {
                            processId = property0.Value.GetString();
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
            return new SecurityInsightsProcessEntity(id, name, type, systemData.Value, kind, serializedAdditionalRawData, Optional.ToDictionary(additionalData), friendlyName.Value, accountEntityId.Value, commandLine.Value, Optional.ToNullable(creationTimeUtc), Optional.ToNullable(elevationToken), hostEntityId.Value, hostLogonSessionEntityId.Value, imageFileEntityId.Value, parentProcessEntityId.Value, processId.Value);
        }

        BinaryData IPersistableModel<SecurityInsightsProcessEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsProcessEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsProcessEntity)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsProcessEntity IPersistableModel<SecurityInsightsProcessEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsProcessEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsProcessEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsProcessEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsProcessEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
