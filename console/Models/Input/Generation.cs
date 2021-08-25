using System.Collections.Generic;
using System.Xml.Serialization;

namespace console.Models.Input
{
    [XmlRoot(ElementName="Generation")]
    public class Generation { 

        [XmlElement(ElementName="Day")] 
        public List<InputDay> Day { get; set; } 
    }
}