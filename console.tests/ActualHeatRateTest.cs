using System;
using Xunit;
using console.Models.Results;

namespace console.tests
{
    public class ActualHeatRateTest
    {
        [Fact]
        public void ActualHeatRate_Should_Be()
        {
            var heatRate = new ActualHeatRate("test",2.0,1.0);
            bool result = heatRate.HeatRate == 2;

            Assert.True(result, "Emmisions should be 2");
        }
                
        [Fact]
        public void ActualHeatRate_Should_Not_Be()
        {
            var heatRate = new ActualHeatRate("test",0.5,2.0);
            bool result = heatRate.HeatRate != 2;

            Assert.True(result, "Emmisions should not be 2");
        }
    }
}
