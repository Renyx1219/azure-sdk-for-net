// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;
using Azure.Data.Tables;

namespace Azure.Data.Tables.Models
{
    public partial class TableMetrics : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "Metrics");
            if (Version != null)
            {
                writer.WriteStartElement("Version");
                writer.WriteValue(Version);
                writer.WriteEndElement();
            }
            writer.WriteStartElement("Enabled");
            writer.WriteValue(Enabled);
            writer.WriteEndElement();
            if (IncludeApis.HasValue)
            {
                writer.WriteStartElement("IncludeAPIs");
                writer.WriteValue(IncludeApis.Value);
                writer.WriteEndElement();
            }
            if (RetentionPolicy != null)
            {
                writer.WriteObjectValue(RetentionPolicy, "RetentionPolicy");
            }
            writer.WriteEndElement();
        }

        internal static TableMetrics DeserializeTableMetrics(XElement element)
        {
            string version = default;
            bool enabled = default;
            bool? includeApis = default;
            TableRetentionPolicy retentionPolicy = default;
            if (element.Element("Version") is XElement versionElement)
            {
                version = (string)versionElement;
            }
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("IncludeAPIs") is XElement includeAPIsElement)
            {
                includeApis = (bool?)includeAPIsElement;
            }
            if (element.Element("RetentionPolicy") is XElement retentionPolicyElement)
            {
                retentionPolicy = TableRetentionPolicy.DeserializeTableRetentionPolicy(retentionPolicyElement);
            }
            return new TableMetrics(version, enabled, includeApis, retentionPolicy);
        }
    }
}
