using System;
using Xunit;
using src;

namespace test
{
    public class WeatherForecastTest
    {
        [Fact]
        public void Test1()
        {
            var wft = new WeatherForecast();

            wft.TemperatureC = 20;

            Assert.Equal(67, wft.TemperatureF);
        }
    }
}
