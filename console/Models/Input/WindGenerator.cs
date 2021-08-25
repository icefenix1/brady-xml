using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace console.Models.Input
{
    [XmlRoot(ElementName="WindGenerator")]
    public class WindGenerator { 

        [XmlElement(ElementName="Name")] 
        public string Name { get; set; } 

        [XmlElement(ElementName="Generation")] 
        public Generation Generation { get; set; } 

        [XmlElement(ElementName="Location")] 
        public string Location { get; set; } 
    }
}