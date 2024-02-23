// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureCosmosDBDataFeed : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceParameter"u8);
            writer.WriteObjectValue(DataSourceParameter);
            writer.WritePropertyName("dataSourceType"u8);
            writer.WriteStringValue(DataSourceType.ToString());
            writer.WritePropertyName("dataFeedName"u8);
            writer.WriteStringValue(DataFeedName);
            if (DataFeedDescription != null)
            {
                writer.WritePropertyName("dataFeedDescription"u8);
                writer.WriteStringValue(DataFeedDescription);
            }
            writer.WritePropertyName("granularityName"u8);
            writer.WriteStringValue(GranularityName.ToString());
            if (GranularityAmount.HasValue)
            {
                if (GranularityAmount != null)
                {
                    writer.WritePropertyName("granularityAmount"u8);
                    writer.WriteNumberValue(GranularityAmount.Value);
                }
                else
                {
                    writer.WriteNull("granularityAmount");
                }
            }
            writer.WritePropertyName("metrics"u8);
            writer.WriteStartArray();
            foreach (var item in Metrics)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(Dimension is ChangeTrackingList<DataFeedDimension> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dimension"u8);
                writer.WriteStartArray();
                foreach (var item in Dimension)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TimestampColumn != null)
            {
                writer.WritePropertyName("timestampColumn"u8);
                writer.WriteStringValue(TimestampColumn);
            }
            writer.WritePropertyName("dataStartFrom"u8);
            writer.WriteStringValue(DataStartFrom, "O");
            if (StartOffsetInSeconds.HasValue)
            {
                writer.WritePropertyName("startOffsetInSeconds"u8);
                writer.WriteNumberValue(StartOffsetInSeconds.Value);
            }
            if (MaxConcurrency.HasValue)
            {
                writer.WritePropertyName("maxConcurrency"u8);
                writer.WriteNumberValue(MaxConcurrency.Value);
            }
            if (MinRetryIntervalInSeconds.HasValue)
            {
                writer.WritePropertyName("minRetryIntervalInSeconds"u8);
                writer.WriteNumberValue(MinRetryIntervalInSeconds.Value);
            }
            if (StopRetryAfterInSeconds.HasValue)
            {
                writer.WritePropertyName("stopRetryAfterInSeconds"u8);
                writer.WriteNumberValue(StopRetryAfterInSeconds.Value);
            }
            if (NeedRollup.HasValue)
            {
                writer.WritePropertyName("needRollup"u8);
                writer.WriteStringValue(NeedRollup.Value.ToString());
            }
            if (RollUpMethod.HasValue)
            {
                writer.WritePropertyName("rollUpMethod"u8);
                writer.WriteStringValue(RollUpMethod.Value.ToString());
            }
            if (!(RollUpColumns is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("rollUpColumns"u8);
                writer.WriteStartArray();
                foreach (var item in RollUpColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (AllUpIdentification != null)
            {
                writer.WritePropertyName("allUpIdentification"u8);
                writer.WriteStringValue(AllUpIdentification);
            }
            if (FillMissingPointType.HasValue)
            {
                writer.WritePropertyName("fillMissingPointType"u8);
                writer.WriteStringValue(FillMissingPointType.Value.ToString());
            }
            if (FillMissingPointValue.HasValue)
            {
                writer.WritePropertyName("fillMissingPointValue"u8);
                writer.WriteNumberValue(FillMissingPointValue.Value);
            }
            if (ViewMode.HasValue)
            {
                writer.WritePropertyName("viewMode"u8);
                writer.WriteStringValue(ViewMode.Value.ToString());
            }
            if (!(Admins is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("admins"u8);
                writer.WriteStartArray();
                foreach (var item in Admins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Viewers is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("viewers"u8);
                writer.WriteStartArray();
                foreach (var item in Viewers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ActionLinkTemplate != null)
            {
                writer.WritePropertyName("actionLinkTemplate"u8);
                writer.WriteStringValue(ActionLinkTemplate);
            }
            if (AuthenticationType.HasValue)
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (CredentialId != null)
            {
                writer.WritePropertyName("credentialId"u8);
                writer.WriteStringValue(CredentialId);
            }
            writer.WriteEndObject();
        }

        internal static AzureCosmosDBDataFeed DeserializeAzureCosmosDBDataFeed(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureCosmosDBParameter dataSourceParameter = default;
            DataFeedSourceKind dataSourceType = default;
            Optional<string> dataFeedId = default;
            string dataFeedName = default;
            Optional<string> dataFeedDescription = default;
            DataFeedGranularityType granularityName = default;
            Optional<int?> granularityAmount = default;
            IList<DataFeedMetric> metrics = default;
            Optional<IList<DataFeedDimension>> dimension = default;
            Optional<string> timestampColumn = default;
            DateTimeOffset dataStartFrom = default;
            Optional<long> startOffsetInSeconds = default;
            Optional<int> maxConcurrency = default;
            Optional<long> minRetryIntervalInSeconds = default;
            Optional<long> stopRetryAfterInSeconds = default;
            Optional<DataFeedRollupType> needRollup = default;
            Optional<DataFeedAutoRollupMethod> rollUpMethod = default;
            Optional<IList<string>> rollUpColumns = default;
            Optional<string> allUpIdentification = default;
            Optional<DataFeedMissingDataPointFillType> fillMissingPointType = default;
            Optional<double> fillMissingPointValue = default;
            Optional<DataFeedAccessMode> viewMode = default;
            Optional<IList<string>> admins = default;
            Optional<IList<string>> viewers = default;
            Optional<bool> isAdmin = default;
            Optional<string> creator = default;
            Optional<DataFeedStatus> status = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> actionLinkTemplate = default;
            Optional<AuthenticationTypeEnum> authenticationType = default;
            Optional<string> credentialId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSourceParameter"u8))
                {
                    dataSourceParameter = AzureCosmosDBParameter.DeserializeAzureCosmosDBParameter(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceType"u8))
                {
                    dataSourceType = new DataFeedSourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFeedId"u8))
                {
                    dataFeedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedName"u8))
                {
                    dataFeedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedDescription"u8))
                {
                    dataFeedDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("granularityName"u8))
                {
                    granularityName = new DataFeedGranularityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("granularityAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        granularityAmount = null;
                        continue;
                    }
                    granularityAmount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    List<DataFeedMetric> array = new List<DataFeedMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedMetric.DeserializeDataFeedMetric(item));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("dimension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFeedDimension> array = new List<DataFeedDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedDimension.DeserializeDataFeedDimension(item));
                    }
                    dimension = array;
                    continue;
                }
                if (property.NameEquals("timestampColumn"u8))
                {
                    timestampColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStartFrom"u8))
                {
                    dataStartFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startOffsetInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startOffsetInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxConcurrency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minRetryIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minRetryIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("stopRetryAfterInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopRetryAfterInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("needRollup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    needRollup = new DataFeedRollupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollUpMethod = new DataFeedAutoRollupMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpColumns"u8))
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
                    rollUpColumns = array;
                    continue;
                }
                if (property.NameEquals("allUpIdentification"u8))
                {
                    allUpIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fillMissingPointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillMissingPointType = new DataFeedMissingDataPointFillType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fillMissingPointValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillMissingPointValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("viewMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    viewMode = new DataFeedAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("admins"u8))
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
                    admins = array;
                    continue;
                }
                if (property.NameEquals("viewers"u8))
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
                    viewers = array;
                    continue;
                }
                if (property.NameEquals("isAdmin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("creator"u8))
                {
                    creator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataFeedStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("actionLinkTemplate"u8))
                {
                    actionLinkTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new AuthenticationTypeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentialId"u8))
                {
                    credentialId = property.Value.GetString();
                    continue;
                }
            }
            return new AzureCosmosDBDataFeed(dataSourceType, dataFeedId.Value, dataFeedName, dataFeedDescription.Value, granularityName, Optional.ToNullable(granularityAmount), metrics, Optional.ToList(dimension), timestampColumn.Value, dataStartFrom, Optional.ToNullable(startOffsetInSeconds), Optional.ToNullable(maxConcurrency), Optional.ToNullable(minRetryIntervalInSeconds), Optional.ToNullable(stopRetryAfterInSeconds), Optional.ToNullable(needRollup), Optional.ToNullable(rollUpMethod), Optional.ToList(rollUpColumns), allUpIdentification.Value, Optional.ToNullable(fillMissingPointType), Optional.ToNullable(fillMissingPointValue), Optional.ToNullable(viewMode), Optional.ToList(admins), Optional.ToList(viewers), Optional.ToNullable(isAdmin), creator.Value, Optional.ToNullable(status), Optional.ToNullable(createdTime), actionLinkTemplate.Value, Optional.ToNullable(authenticationType), credentialId.Value, dataSourceParameter);
        }
    }
}
