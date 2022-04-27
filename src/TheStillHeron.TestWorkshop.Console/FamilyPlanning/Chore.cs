using System;

namespace TheStillHeron.TestWorkshop.Console.FamilyPlanning
{
    public enum ChoreCadence
    {
        Daily,
        Weekly,
        Monthly,
    }
    public class Chore
    {
        public string Name { get; set; }

        public ChoreCadence Cadence { get; set; }

        /// <summary>
        /// The date from which we measure to decide if the chore is due again.
        /// E.g. If the cadence is weekly, and the origin date is a Tuesday, the chore will be due on Tuesday
        /// </summary>
        public DateTime OriginDate { get; set; }

        public bool IsDue(IFamilyPlanningDateProvider dateProvider)
        {
            switch (Cadence)
            {
                case ChoreCadence.Daily:
                    return true;
                case ChoreCadence.Weekly:
                    return OriginDate.DayOfWeek == dateProvider.GetToday().DayOfWeek;
                case ChoreCadence.Monthly:
                    return OriginDate.Day == dateProvider.GetToday().Day;
                default:
                    return false;
            }
        }
    }
}