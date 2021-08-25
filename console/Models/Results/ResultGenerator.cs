using System;
using System.Xml.Serialization;
using console.Models.Input;

namespace console.Models.Results
{
    [XmlRoot(ElementName="Generator")]
    public class ResultGenerator { 

        [XmlElement(ElementName="Name")] 
        public string Name { get; set; } 

        [XmlElement(ElementName="Total")] 
        public double Total { get; set; } 
    }
}