// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class QueryFilters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MetadataFilter != null)
            {
                writer.WritePropertyName("metadataFilter"u8);
                writer.WriteObjectValue(MetadataFilter);
            }
            if (!(SourceFilter is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sourceFilter"u8);
                writer.WriteStartArray();
                foreach (var item in SourceFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (LogicalOperation.HasValue)
            {
                writer.WritePropertyName("logicalOperation"u8);
                writer.WriteStringValue(LogicalOperation.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
