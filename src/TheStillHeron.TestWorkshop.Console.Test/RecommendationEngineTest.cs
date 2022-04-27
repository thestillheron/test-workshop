using NUnit.Framework;
using Moq;
using System.Threading.Tasks;
using System.Collections.Generic;
using TheStillHeron.TestWorkshop.Console.Weather;

namespace TheStillHeron.TestWorkshop.Console.Test
{
    public class RecommendationEngineTest
    {
        [Test]
        public async Task When_Rain_Is_Predicted_Umbrella_Is_Recommended()
        {
            // ex.1
            // Arrange
            var response = new WeatherResponse
            {
                Weather = new List<WeatherValue>{
                    new WeatherValue
                    {
                        Id = 123,
                        Main = "Rain",
                        Description = "Some light showers"
                    }
                },
                Main = new WeatherDetail
                {
                    Temp = 22.3f,
                    FeelsLike = 23,
                    Humidity = 78
                }
            };

            var apiMock = new Mock<IWeatherApiClient>();
            apiMock.Setup(x => x.GetCurrentWeather()).Returns(Task.FromResult(response));
            var mock = apiMock.Object;

            var engine = new RecommendationEngine(mock);

            // Act
            var recommendation = await engine.GetRecommendation();

            // Assert
            Assert.AreEqual("Don't forget your umbrella!", recommendation);
        }
    }
}