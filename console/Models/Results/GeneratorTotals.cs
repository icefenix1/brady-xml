using System.Linq;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Xml.Serialization;
using console.Models.Input;

namespace console.Models.Results
{
    [XmlRoot(ElementName="Totals")]
    public class GeneratorTotals { 

        [XmlElement(ElementName="Generator")] 
        public List<ResultGenerator> Generator { get; set; } 

        public GeneratorTotals()
        {            
        }

        public GeneratorTotals(GenerationReport report, ReferenceData baseinfo)
        {
            Generator = new List<ResultGenerator>();

            foreach(var coal in report.Coal.CoalGenerator)
            {
                var gen = new ResultGenerator();
                gen.Name = coal.Name;
                gen.Total = coal.Generation.Day.Sum(s => s.Energy);
                Generator.Add(gen);
            }

            foreach(var gas in report.Gas.GasGenerator)
            {
                var gen = new ResultGenerator();
                gen.Name = gas.Name;
                gen.Total = gas.Generation.Day.Sum(s => s.Energy);
                Generator.Add(gen);
            }

            foreach(var wind in report.Wind.WindGenerator)
            {
                var gen = new ResultGenerator();
                gen.Name = wind.Name;
                gen.Total = wind.Generation.Day.Sum(s => s.Energy);
                Generator.Add(gen);
            }
        }
    }
}