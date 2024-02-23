// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentModelCopyToOperationDetails : IUtf8JsonSerializable, IJsonModel<DocumentModelCopyToOperationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentModelCopyToOperationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentModelCopyToOperationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelCopyToOperationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentModelCopyToOperationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Result != null)
            {
                writer.WritePropertyName("result"u8);
                writer.WriteObjectValue(Result);
            }
            writer.WritePropertyName("operationId"u8);
            writer.WriteStringValue(OperationId);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (PercentCompleted.HasValue)
            {
                writer.WritePropertyName("percentCompleted"u8);
                writer.WriteNumberValue(PercentCompleted.Value);
            }
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedDateTime, "O");
            writer.WritePropertyName("lastUpdatedDateTime"u8);
            writer.WriteStringValue(LastUpdatedDateTime, "O");
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("resourceLocation"u8);
            writer.WriteStringValue(ResourceLocation.AbsoluteUri);
            if (ApiVersion != null)
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
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
            if (Error != null)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
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

        DocumentModelCopyToOperationDetails IJsonModel<DocumentModelCopyToOperationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelCopyToOperationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentModelCopyToOperationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentModelCopyToOperationDetails(document.RootElement, options);
        }

        internal static DocumentModelCopyToOperationDetails DeserializeDocumentModelCopyToOperationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DocumentModelDetails> result = default;
            string operationId = default;
            OperationStatus status = default;
            Optional<int> percentCompleted = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            OperationKind kind = default;
            Uri resourceLocation = default;
            Optional<string> apiVersion = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<DocumentIntelligenceError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = DocumentModelDetails.DeserializeDocumentModelDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new OperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("percentCompleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentCompleted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new OperationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = DocumentIntelligenceError.DeserializeDocumentIntelligenceError(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DocumentModelCopyToOperationDetails(operationId, status, Optional.ToNullable(percentCompleted), createdDateTime, lastUpdatedDateTime, kind, resourceLocation, apiVersion.Value, Optional.ToDictionary(tags), error.Value, serializedAdditionalRawData, result.Value);
        }

        BinaryData IPersistableModel<DocumentModelCopyToOperationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelCopyToOperationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentModelCopyToOperationDetails)} does not support '{options.Format}' format.");
            }
        }

        DocumentModelCopyToOperationDetails IPersistableModel<DocumentModelCopyToOperationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelCopyToOperationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentModelCopyToOperationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentModelCopyToOperationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentModelCopyToOperationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new DocumentModelCopyToOperationDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentModelCopyToOperationDetails(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
