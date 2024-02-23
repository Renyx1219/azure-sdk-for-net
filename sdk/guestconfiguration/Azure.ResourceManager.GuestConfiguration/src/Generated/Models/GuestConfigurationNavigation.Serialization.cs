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
    public partial class GuestConfigurationNavigation : IUtf8JsonSerializable, IJsonModel<GuestConfigurationNavigation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuestConfigurationNavigation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GuestConfigurationNavigation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationNavigation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationNavigation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind.HasValue)
            {
                if (Kind != null)
                {
                    writer.WritePropertyName("kind"u8);
                    writer.WriteStringValue(Kind.Value.ToString());
                }
                else
                {
                    writer.WriteNull("kind");
                }
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (ContentUri != null)
            {
                writer.WritePropertyName("contentUri"u8);
                writer.WriteStringValue(ContentUri.AbsoluteUri);
            }
            if (ContentHash != null)
            {
                writer.WritePropertyName("contentHash"u8);
                writer.WriteStringValue(ContentHash);
            }
            if (AssignmentType.HasValue)
            {
                if (AssignmentType != null)
                {
                    writer.WritePropertyName("assignmentType"u8);
                    writer.WriteStringValue(AssignmentType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("assignmentType");
                }
            }
            if (options.Format != "W" && AssignmentSource != null)
            {
                if (AssignmentSource != null)
                {
                    writer.WritePropertyName("assignmentSource"u8);
                    writer.WriteStringValue(AssignmentSource);
                }
                else
                {
                    writer.WriteNull("assignmentSource");
                }
            }
            if (options.Format != "W" && ContentType != null)
            {
                if (ContentType != null)
                {
                    writer.WritePropertyName("contentType"u8);
                    writer.WriteStringValue(ContentType);
                }
                else
                {
                    writer.WriteNull("contentType");
                }
            }
            if (!(ConfigurationParameters is ChangeTrackingList<GuestConfigurationParameter> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("configurationParameter"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ConfigurationProtectedParameters is ChangeTrackingList<GuestConfigurationParameter> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("configurationProtectedParameter"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationProtectedParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ConfigurationSetting != null)
            {
                if (ConfigurationSetting != null)
                {
                    writer.WritePropertyName("configurationSetting"u8);
                    writer.WriteObjectValue(ConfigurationSetting);
                }
                else
                {
                    writer.WriteNull("configurationSetting");
                }
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

        GuestConfigurationNavigation IJsonModel<GuestConfigurationNavigation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationNavigation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationNavigation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationNavigation(document.RootElement, options);
        }

        internal static GuestConfigurationNavigation DeserializeGuestConfigurationNavigation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GuestConfigurationKind?> kind = default;
            Optional<string> name = default;
            Optional<string> version = default;
            Optional<Uri> contentUri = default;
            Optional<string> contentHash = default;
            Optional<GuestConfigurationAssignmentType?> assignmentType = default;
            Optional<string> assignmentSource = default;
            Optional<string> contentType = default;
            Optional<IList<GuestConfigurationParameter>> configurationParameter = default;
            Optional<IList<GuestConfigurationParameter>> configurationProtectedParameter = default;
            Optional<LcmConfigurationSetting> configurationSetting = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        kind = null;
                        continue;
                    }
                    kind = new GuestConfigurationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentHash"u8))
                {
                    contentHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignmentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentType = null;
                        continue;
                    }
                    assignmentType = new GuestConfigurationAssignmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignmentSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentSource = null;
                        continue;
                    }
                    assignmentSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        contentType = null;
                        continue;
                    }
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationParameter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GuestConfigurationParameter> array = new List<GuestConfigurationParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuestConfigurationParameter.DeserializeGuestConfigurationParameter(item, options));
                    }
                    configurationParameter = array;
                    continue;
                }
                if (property.NameEquals("configurationProtectedParameter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GuestConfigurationParameter> array = new List<GuestConfigurationParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuestConfigurationParameter.DeserializeGuestConfigurationParameter(item, options));
                    }
                    configurationProtectedParameter = array;
                    continue;
                }
                if (property.NameEquals("configurationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        configurationSetting = null;
                        continue;
                    }
                    configurationSetting = LcmConfigurationSetting.DeserializeLcmConfigurationSetting(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GuestConfigurationNavigation(Optional.ToNullable(kind), name.Value, version.Value, contentUri.Value, contentHash.Value, Optional.ToNullable(assignmentType), assignmentSource.Value, contentType.Value, Optional.ToList(configurationParameter), Optional.ToList(configurationProtectedParameter), configurationSetting.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GuestConfigurationNavigation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationNavigation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationNavigation)} does not support '{options.Format}' format.");
            }
        }

        GuestConfigurationNavigation IPersistableModel<GuestConfigurationNavigation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationNavigation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuestConfigurationNavigation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationNavigation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuestConfigurationNavigation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
