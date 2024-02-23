// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ValidateMigrationInputSqlServerSqlDBSyncTaskProperties : IUtf8JsonSerializable, IJsonModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlDBSyncTaskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Input != null)
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            if (options.Format != "W" && !(Output is ChangeTrackingList<ValidateSyncMigrationInputSqlServerTaskOutput> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStartArray();
                foreach (var item in Output)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            if (options.Format != "W" && !(Errors is ChangeTrackingList<ODataError> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && !(Commands is ChangeTrackingList<CommandProperties> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("commands"u8);
                writer.WriteStartArray();
                foreach (var item in Commands)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ClientData is ChangeTrackingDictionary<string, string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("clientData"u8);
                writer.WriteStartObject();
                foreach (var item in ClientData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        ValidateMigrationInputSqlServerSqlDBSyncTaskProperties IJsonModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlDBSyncTaskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeValidateMigrationInputSqlServerSqlDBSyncTaskProperties(document.RootElement, options);
        }

        internal static ValidateMigrationInputSqlServerSqlDBSyncTaskProperties DeserializeValidateMigrationInputSqlServerSqlDBSyncTaskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ValidateSyncMigrationInputSqlServerTaskInput> input = default;
            Optional<IReadOnlyList<ValidateSyncMigrationInputSqlServerTaskOutput>> output = default;
            TaskType taskType = default;
            Optional<IReadOnlyList<ODataError>> errors = default;
            Optional<TaskState> state = default;
            Optional<IReadOnlyList<CommandProperties>> commands = default;
            Optional<IDictionary<string, string>> clientData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = ValidateSyncMigrationInputSqlServerTaskInput.DeserializeValidateSyncMigrationInputSqlServerTaskInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ValidateSyncMigrationInputSqlServerTaskOutput> array = new List<ValidateSyncMigrationInputSqlServerTaskOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ValidateSyncMigrationInputSqlServerTaskOutput.DeserializeValidateSyncMigrationInputSqlServerTaskOutput(item, options));
                    }
                    output = array;
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new TaskState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commands"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommandProperties> array = new List<CommandProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommandProperties.DeserializeCommandProperties(item, options));
                    }
                    commands = array;
                    continue;
                }
                if (property.NameEquals("clientData"u8))
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
                    clientData = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ValidateMigrationInputSqlServerSqlDBSyncTaskProperties(taskType, Optional.ToList(errors), Optional.ToNullable(state), Optional.ToList(commands), Optional.ToDictionary(clientData), serializedAdditionalRawData, input.Value, Optional.ToList(output));
        }

        BinaryData IPersistableModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlDBSyncTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        ValidateMigrationInputSqlServerSqlDBSyncTaskProperties IPersistableModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeValidateMigrationInputSqlServerSqlDBSyncTaskProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlDBSyncTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ValidateMigrationInputSqlServerSqlDBSyncTaskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
