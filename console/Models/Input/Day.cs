using System;
using System.Xml.Serialization;

namespace console.Models.Input
{

    [XmlRoot(ElementName="Day")]
    public class InputDay { 

        [XmlElement(ElementName="Date")] 
        public DateTime Date { get; set; } 

        [XmlElement(ElementName="Energy")] 
        public double Energy { get; set; } 

        [XmlElement(ElementName="Price")] 
        public double Price { get; set; } 
    }

}