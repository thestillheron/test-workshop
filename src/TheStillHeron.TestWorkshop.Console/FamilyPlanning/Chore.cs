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
        private string _name;

        private ChoreCadence _cadence;

        /// <summary>
        /// The date from which we measure to decide if the chore is due again.
        /// E.g. If the cadence is weekly, and the origin date is a Tuesday, the chore will be due on Tuesday
        /// </summary>
        private DateTime _originDate;

        public Chore(string name, ChoreCadence cadence, DateTime originDate)
        {
            _name = name;
            _originDate = originDate;
            _cadence = cadence;
        }

        public string Name => _name;

        public bool IsDue()
        {
            switch (_cadence)
            {
                case ChoreCadence.Daily:
                    return true;
                case ChoreCadence.Weekly:
                    return _originDate.DayOfWeek == DateTime.Today.DayOfWeek;
                case ChoreCadence.Monthly:
                    return _originDate.Day == DateTime.Today.Day;
                default:
                    return false;
            }
        }
    }
}