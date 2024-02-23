// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class VirtualMachineRunCommandData : IUtf8JsonSerializable, IJsonModel<VirtualMachineRunCommandData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineRunCommandData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineRunCommandData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineRunCommandData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source);
            }
            if (!(Parameters is ChangeTrackingList<RunCommandInputParameter> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ProtectedParameters is ChangeTrackingList<RunCommandInputParameter> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("protectedParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AsyncExecution.HasValue)
            {
                writer.WritePropertyName("asyncExecution"u8);
                writer.WriteBooleanValue(AsyncExecution.Value);
            }
            if (RunAsUser != null)
            {
                writer.WritePropertyName("runAsUser"u8);
                writer.WriteStringValue(RunAsUser);
            }
            if (RunAsPassword != null)
            {
                writer.WritePropertyName("runAsPassword"u8);
                writer.WriteStringValue(RunAsPassword);
            }
            if (TimeoutInSeconds.HasValue)
            {
                writer.WritePropertyName("timeoutInSeconds"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (OutputBlobUri != null)
            {
                writer.WritePropertyName("outputBlobUri"u8);
                writer.WriteStringValue(OutputBlobUri.AbsoluteUri);
            }
            if (ErrorBlobUri != null)
            {
                writer.WritePropertyName("errorBlobUri"u8);
                writer.WriteStringValue(ErrorBlobUri.AbsoluteUri);
            }
            if (OutputBlobManagedIdentity != null)
            {
                writer.WritePropertyName("outputBlobManagedIdentity"u8);
                writer.WriteObjectValue(OutputBlobManagedIdentity);
            }
            if (ErrorBlobManagedIdentity != null)
            {
                writer.WritePropertyName("errorBlobManagedIdentity"u8);
                writer.WriteObjectValue(ErrorBlobManagedIdentity);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && InstanceView != null)
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView);
            }
            if (TreatFailureAsDeploymentFailure.HasValue)
            {
                writer.WritePropertyName("treatFailureAsDeploymentFailure"u8);
                writer.WriteBooleanValue(TreatFailureAsDeploymentFailure.Value);
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

        VirtualMachineRunCommandData IJsonModel<VirtualMachineRunCommandData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineRunCommandData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineRunCommandData(document.RootElement, options);
        }

        internal static VirtualMachineRunCommandData DeserializeVirtualMachineRunCommandData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<VirtualMachineRunCommandScriptSource> source = default;
            Optional<IList<RunCommandInputParameter>> parameters = default;
            Optional<IList<RunCommandInputParameter>> protectedParameters = default;
            Optional<bool> asyncExecution = default;
            Optional<string> runAsUser = default;
            Optional<string> runAsPassword = default;
            Optional<int> timeoutInSeconds = default;
            Optional<Uri> outputBlobUri = default;
            Optional<Uri> errorBlobUri = default;
            Optional<RunCommandManagedIdentity> outputBlobManagedIdentity = default;
            Optional<RunCommandManagedIdentity> errorBlobManagedIdentity = default;
            Optional<string> provisioningState = default;
            Optional<VirtualMachineRunCommandInstanceView> instanceView = default;
            Optional<bool> treatFailureAsDeploymentFailure = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = VirtualMachineRunCommandScriptSource.DeserializeVirtualMachineRunCommandScriptSource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RunCommandInputParameter> array = new List<RunCommandInputParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RunCommandInputParameter.DeserializeRunCommandInputParameter(item, options));
                            }
                            parameters = array;
                            continue;
                        }
                        if (property0.NameEquals("protectedParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RunCommandInputParameter> array = new List<RunCommandInputParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RunCommandInputParameter.DeserializeRunCommandInputParameter(item, options));
                            }
                            protectedParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("asyncExecution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            asyncExecution = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("runAsUser"u8))
                        {
                            runAsUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("runAsPassword"u8))
                        {
                            runAsPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeoutInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeoutInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("outputBlobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputBlobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorBlobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorBlobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("outputBlobManagedIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputBlobManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("errorBlobManagedIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorBlobManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = VirtualMachineRunCommandInstanceView.DeserializeVirtualMachineRunCommandInstanceView(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("treatFailureAsDeploymentFailure"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            treatFailureAsDeploymentFailure = property0.Value.GetBoolean();
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
            return new VirtualMachineRunCommandData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, source.Value, Optional.ToList(parameters), Optional.ToList(protectedParameters), Optional.ToNullable(asyncExecution), runAsUser.Value, runAsPassword.Value, Optional.ToNullable(timeoutInSeconds), outputBlobUri.Value, errorBlobUri.Value, outputBlobManagedIdentity.Value, errorBlobManagedIdentity.Value, provisioningState.Value, instanceView.Value, Optional.ToNullable(treatFailureAsDeploymentFailure), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineRunCommandData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineRunCommandData)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineRunCommandData IPersistableModel<VirtualMachineRunCommandData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineRunCommandData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineRunCommandData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineRunCommandData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
