// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class TableFixedParameters : IUtf8JsonSerializable, IJsonModel<TableFixedParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TableFixedParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TableFixedParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableFixedParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableFixedParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Booster != null)
            {
                if (Booster != null)
                {
                    writer.WritePropertyName("booster"u8);
                    writer.WriteStringValue(Booster);
                }
                else
                {
                    writer.WriteNull("booster");
                }
            }
            if (BoostingType != null)
            {
                if (BoostingType != null)
                {
                    writer.WritePropertyName("boostingType"u8);
                    writer.WriteStringValue(BoostingType);
                }
                else
                {
                    writer.WriteNull("boostingType");
                }
            }
            if (GrowPolicy != null)
            {
                if (GrowPolicy != null)
                {
                    writer.WritePropertyName("growPolicy"u8);
                    writer.WriteStringValue(GrowPolicy);
                }
                else
                {
                    writer.WriteNull("growPolicy");
                }
            }
            if (LearningRate.HasValue)
            {
                if (LearningRate != null)
                {
                    writer.WritePropertyName("learningRate"u8);
                    writer.WriteNumberValue(LearningRate.Value);
                }
                else
                {
                    writer.WriteNull("learningRate");
                }
            }
            if (MaxBin.HasValue)
            {
                if (MaxBin != null)
                {
                    writer.WritePropertyName("maxBin"u8);
                    writer.WriteNumberValue(MaxBin.Value);
                }
                else
                {
                    writer.WriteNull("maxBin");
                }
            }
            if (MaxDepth.HasValue)
            {
                if (MaxDepth != null)
                {
                    writer.WritePropertyName("maxDepth"u8);
                    writer.WriteNumberValue(MaxDepth.Value);
                }
                else
                {
                    writer.WriteNull("maxDepth");
                }
            }
            if (MaxLeaves.HasValue)
            {
                if (MaxLeaves != null)
                {
                    writer.WritePropertyName("maxLeaves"u8);
                    writer.WriteNumberValue(MaxLeaves.Value);
                }
                else
                {
                    writer.WriteNull("maxLeaves");
                }
            }
            if (MinDataInLeaf.HasValue)
            {
                if (MinDataInLeaf != null)
                {
                    writer.WritePropertyName("minDataInLeaf"u8);
                    writer.WriteNumberValue(MinDataInLeaf.Value);
                }
                else
                {
                    writer.WriteNull("minDataInLeaf");
                }
            }
            if (MinSplitGain.HasValue)
            {
                if (MinSplitGain != null)
                {
                    writer.WritePropertyName("minSplitGain"u8);
                    writer.WriteNumberValue(MinSplitGain.Value);
                }
                else
                {
                    writer.WriteNull("minSplitGain");
                }
            }
            if (ModelName != null)
            {
                if (ModelName != null)
                {
                    writer.WritePropertyName("modelName"u8);
                    writer.WriteStringValue(ModelName);
                }
                else
                {
                    writer.WriteNull("modelName");
                }
            }
            if (NEstimators.HasValue)
            {
                if (NEstimators != null)
                {
                    writer.WritePropertyName("nEstimators"u8);
                    writer.WriteNumberValue(NEstimators.Value);
                }
                else
                {
                    writer.WriteNull("nEstimators");
                }
            }
            if (NumLeaves.HasValue)
            {
                if (NumLeaves != null)
                {
                    writer.WritePropertyName("numLeaves"u8);
                    writer.WriteNumberValue(NumLeaves.Value);
                }
                else
                {
                    writer.WriteNull("numLeaves");
                }
            }
            if (PreprocessorName != null)
            {
                if (PreprocessorName != null)
                {
                    writer.WritePropertyName("preprocessorName"u8);
                    writer.WriteStringValue(PreprocessorName);
                }
                else
                {
                    writer.WriteNull("preprocessorName");
                }
            }
            if (RegAlpha.HasValue)
            {
                if (RegAlpha != null)
                {
                    writer.WritePropertyName("regAlpha"u8);
                    writer.WriteNumberValue(RegAlpha.Value);
                }
                else
                {
                    writer.WriteNull("regAlpha");
                }
            }
            if (RegLambda.HasValue)
            {
                if (RegLambda != null)
                {
                    writer.WritePropertyName("regLambda"u8);
                    writer.WriteNumberValue(RegLambda.Value);
                }
                else
                {
                    writer.WriteNull("regLambda");
                }
            }
            if (Subsample.HasValue)
            {
                if (Subsample != null)
                {
                    writer.WritePropertyName("subsample"u8);
                    writer.WriteNumberValue(Subsample.Value);
                }
                else
                {
                    writer.WriteNull("subsample");
                }
            }
            if (SubsampleFreq.HasValue)
            {
                if (SubsampleFreq != null)
                {
                    writer.WritePropertyName("subsampleFreq"u8);
                    writer.WriteNumberValue(SubsampleFreq.Value);
                }
                else
                {
                    writer.WriteNull("subsampleFreq");
                }
            }
            if (TreeMethod != null)
            {
                if (TreeMethod != null)
                {
                    writer.WritePropertyName("treeMethod"u8);
                    writer.WriteStringValue(TreeMethod);
                }
                else
                {
                    writer.WriteNull("treeMethod");
                }
            }
            if (WithMean.HasValue)
            {
                writer.WritePropertyName("withMean"u8);
                writer.WriteBooleanValue(WithMean.Value);
            }
            if (WithStd.HasValue)
            {
                writer.WritePropertyName("withStd"u8);
                writer.WriteBooleanValue(WithStd.Value);
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

        TableFixedParameters IJsonModel<TableFixedParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableFixedParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableFixedParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTableFixedParameters(document.RootElement, options);
        }

        internal static TableFixedParameters DeserializeTableFixedParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> booster = default;
            Optional<string> boostingType = default;
            Optional<string> growPolicy = default;
            Optional<double?> learningRate = default;
            Optional<int?> maxBin = default;
            Optional<int?> maxDepth = default;
            Optional<int?> maxLeaves = default;
            Optional<int?> minDataInLeaf = default;
            Optional<double?> minSplitGain = default;
            Optional<string> modelName = default;
            Optional<int?> nEstimators = default;
            Optional<int?> numLeaves = default;
            Optional<string> preprocessorName = default;
            Optional<double?> regAlpha = default;
            Optional<double?> regLambda = default;
            Optional<double?> subsample = default;
            Optional<double?> subsampleFreq = default;
            Optional<string> treeMethod = default;
            Optional<bool> withMean = default;
            Optional<bool> withStd = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("booster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        booster = null;
                        continue;
                    }
                    booster = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boostingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        boostingType = null;
                        continue;
                    }
                    boostingType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("growPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        growPolicy = null;
                        continue;
                    }
                    growPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRate = null;
                        continue;
                    }
                    learningRate = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxBin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxBin = null;
                        continue;
                    }
                    maxBin = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxDepth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxDepth = null;
                        continue;
                    }
                    maxDepth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLeaves"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxLeaves = null;
                        continue;
                    }
                    maxLeaves = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minDataInLeaf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        minDataInLeaf = null;
                        continue;
                    }
                    minDataInLeaf = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minSplitGain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        minSplitGain = null;
                        continue;
                    }
                    minSplitGain = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelName = null;
                        continue;
                    }
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nEstimators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nEstimators = null;
                        continue;
                    }
                    nEstimators = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numLeaves"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numLeaves = null;
                        continue;
                    }
                    numLeaves = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preprocessorName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        preprocessorName = null;
                        continue;
                    }
                    preprocessorName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regAlpha"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        regAlpha = null;
                        continue;
                    }
                    regAlpha = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("regLambda"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        regLambda = null;
                        continue;
                    }
                    regLambda = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("subsample"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subsample = null;
                        continue;
                    }
                    subsample = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("subsampleFreq"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subsampleFreq = null;
                        continue;
                    }
                    subsampleFreq = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("treeMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        treeMethod = null;
                        continue;
                    }
                    treeMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("withMean"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    withMean = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("withStd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    withStd = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TableFixedParameters(booster.Value, boostingType.Value, growPolicy.Value, Optional.ToNullable(learningRate), Optional.ToNullable(maxBin), Optional.ToNullable(maxDepth), Optional.ToNullable(maxLeaves), Optional.ToNullable(minDataInLeaf), Optional.ToNullable(minSplitGain), modelName.Value, Optional.ToNullable(nEstimators), Optional.ToNullable(numLeaves), preprocessorName.Value, Optional.ToNullable(regAlpha), Optional.ToNullable(regLambda), Optional.ToNullable(subsample), Optional.ToNullable(subsampleFreq), treeMethod.Value, Optional.ToNullable(withMean), Optional.ToNullable(withStd), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TableFixedParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableFixedParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TableFixedParameters)} does not support '{options.Format}' format.");
            }
        }

        TableFixedParameters IPersistableModel<TableFixedParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableFixedParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTableFixedParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TableFixedParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TableFixedParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
