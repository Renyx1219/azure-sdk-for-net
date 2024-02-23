// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkInstallation : IUtf8JsonSerializable, IJsonModel<MobileNetworkInstallation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkInstallation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobileNetworkInstallation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkInstallation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkInstallation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DesiredState.HasValue)
            {
                writer.WritePropertyName("desiredState"u8);
                writer.WriteStringValue(DesiredState.Value.ToString());
            }
            if (options.Format != "W" && State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && ReinstallRequired.HasValue)
            {
                writer.WritePropertyName("reinstallRequired"u8);
                writer.WriteStringValue(ReinstallRequired.Value.ToString());
            }
            if (options.Format != "W" && !(Reasons is ChangeTrackingList<MobileNetworkInstallationReason> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("reasons"u8);
                writer.WriteStartArray();
                foreach (var item in Reasons)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Operation != null)
            {
                writer.WritePropertyName("operation"u8);
                JsonSerializer.Serialize(writer, Operation);
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

        MobileNetworkInstallation IJsonModel<MobileNetworkInstallation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkInstallation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkInstallation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkInstallation(document.RootElement, options);
        }

        internal static MobileNetworkInstallation DeserializeMobileNetworkInstallation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DesiredInstallationState> desiredState = default;
            Optional<MobileNetworkInstallationState> state = default;
            Optional<MobileNetworkReinstallRequired> reinstallRequired = default;
            Optional<IReadOnlyList<MobileNetworkInstallationReason>> reasons = default;
            Optional<SubResource> operation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("desiredState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    desiredState = new DesiredInstallationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MobileNetworkInstallationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reinstallRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reinstallRequired = new MobileNetworkReinstallRequired(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reasons"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MobileNetworkInstallationReason> array = new List<MobileNetworkInstallationReason>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MobileNetworkInstallationReason(item.GetString()));
                    }
                    reasons = array;
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operation = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkInstallation(Optional.ToNullable(desiredState), Optional.ToNullable(state), Optional.ToNullable(reinstallRequired), Optional.ToList(reasons), operation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkInstallation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkInstallation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkInstallation)} does not support '{options.Format}' format.");
            }
        }

        MobileNetworkInstallation IPersistableModel<MobileNetworkInstallation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkInstallation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobileNetworkInstallation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkInstallation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkInstallation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
