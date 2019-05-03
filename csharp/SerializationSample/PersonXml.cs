using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SerializationSample
{
    public class PersonXml
    {
        public string FirstName { get; set; }

        [XmlAttribute("Last")]
        public string LastName { get; set; }
    }
}
