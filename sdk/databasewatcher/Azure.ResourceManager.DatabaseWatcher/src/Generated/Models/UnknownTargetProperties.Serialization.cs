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
    internal partial class UnknownTargetProperties : IUtf8JsonSerializable, IJsonModel<TargetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TargetProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TargetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        TargetProperties IJsonModel<TargetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetProperties(document.RootElement, options);
        }

        internal static UnknownTargetProperties DeserializeUnknownTargetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetType = "Unknown";
            TargetAuthenticationType targetAuthenticationType = default;
            VaultSecret targetVault = default;
            string connectionServerName = default;
            ResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new UnknownTargetProperties(
                targetType,
                targetAuthenticationType,
                targetVault,
                connectionServerName,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TargetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TargetProperties)} does not support writing '{options.Format}' format.");
            }
        }

        TargetProperties IPersistableModel<TargetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTargetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TargetProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TargetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
