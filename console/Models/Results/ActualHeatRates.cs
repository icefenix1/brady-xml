using System.Collections.Generic;
using System.Xml.Serialization;
using console.Models.Input;

namespace console.Models.Results
{
	[XmlRoot(ElementName="ActualHeatRates")]
	public class ActualHeatRates { 

		[XmlElement(ElementName="ActualHeatRate")] 
		public List<ActualHeatRate> ActualHeatRate { get; set; } 
		public ActualHeatRates()
		{
		}

		public ActualHeatRates(GenerationReport report, ReferenceData baseinfo)
		{
			ActualHeatRate = new List<ActualHeatRate>();

			foreach(var coal in report.Coal.CoalGenerator)
            {
                ActualHeatRate.Add(new ActualHeatRate(coal.Name,coal.ActualNetGeneration,coal.TotalHeatInput));
            }
		}
	}
}