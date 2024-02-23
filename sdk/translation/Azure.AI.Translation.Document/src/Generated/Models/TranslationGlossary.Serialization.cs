// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    public partial class TranslationGlossary : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("glossaryUrl"u8);
            writer.WriteStringValue(GlossaryUri.AbsoluteUri);
            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format);
            if (FormatVersion != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(FormatVersion);
            }
            if (StorageSource != null)
            {
                writer.WritePropertyName("storageSource"u8);
                writer.WriteStringValue(StorageSource);
            }
            writer.WriteEndObject();
        }
    }
}
