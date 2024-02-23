// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class DominantSpeaker : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("call"u8);
            writer.WriteStringValue(Call);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (PlaceholderImageUri != null)
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            writer.WriteEndObject();
        }

        internal static DominantSpeaker DeserializeDominantSpeaker(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string call = default;
            MediaInputType kind = default;
            Optional<string> placeholderImageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("call"u8))
                {
                    call = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MediaInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
            }
            return new DominantSpeaker(kind, placeholderImageUri.Value, call);
        }
    }
}
