using System.IO;
using System;
using System.Xml.Serialization;
using console.Models.Input;

namespace console.Models.Results
{
	[XmlRoot(ElementName="GenerationOutput")]
	public class GenerationOutput {

		public GenerationOutput()
		{			
		}

		public GenerationOutput(GenerationReport report, ReferenceData baseinfo)
		{
			Totals = new GeneratorTotals(report, baseinfo);
			MaxEmissionGenerators = new MaxEmissionGenerators(report, baseinfo);
			ActualHeatRates = new ActualHeatRates(report, baseinfo);
		}

		[XmlElement(ElementName="Totals")] 
		public GeneratorTotals Totals { get; set; } 

		[XmlElement(ElementName="MaxEmissionGenerators")] 
		public MaxEmissionGenerators MaxEmissionGenerators { get; set; } 

		[XmlElement(ElementName="ActualHeatRates")] 
		public ActualHeatRates ActualHeatRates { get; set; } 
	}
}