// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class SendDtmfTonesRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tones"u8);
            writer.WriteStartArray();
            foreach (var item in Tones)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("targetParticipant"u8);
            writer.WriteObjectValue(TargetParticipant);
            if (OperationContext != null)
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (OperationCallbackUri != null)
            {
                writer.WritePropertyName("operationCallbackUri"u8);
                writer.WriteStringValue(OperationCallbackUri);
            }
            writer.WriteEndObject();
        }
    }
}
