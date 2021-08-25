using System;
using System.Xml.Serialization;
using console.Models.Input;

namespace console.Models.Results
{
	[XmlRoot(ElementName="ActualHeatRate")]
	public class ActualHeatRate { 

		[XmlElement(ElementName="Name")] 
		public string Name { get; set; } 

		[XmlElement(ElementName="HeatRate")] 
		public int HeatRate { get; set; } 

		public ActualHeatRate()
		{
		}

		public ActualHeatRate(string name, double TotalHeatInput, double ActualNetGeneration)
		{
			Name = name;
			HeatRate = Convert.ToInt32(TotalHeatInput / ActualNetGeneration);
		}
	}
}