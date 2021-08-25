using System.Xml.Serialization;
using System.Collections.Generic;

namespace console.Models.Input
{
    [XmlRoot(ElementName="Coal")]
    public class Coal { 

        [XmlElement(ElementName="CoalGenerator")] 
        public List<CoalGenerator> CoalGenerator { get; set; } 
    }
}