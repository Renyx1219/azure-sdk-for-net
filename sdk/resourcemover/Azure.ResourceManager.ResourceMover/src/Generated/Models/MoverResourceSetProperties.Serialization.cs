// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceSetProperties : IUtf8JsonSerializable, IJsonModel<MoverResourceSetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverResourceSetProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverResourceSetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceSetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceSetProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SourceLocation.HasValue)
            {
                writer.WritePropertyName("sourceRegion"u8);
                writer.WriteStringValue(SourceLocation.Value);
            }
            if (TargetLocation.HasValue)
            {
                writer.WritePropertyName("targetRegion"u8);
                writer.WriteStringValue(TargetLocation.Value);
            }
            if (MoveLocation.HasValue)
            {
                writer.WritePropertyName("moveRegion"u8);
                writer.WriteStringValue(MoveLocation.Value);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (MoveType.HasValue)
            {
                writer.WritePropertyName("moveType"u8);
                writer.WriteStringValue(MoveType.Value.ToString());
            }
            if (options.Format != "W" && Errors != null)
            {
                if (Errors != null)
                {
                    writer.WritePropertyName("errors"u8);
                    writer.WriteObjectValue(Errors);
                }
                else
                {
                    writer.WriteNull("errors");
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

        MoverResourceSetProperties IJsonModel<MoverResourceSetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceSetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceSetProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceSetProperties(document.RootElement, options);
        }

        internal static MoverResourceSetProperties DeserializeMoverResourceSetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> sourceRegion = default;
            Optional<AzureLocation> targetRegion = default;
            Optional<AzureLocation> moveRegion = default;
            Optional<MoverProvisioningState> provisioningState = default;
            Optional<string> version = default;
            Optional<MoveType> moveType = default;
            Optional<MoveCollectionPropertiesErrors> errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("moveRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MoverProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moveType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveType = new MoveType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errors = null;
                        continue;
                    }
                    errors = MoveCollectionPropertiesErrors.DeserializeMoveCollectionPropertiesErrors(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverResourceSetProperties(Optional.ToNullable(sourceRegion), Optional.ToNullable(targetRegion), Optional.ToNullable(moveRegion), Optional.ToNullable(provisioningState), version.Value, Optional.ToNullable(moveType), errors.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverResourceSetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceSetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoverResourceSetProperties)} does not support '{options.Format}' format.");
            }
        }

        MoverResourceSetProperties IPersistableModel<MoverResourceSetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceSetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverResourceSetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverResourceSetProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverResourceSetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
