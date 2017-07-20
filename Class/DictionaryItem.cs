using System.Xml.Serialization;

namespace Days
{
    public class DictionaryItem
    {
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("String")]
        public string String { get; set; }
    }
}
