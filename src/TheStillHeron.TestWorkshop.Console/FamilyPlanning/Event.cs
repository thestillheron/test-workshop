using System;
using System.Collections.Generic;

namespace TheStillHeron.TestWorkshop.Console.FamilyPlanning
{
    public class Event
    {
        private FamilyPlanner _parent;

        private IEnumerable<FamilyMember> _attendees;

        private string _title;

        private DateTime _occursOn;

        public Event(FamilyPlanner parent, IEnumerable<FamilyMember> attendees, string title, DateTime occursOn)
        {
            _title = title;
            _parent = parent;
            _attendees = attendees;
            _occursOn = occursOn;
        }

        public IEnumerable<FamilyMember> Attendees => _attendees;

        public string Title => _title;

        public DateTime OccursOn => _occursOn;
    }
}