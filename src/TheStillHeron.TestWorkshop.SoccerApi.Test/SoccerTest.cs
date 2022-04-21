using NUnit.Framework;
using TheStillHeron.TestWorkshop.SoccerApi.Commands;
using TheStillHeron.TestWorkshop.SoccerApi.DataStorage;
using TheStillHeron.TestWorkshop.SoccerApi.Repository;

namespace TheStillHeron.TestWorkshop.SoccerApi.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Can_Create_A_Season()
        {
            // Arrange
            var dataStore = new DataStore();
            var repo = new SeasonRepository(dataStore);
            var year = "2022";

            // Act
            var createCommand = new CreateSeason(repo);
            createCommand.Execute("Home and Away", "2022");

            // Assert
            var getSeasonCommand = new GetSeason(repo);
            var fetchedSeason = getSeasonCommand.Execute(year);

            Assert.AreEqual("Home and Away", fetchedSeason.Name);
        }
    }
}