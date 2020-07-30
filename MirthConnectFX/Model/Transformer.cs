using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MirthConnectFX.Model
{
    [Serializable, XmlRoot("transformer")]
    public class Transformer
    {
        [XmlAttribute("encoding")]
        public string Encoding { get; set; }

        [XmlArray("elements"), XmlArrayItem("com.mirth.connect.plugins.javascriptstep.JavaScriptStep")]
        public List<JavaScriptStep> Steps { get; set; }

        [XmlElement("inboundTemplate")]
        public Template InboundTemplate { get; set; }

        [XmlElement("outboundTemplate")]
        public Template OutboundTemplate { get; set; }

        [XmlElement("inboundProtocol")]
        public string InboundProtocol { get; set; }

        [XmlElement("outboundProtocol")]
        public string OutboundProtocol { get; set; }

        [XmlArray("inboundProperties"), XmlArrayItem("property")]
        public PropertyList InboundProperties { get; set; }

        [XmlArray("outboundProperties"), XmlArrayItem("property")]
        public PropertyList OutboundProperties { get; set; }
    }

    [Serializable]
    public class Template
    {
        [XmlText]
        public string Value { get; set; }

        [XmlAttribute("encoding")]
        public string Encoding { get; set; }
    }
}