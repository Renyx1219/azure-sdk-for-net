// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents MTP (Microsoft Threat Protection) data connector. </summary>
    public partial class MtpDataConnector : SecurityInsightsDataConnectorData
    {
        /// <summary> Initializes a new instance of <see cref="MtpDataConnector"/>. </summary>
        public MtpDataConnector()
        {
            Kind = DataConnectorKind.MicrosoftThreatProtection;
        }

        /// <summary> Initializes a new instance of <see cref="MtpDataConnector"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <param name="filteredProviders"> The available filtered providers for the connector. </param>
        /// <param name="incidents"> Incidents data type for Microsoft Threat Protection Platforms data connector. </param>
        /// <param name="alerts"> Alerts data type for Microsoft Threat Protection Platforms data connector. </param>
        internal MtpDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? tenantId, MtpFilteredProviders filteredProviders, DataConnectorDataTypeCommon incidents, DataConnectorDataTypeCommon alerts) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            TenantId = tenantId;
            FilteredProviders = filteredProviders;
            Incidents = incidents;
            Alerts = alerts;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        [WirePath("properties.tenantId")]
        public Guid? TenantId { get; set; }
        /// <summary> The available filtered providers for the connector. </summary>
        internal MtpFilteredProviders FilteredProviders { get; set; }
        /// <summary> Alerts filtered providers. When filters are not applied, all alerts will stream through the MTP pipeline, still in private preview for all products EXCEPT MDA and MDI, which are in GA state. </summary>
        [WirePath("properties.filteredProviders.alerts")]
        public IList<MtpProvider> FilteredProvidersAlerts
        {
            get => FilteredProviders is null ? default : FilteredProviders.Alerts;
            set => FilteredProviders = new MtpFilteredProviders(value);
        }

        /// <summary> Incidents data type for Microsoft Threat Protection Platforms data connector. </summary>
        internal DataConnectorDataTypeCommon Incidents { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        [WirePath("properties.incidents.state")]
        public SecurityInsightsDataTypeConnectionState? IncidentsState
        {
            get => Incidents is null ? default(SecurityInsightsDataTypeConnectionState?) : Incidents.State;
            set
            {
                Incidents = value.HasValue ? new DataConnectorDataTypeCommon(value.Value) : null;
            }
        }

        /// <summary> Alerts data type for Microsoft Threat Protection Platforms data connector. </summary>
        internal DataConnectorDataTypeCommon Alerts { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        [WirePath("properties.alerts.state")]
        public SecurityInsightsDataTypeConnectionState? AlertsState
        {
            get => Alerts is null ? default(SecurityInsightsDataTypeConnectionState?) : Alerts.State;
            set
            {
                Alerts = value.HasValue ? new DataConnectorDataTypeCommon(value.Value) : null;
            }
        }
    }
}
