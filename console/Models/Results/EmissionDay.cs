using System;
using System.Xml.Serialization;
using console.Models.Input;

namespace console.Models.Results
{
    [XmlRoot(ElementName="Day")]
    public class EmissionDay
    {
        [XmlElement(ElementName="Name")] 
        public string Name { get; set; } 

        [XmlElement(ElementName="Date")] 
        public DateTime Date { get; set; } 

        [XmlElement(ElementName="Emission")] 
        public double Emission { get; set; } 
        public EmissionDay()
        {
        }

        public EmissionDay(string name, DateTime date, double energy, double emissionsRating, double emissionFactor)
        {
            Name = name;
            Date = date;
            //Energy x EmissionRating x EmissionFactor
            Emission = energy * emissionsRating * emissionFactor;
        }
    }
    
}