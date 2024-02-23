// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class OnvifDns : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (FromDhcp.HasValue)
            {
                writer.WritePropertyName("fromDhcp"u8);
                writer.WriteBooleanValue(FromDhcp.Value);
            }
            if (!(Ipv4Address is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStartArray();
                foreach (var item in Ipv4Address)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Ipv6Address is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("ipv6Address"u8);
                writer.WriteStartArray();
                foreach (var item in Ipv6Address)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static OnvifDns DeserializeOnvifDns(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> fromDhcp = default;
            Optional<IList<string>> ipv4Address = default;
            Optional<IList<string>> ipv6Address = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fromDhcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fromDhcp = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ipv4Address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv4Address = array;
                    continue;
                }
                if (property.NameEquals("ipv6Address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv6Address = array;
                    continue;
                }
            }
            return new OnvifDns(Optional.ToNullable(fromDhcp), Optional.ToList(ipv4Address), Optional.ToList(ipv6Address));
        }
    }
}
