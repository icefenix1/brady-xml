using System;
using Xunit;
using console.Models.Results;

namespace console.tests
{
    public class EmissionDayTest
    {
        [Fact]
        public void Emmissions_Should_Be()
        {
            var emissionDay = new EmissionDay("test",DateTime.Now,1,2.0,3.0);
            bool result = emissionDay.Emission == 6;

            Assert.True(result, "Emmisions should be 6");
        }
                
        [Fact]
        public void Emmissions_Should_Not_Be()
        {
            var emissionDay = new EmissionDay("test",DateTime.Now,1,2.0,3.0);
            bool result = emissionDay.Emission != 5;

            Assert.True(result, "Emmisions should not be 5");
        }
    }
}
