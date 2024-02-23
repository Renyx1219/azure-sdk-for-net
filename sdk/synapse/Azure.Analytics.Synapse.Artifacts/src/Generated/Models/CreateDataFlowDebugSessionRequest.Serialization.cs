// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CreateDataFlowDebugSessionRequestConverter))]
    public partial class CreateDataFlowDebugSessionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ComputeType != null)
            {
                writer.WritePropertyName("computeType"u8);
                writer.WriteStringValue(ComputeType);
            }
            if (CoreCount.HasValue)
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            if (TimeToLive.HasValue)
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLive.Value);
            }
            if (IntegrationRuntime != null)
            {
                writer.WritePropertyName("integrationRuntime"u8);
                writer.WriteObjectValue(IntegrationRuntime);
            }
            writer.WriteEndObject();
        }

        internal static CreateDataFlowDebugSessionRequest DeserializeCreateDataFlowDebugSessionRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> computeType = default;
            Optional<int> coreCount = default;
            Optional<int> timeToLive = default;
            Optional<IntegrationRuntimeDebugResource> integrationRuntime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    computeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("integrationRuntime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    integrationRuntime = IntegrationRuntimeDebugResource.DeserializeIntegrationRuntimeDebugResource(property.Value);
                    continue;
                }
            }
            return new CreateDataFlowDebugSessionRequest(computeType.Value, Optional.ToNullable(coreCount), Optional.ToNullable(timeToLive), integrationRuntime.Value);
        }

        internal partial class CreateDataFlowDebugSessionRequestConverter : JsonConverter<CreateDataFlowDebugSessionRequest>
        {
            public override void Write(Utf8JsonWriter writer, CreateDataFlowDebugSessionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CreateDataFlowDebugSessionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCreateDataFlowDebugSessionRequest(document.RootElement);
            }
        }
    }
}
