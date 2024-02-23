// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureDatabricksLinkedServiceConverter))]
    public partial class AzureDatabricksLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, ParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<object> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("domain"u8);
            writer.WriteObjectValue(Domain);
            if (AccessToken != null)
            {
                writer.WritePropertyName("accessToken"u8);
                writer.WriteObjectValue(AccessToken);
            }
            if (Authentication != null)
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
            if (WorkspaceResourceId != null)
            {
                writer.WritePropertyName("workspaceResourceId"u8);
                writer.WriteObjectValue(WorkspaceResourceId);
            }
            if (ExistingClusterId != null)
            {
                writer.WritePropertyName("existingClusterId"u8);
                writer.WriteObjectValue(ExistingClusterId);
            }
            if (InstancePoolId != null)
            {
                writer.WritePropertyName("instancePoolId"u8);
                writer.WriteObjectValue(InstancePoolId);
            }
            if (NewClusterVersion != null)
            {
                writer.WritePropertyName("newClusterVersion"u8);
                writer.WriteObjectValue(NewClusterVersion);
            }
            if (NewClusterNumOfWorker != null)
            {
                writer.WritePropertyName("newClusterNumOfWorker"u8);
                writer.WriteObjectValue(NewClusterNumOfWorker);
            }
            if (NewClusterNodeType != null)
            {
                writer.WritePropertyName("newClusterNodeType"u8);
                writer.WriteObjectValue(NewClusterNodeType);
            }
            if (!(NewClusterSparkConf is ChangeTrackingDictionary<string, object> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("newClusterSparkConf"u8);
                writer.WriteStartObject();
                foreach (var item in NewClusterSparkConf)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(NewClusterSparkEnvVars is ChangeTrackingDictionary<string, object> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("newClusterSparkEnvVars"u8);
                writer.WriteStartObject();
                foreach (var item in NewClusterSparkEnvVars)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(NewClusterCustomTags is ChangeTrackingDictionary<string, object> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("newClusterCustomTags"u8);
                writer.WriteStartObject();
                foreach (var item in NewClusterCustomTags)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (NewClusterLogDestination != null)
            {
                writer.WritePropertyName("newClusterLogDestination"u8);
                writer.WriteObjectValue(NewClusterLogDestination);
            }
            if (NewClusterDriverNodeType != null)
            {
                writer.WritePropertyName("newClusterDriverNodeType"u8);
                writer.WriteObjectValue(NewClusterDriverNodeType);
            }
            if (NewClusterInitScripts != null)
            {
                writer.WritePropertyName("newClusterInitScripts"u8);
                writer.WriteObjectValue(NewClusterInitScripts);
            }
            if (NewClusterEnableElasticDisk != null)
            {
                writer.WritePropertyName("newClusterEnableElasticDisk"u8);
                writer.WriteObjectValue(NewClusterEnableElasticDisk);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            if (PolicyId != null)
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteObjectValue(PolicyId);
            }
            if (Credential != null)
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureDatabricksLinkedService DeserializeAzureDatabricksLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object domain = default;
            Optional<SecretBase> accessToken = default;
            Optional<object> authentication = default;
            Optional<object> workspaceResourceId = default;
            Optional<object> existingClusterId = default;
            Optional<object> instancePoolId = default;
            Optional<object> newClusterVersion = default;
            Optional<object> newClusterNumOfWorker = default;
            Optional<object> newClusterNodeType = default;
            Optional<IDictionary<string, object>> newClusterSparkConf = default;
            Optional<IDictionary<string, object>> newClusterSparkEnvVars = default;
            Optional<IDictionary<string, object>> newClusterCustomTags = default;
            Optional<object> newClusterLogDestination = default;
            Optional<object> newClusterDriverNodeType = default;
            Optional<object> newClusterInitScripts = default;
            Optional<object> newClusterEnableElasticDisk = default;
            Optional<object> encryptedCredential = default;
            Optional<object> policyId = default;
            Optional<CredentialReference> credential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("domain"u8))
                        {
                            domain = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("accessToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessToken = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authentication = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("workspaceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceResourceId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("existingClusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            existingClusterId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("instancePoolId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instancePoolId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("newClusterVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterVersion = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("newClusterNumOfWorker"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterNumOfWorker = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("newClusterNodeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterNodeType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("newClusterSparkConf"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            newClusterSparkConf = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterSparkEnvVars"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            newClusterSparkEnvVars = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterCustomTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            newClusterCustomTags = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterLogDestination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterLogDestination = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("newClusterDriverNodeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterDriverNodeType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("newClusterInitScripts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterInitScripts = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("newClusterEnableElasticDisk"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterEnableElasticDisk = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("policyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = CredentialReference.DeserializeCredentialReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDatabricksLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, domain, accessToken.Value, authentication.Value, workspaceResourceId.Value, existingClusterId.Value, instancePoolId.Value, newClusterVersion.Value, newClusterNumOfWorker.Value, newClusterNodeType.Value, Optional.ToDictionary(newClusterSparkConf), Optional.ToDictionary(newClusterSparkEnvVars), Optional.ToDictionary(newClusterCustomTags), newClusterLogDestination.Value, newClusterDriverNodeType.Value, newClusterInitScripts.Value, newClusterEnableElasticDisk.Value, encryptedCredential.Value, policyId.Value, credential.Value);
        }

        internal partial class AzureDatabricksLinkedServiceConverter : JsonConverter<AzureDatabricksLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, AzureDatabricksLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureDatabricksLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureDatabricksLinkedService(document.RootElement);
            }
        }
    }
}
