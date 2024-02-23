// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeReplicationStatus : IUtf8JsonSerializable, IJsonModel<NetAppVolumeReplicationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeReplicationStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppVolumeReplicationStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeReplicationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeReplicationStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsHealthy.HasValue)
            {
                writer.WritePropertyName("healthy"u8);
                writer.WriteBooleanValue(IsHealthy.Value);
            }
            if (RelationshipStatus.HasValue)
            {
                writer.WritePropertyName("relationshipStatus"u8);
                writer.WriteStringValue(RelationshipStatus.Value.ToString());
            }
            if (MirrorState.HasValue)
            {
                writer.WritePropertyName("mirrorState"u8);
                writer.WriteStringValue(MirrorState.Value.ToString());
            }
            if (TotalProgress != null)
            {
                writer.WritePropertyName("totalProgress"u8);
                writer.WriteStringValue(TotalProgress);
            }
            if (ErrorMessage != null)
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
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

        NetAppVolumeReplicationStatus IJsonModel<NetAppVolumeReplicationStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeReplicationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeReplicationStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeReplicationStatus(document.RootElement, options);
        }

        internal static NetAppVolumeReplicationStatus DeserializeNetAppVolumeReplicationStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> healthy = default;
            Optional<NetAppRelationshipStatus> relationshipStatus = default;
            Optional<NetAppMirrorState> mirrorState = default;
            Optional<string> totalProgress = default;
            Optional<string> errorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("relationshipStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relationshipStatus = new NetAppRelationshipStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mirrorState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mirrorState = new NetAppMirrorState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalProgress"u8))
                {
                    totalProgress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeReplicationStatus(Optional.ToNullable(healthy), Optional.ToNullable(relationshipStatus), Optional.ToNullable(mirrorState), totalProgress.Value, errorMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeReplicationStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeReplicationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeReplicationStatus)} does not support '{options.Format}' format.");
            }
        }

        NetAppVolumeReplicationStatus IPersistableModel<NetAppVolumeReplicationStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeReplicationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeReplicationStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeReplicationStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeReplicationStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
