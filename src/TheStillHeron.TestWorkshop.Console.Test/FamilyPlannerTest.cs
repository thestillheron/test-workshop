using NUnit.Framework;
using Moq;
using TheStillHeron.TestWorkshop.Console.FamilyPlanning;

namespace TheStillHeron.TestWorkshop.Console.Test
{
    public class FamilyPlannerTest
    {
        [Test]
        public void When_Chore_Is_Due_It_Is_Listed_In_The_Plan()
        {
            // Arrange
            var dateProviderMocker = new Mock<IFamilyPlanningDateProvider>();
            dateProviderMocker.Setup(x => x.GetToday()).Returns(new System.DateTime(2022, 04, 23));
            var familyPlanner = FamilyPlanner.Basic();
            var mockedDateProvider = dateProviderMocker.Object;

            // Act
            var dayPlan = familyPlanner.DayPlan(mockedDateProvider);

            // Assert
            // Hint: FamilyPlanner.Basic() makes it so that
            // Elizabeth sweeps on Tuesdays
            Assert.That(dayPlan.Contains("Elizabeth: Sweeping"));
        }
    }
}