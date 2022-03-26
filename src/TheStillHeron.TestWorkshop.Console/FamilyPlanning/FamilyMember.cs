using System;
using System.Collections.Generic;

namespace TheStillHeron.TestWorkshop.Console.FamilyPlanning
{
    public class FamilyMember
    {
        private FamilyPlanner _parent;

        private string _name;

        private IEnumerable<Chore> _elgibileChores;

        public FamilyMember(FamilyPlanner parent, string name, IEnumerable<Chore> eligibleChores)
        {
            _parent = parent;
            _name = name;
            _elgibileChores = eligibleChores;
        }

        public IEnumerable<Chore> EligibleChores => _elgibileChores;

        public string Name => _name;
    }
}