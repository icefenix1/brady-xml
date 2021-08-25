using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using console.Models.Input;

namespace console.Models.Results
{
    [XmlRoot(ElementName="MaxEmissionGenerators")]
    public class MaxEmissionGenerators { 

        [XmlElement(ElementName="Day")] 
        public List<EmissionDay> Day { get; set; } 

        public MaxEmissionGenerators()
        {
        }

        public MaxEmissionGenerators(GenerationReport report, ReferenceData baseinfo)
        {
            Day = new List<EmissionDay>();
            foreach(var gen in report.Coal.CoalGenerator)
            {
                foreach(var day in gen.Generation.Day)
                {
                    var ed = new EmissionDay(
                            gen.Name,
                            day.Date,
                            day.Energy,
                            gen.EmissionsRating,
                            baseinfo.Factors.EmissionsFactor.High);
                    if(Day.Any(d => d.Date == ed.Date)){
                        var compDay = Day.Where(d => d.Date == ed.Date).FirstOrDefault();
                        if(compDay != null && compDay.Emission < ed.Emission)
                        {
                            Day.Remove(compDay);
                            Day.Add(ed);
                        }
                    }
                    else
                    {
                        Day.Add(ed);
                    }
                    
                }                
            }

            foreach(var gen in report.Gas.GasGenerator)
            {
                foreach(var day in gen.Generation.Day)
                {
                    var ed = new EmissionDay(
                            gen.Name,
                            day.Date,
                            day.Energy,
                            gen.EmissionsRating,
                            baseinfo.Factors.EmissionsFactor.High);
                    if(Day.Any(d => d.Date == ed.Date)){
                        var compDay = Day.Where(d => d.Date == ed.Date).FirstOrDefault();
                        if(compDay != null && compDay.Emission < ed.Emission)
                        {
                            Day.Remove(compDay);
                            Day.Add(ed);
                        }
                    }
                    else
                    {
                        Day.Add(ed);
                    }
                    
                }
            }

            
        }
    }
}