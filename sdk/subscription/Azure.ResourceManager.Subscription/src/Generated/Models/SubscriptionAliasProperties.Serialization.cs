// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class SubscriptionAliasProperties : IUtf8JsonSerializable, IJsonModel<SubscriptionAliasProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionAliasProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SubscriptionAliasProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAliasProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionAliasProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && SubscriptionId != null)
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && AcceptOwnershipUri != null)
            {
                writer.WritePropertyName("acceptOwnershipUrl"u8);
                writer.WriteStringValue(AcceptOwnershipUri.AbsoluteUri);
            }
            if (options.Format != "W" && AcceptOwnershipState.HasValue)
            {
                writer.WritePropertyName("acceptOwnershipState"u8);
                writer.WriteStringValue(AcceptOwnershipState.Value.ToString());
            }
            if (BillingScope != null)
            {
                writer.WritePropertyName("billingScope"u8);
                writer.WriteStringValue(BillingScope);
            }
            if (Workload.HasValue)
            {
                writer.WritePropertyName("workload"u8);
                writer.WriteStringValue(Workload.Value.ToString());
            }
            if (ResellerId != null)
            {
                writer.WritePropertyName("resellerId"u8);
                writer.WriteStringValue(ResellerId);
            }
            if (SubscriptionOwnerId != null)
            {
                writer.WritePropertyName("subscriptionOwnerId"u8);
                writer.WriteStringValue(SubscriptionOwnerId);
            }
            if (ManagementGroupId != null)
            {
                writer.WritePropertyName("managementGroupId"u8);
                writer.WriteStringValue(ManagementGroupId);
            }
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
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

        SubscriptionAliasProperties IJsonModel<SubscriptionAliasProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAliasProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionAliasProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionAliasProperties(document.RootElement, options);
        }

        internal static SubscriptionAliasProperties DeserializeSubscriptionAliasProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> subscriptionId = default;
            Optional<string> displayName = default;
            Optional<SubscriptionProvisioningState> provisioningState = default;
            Optional<Uri> acceptOwnershipUrl = default;
            Optional<AcceptOwnershipState> acceptOwnershipState = default;
            Optional<string> billingScope = default;
            Optional<SubscriptionWorkload> workload = default;
            Optional<string> resellerId = default;
            Optional<string> subscriptionOwnerId = default;
            Optional<string> managementGroupId = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SubscriptionProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("acceptOwnershipUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceptOwnershipUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("acceptOwnershipState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceptOwnershipState = new AcceptOwnershipState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingScope"u8))
                {
                    billingScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workload = new SubscriptionWorkload(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resellerId"u8))
                {
                    resellerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionOwnerId"u8))
                {
                    subscriptionOwnerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managementGroupId"u8))
                {
                    managementGroupId = property.Value.GetString();
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubscriptionAliasProperties(subscriptionId.Value, displayName.Value, Optional.ToNullable(provisioningState), acceptOwnershipUrl.Value, Optional.ToNullable(acceptOwnershipState), billingScope.Value, Optional.ToNullable(workload), resellerId.Value, subscriptionOwnerId.Value, managementGroupId.Value, Optional.ToNullable(createdTime), Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubscriptionAliasProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAliasProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubscriptionAliasProperties)} does not support '{options.Format}' format.");
            }
        }

        SubscriptionAliasProperties IPersistableModel<SubscriptionAliasProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAliasProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubscriptionAliasProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubscriptionAliasProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubscriptionAliasProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
