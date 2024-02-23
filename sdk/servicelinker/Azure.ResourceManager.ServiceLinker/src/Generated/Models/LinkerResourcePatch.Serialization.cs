// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class LinkerResourcePatch : IUtf8JsonSerializable, IJsonModel<LinkerResourcePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkerResourcePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinkerResourcePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerResourcePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkerResourcePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (TargetService != null)
            {
                writer.WritePropertyName("targetService"u8);
                writer.WriteObjectValue(TargetService);
            }
            if (AuthInfo != null)
            {
                writer.WritePropertyName("authInfo"u8);
                writer.WriteObjectValue(AuthInfo);
            }
            if (ClientType.HasValue)
            {
                writer.WritePropertyName("clientType"u8);
                writer.WriteStringValue(ClientType.Value.ToString());
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (VnetSolution != null)
            {
                if (VnetSolution != null)
                {
                    writer.WritePropertyName("vNetSolution"u8);
                    writer.WriteObjectValue(VnetSolution);
                }
                else
                {
                    writer.WriteNull("vNetSolution");
                }
            }
            if (SecretStore != null)
            {
                if (SecretStore != null)
                {
                    writer.WritePropertyName("secretStore"u8);
                    writer.WriteObjectValue(SecretStore);
                }
                else
                {
                    writer.WriteNull("secretStore");
                }
            }
            if (Scope != null)
            {
                if (Scope != null)
                {
                    writer.WritePropertyName("scope"u8);
                    writer.WriteStringValue(Scope);
                }
                else
                {
                    writer.WriteNull("scope");
                }
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

        LinkerResourcePatch IJsonModel<LinkerResourcePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerResourcePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkerResourcePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkerResourcePatch(document.RootElement, options);
        }

        internal static LinkerResourcePatch DeserializeLinkerResourcePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TargetServiceBaseInfo> targetService = default;
            Optional<AuthBaseInfo> authInfo = default;
            Optional<LinkerClientType> clientType = default;
            Optional<string> provisioningState = default;
            Optional<VnetSolution> vnetSolution = default;
            Optional<LinkerSecretStore> secretStore = default;
            Optional<string> scope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetService = TargetServiceBaseInfo.DeserializeTargetServiceBaseInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("authInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authInfo = AuthBaseInfo.DeserializeAuthBaseInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clientType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientType = new LinkerClientType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vNetSolution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                vnetSolution = null;
                                continue;
                            }
                            vnetSolution = VnetSolution.DeserializeVnetSolution(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("secretStore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                secretStore = null;
                                continue;
                            }
                            secretStore = LinkerSecretStore.DeserializeLinkerSecretStore(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                scope = null;
                                continue;
                            }
                            scope = property0.Value.GetString();
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
            return new LinkerResourcePatch(targetService.Value, authInfo.Value, Optional.ToNullable(clientType), provisioningState.Value, vnetSolution.Value, secretStore.Value, scope.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkerResourcePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerResourcePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkerResourcePatch)} does not support '{options.Format}' format.");
            }
        }

        LinkerResourcePatch IPersistableModel<LinkerResourcePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerResourcePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkerResourcePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkerResourcePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkerResourcePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
