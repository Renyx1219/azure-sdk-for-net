// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class Participant : IUtf8JsonSerializable, IJsonModel<Participant>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Participant>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Participant>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Participant>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Participant)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("profileTypeName"u8);
            writer.WriteStringValue(ProfileTypeName);
            writer.WritePropertyName("participantPropertyReferences"u8);
            writer.WriteStartArray();
            foreach (var item in ParticipantPropertyReferences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("participantName"u8);
            writer.WriteStringValue(ParticipantName);
            if (!(DisplayName is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Description is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Role != null)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role);
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

        Participant IJsonModel<Participant>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Participant>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Participant)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeParticipant(document.RootElement, options);
        }

        internal static Participant DeserializeParticipant(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string profileTypeName = default;
            IList<ParticipantPropertyReference> participantPropertyReferences = default;
            string participantName = default;
            Optional<IDictionary<string, string>> displayName = default;
            Optional<IDictionary<string, string>> description = default;
            Optional<string> role = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileTypeName"u8))
                {
                    profileTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("participantPropertyReferences"u8))
                {
                    List<ParticipantPropertyReference> array = new List<ParticipantPropertyReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParticipantPropertyReference.DeserializeParticipantPropertyReference(item, options));
                    }
                    participantPropertyReferences = array;
                    continue;
                }
                if (property.NameEquals("participantName"u8))
                {
                    participantName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    displayName = dictionary;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    description = dictionary;
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Participant(profileTypeName, participantPropertyReferences, participantName, Optional.ToDictionary(displayName), Optional.ToDictionary(description), role.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Participant>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Participant>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Participant)} does not support '{options.Format}' format.");
            }
        }

        Participant IPersistableModel<Participant>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Participant>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeParticipant(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Participant)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Participant>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
