// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    internal partial class DelimitedTextConfigurationInternal : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "DelimitedTextConfiguration");
            if (ColumnSeparator != null)
            {
                writer.WriteStartElement("ColumnSeparator");
                writer.WriteValue(ColumnSeparator);
                writer.WriteEndElement();
            }
            if (FieldQuote != null)
            {
                writer.WriteStartElement("FieldQuote");
                writer.WriteValue(FieldQuote);
                writer.WriteEndElement();
            }
            if (RecordSeparator != null)
            {
                writer.WriteStartElement("RecordSeparator");
                writer.WriteValue(RecordSeparator);
                writer.WriteEndElement();
            }
            if (EscapeChar != null)
            {
                writer.WriteStartElement("EscapeChar");
                writer.WriteValue(EscapeChar);
                writer.WriteEndElement();
            }
            if (HeadersPresent.HasValue)
            {
                writer.WriteStartElement("HasHeaders");
                writer.WriteValue(HeadersPresent.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
    }
}
