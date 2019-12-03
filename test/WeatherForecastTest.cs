using Xunit;
using src;

namespace test
{
    public class WeatherForecastTest
    {
        [Fact]
        public void convert_to_fahrenheit()
        {
            var wft = new WeatherForecast();

            wft.TemperatureC = 20;

            Assert.Equal(67, wft.TemperatureF);
        }
    }
}
