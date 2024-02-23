// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonDistanceEvent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Trigger.HasValue)
            {
                writer.WritePropertyName("trigger"u8);
                writer.WriteStringValue(Trigger.Value.ToString());
            }
            if (OutputFrequency != null)
            {
                writer.WritePropertyName("outputFrequency"u8);
                writer.WriteStringValue(OutputFrequency);
            }
            if (MinimumDistanceThreshold != null)
            {
                writer.WritePropertyName("minimumDistanceThreshold"u8);
                writer.WriteStringValue(MinimumDistanceThreshold);
            }
            if (MaximumDistanceThreshold != null)
            {
                writer.WritePropertyName("maximumDistanceThreshold"u8);
                writer.WriteStringValue(MaximumDistanceThreshold);
            }
            if (Threshold != null)
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteStringValue(Threshold);
            }
            if (Focus.HasValue)
            {
                writer.WritePropertyName("focus"u8);
                writer.WriteStringValue(Focus.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonDistanceEvent DeserializeSpatialAnalysisPersonDistanceEvent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SpatialAnalysisPersonDistanceEventTrigger> trigger = default;
            Optional<string> outputFrequency = default;
            Optional<string> minimumDistanceThreshold = default;
            Optional<string> maximumDistanceThreshold = default;
            Optional<string> threshold = default;
            Optional<SpatialAnalysisOperationFocus> focus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trigger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trigger = new SpatialAnalysisPersonDistanceEventTrigger(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputFrequency"u8))
                {
                    outputFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumDistanceThreshold"u8))
                {
                    minimumDistanceThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumDistanceThreshold"u8))
                {
                    maximumDistanceThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("focus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    focus = new SpatialAnalysisOperationFocus(property.Value.GetString());
                    continue;
                }
            }
            return new SpatialAnalysisPersonDistanceEvent(threshold.Value, Optional.ToNullable(focus), Optional.ToNullable(trigger), outputFrequency.Value, minimumDistanceThreshold.Value, maximumDistanceThreshold.Value);
        }
    }
}
