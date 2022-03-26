using System;
using System.Collections.Generic;
using System.Linq;

namespace TheStillHeron.TestWorkshop.Console.FamilyPlanning
{
    public class FamilyPlanner
    {
        private IList<FamilyMember> _familyMembers;

        private IList<Event> _events;

        public FamilyPlanner()
        {
            _familyMembers = new List<FamilyMember>();
            _events = new List<Event>();
        }

        public void AddFamilyMember(string name, IEnumerable<Chore> eligibleChores)
        {
            _familyMembers.Add(new FamilyMember(this, name, eligibleChores));
        }

        public void AddEvent(string title, IEnumerable<FamilyMember> attendees, DateTime occursOn)
        {
            if (attendees.Any(a => !_familyMembers.Any(fm => fm.Name == a.Name)))
            {
                throw new Exception("Tried to add an attendee that is not a member of the family");
            }

            this._events.Add(new Event(this, attendees, title, occursOn));
        }
    }
}