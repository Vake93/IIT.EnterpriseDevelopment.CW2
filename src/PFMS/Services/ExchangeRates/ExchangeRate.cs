using System;
using System.Xml.Serialization;

namespace PFMS.Services.ExchangeRates
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.gesmes.org/xml/2002-08-01")]
    [XmlRoot(ElementName = "Envelope", Namespace = "http://www.gesmes.org/xml/2002-08-01", IsNullable = false)]
    public partial class HistoricalEnvelope
    {
        [XmlArray("Cube", Namespace = "http://www.ecb.int/vocabulary/2002-08-01/eurofxref")]
        [XmlArrayItem("Cube", IsNullable = false)]
        public ExchangeRate[] ExchangeRates { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.ecb.int/vocabulary/2002-08-01/eurofxref")]
    public partial class ExchangeRate
    {
        [XmlElement("Cube")]
        public ReferenceRate[] ReferenceRates { get; set; }

        [XmlAttribute(AttributeName = "time", DataType = "date")]
        public DateTime Date { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.ecb.int/vocabulary/2002-08-01/eurofxref")]
    public partial class ReferenceRate
    {
        [XmlAttribute(AttributeName = "currency")]
        public string ISOCurrencyCode { get; set; }

        [XmlAttribute(AttributeName = "rate")]
        public decimal Rate { get; set; }
    }
}