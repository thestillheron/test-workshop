using System;

namespace TheStillHeron.TestWorkshop.Console.FamilyPlanning
{
    public interface IFamilyPlanningDateProvider
    {
        DateTime GetToday();
    }

    public class FamilyPlanningDateProvider : IFamilyPlanningDateProvider
    {
        public DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}