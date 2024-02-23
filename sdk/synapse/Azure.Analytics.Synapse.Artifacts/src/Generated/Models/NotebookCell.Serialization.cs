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
    [JsonConverter(typeof(NotebookCellConverter))]
    public partial class NotebookCell : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("cell_type"u8);
            writer.WriteStringValue(CellType);
            writer.WritePropertyName("metadata"u8);
            writer.WriteObjectValue(Metadata);
            writer.WritePropertyName("source"u8);
            writer.WriteStartArray();
            foreach (var item in Source)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Attachments != null)
            {
                if (Attachments != null)
                {
                    writer.WritePropertyName("attachments"u8);
                    writer.WriteObjectValue(Attachments);
                }
                else
                {
                    writer.WriteNull("attachments");
                }
            }
            if (!(Outputs is ChangeTrackingList<NotebookCellOutputItem> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static NotebookCell DeserializeNotebookCell(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string cellType = default;
            object metadata = default;
            IList<string> source = default;
            Optional<object> attachments = default;
            Optional<IList<NotebookCellOutputItem>> outputs = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cell_type"u8))
                {
                    cellType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    metadata = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    source = array;
                    continue;
                }
                if (property.NameEquals("attachments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        attachments = null;
                        continue;
                    }
                    attachments = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NotebookCellOutputItem> array = new List<NotebookCellOutputItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotebookCellOutputItem.DeserializeNotebookCellOutputItem(item));
                    }
                    outputs = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new NotebookCell(cellType, metadata, source, attachments.Value, Optional.ToList(outputs), additionalProperties);
        }

        internal partial class NotebookCellConverter : JsonConverter<NotebookCell>
        {
            public override void Write(Utf8JsonWriter writer, NotebookCell model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override NotebookCell Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookCell(document.RootElement);
            }
        }
    }
}
