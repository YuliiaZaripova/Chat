using Chat.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace Chat.Test.Controllers
{
    [TestClass]
    public class WeatherForecastControllerTests
    {
        [TestMethod]
        public void Get_ReturnsFiveWeatherForecasts()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count()); // Assuming it returns 5 items
        }

        [TestMethod]
        public void Get_ReturnsSixWeatherForecasts()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Count()); // Assuming it returns 5 items
        }
    }
}