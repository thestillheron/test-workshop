using NUnit.Framework;
using Moq;
using System.Threading.Tasks;

namespace TheStillHeron.TestWorkshop.Console.Test
{
    public class Tests
    {
        [Test]
        public async Task When_Rain_Is_Predicted_Umbrella_Is_Recommended()
        {
            // ex.1
            // Arrange
            var engine = new RecommendationEngine(null);

            // Act
            var recommendation = await engine.GetRecommendation();

            // Assert
            Assert.AreEqual("Don't forget your umbrella!", recommendation);
        }
    }
}