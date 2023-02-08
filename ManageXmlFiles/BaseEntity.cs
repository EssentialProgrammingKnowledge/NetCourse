using System.Xml.Serialization;

namespace ManageXmlFiles
{
    public class BaseEntity
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }
    }
}
