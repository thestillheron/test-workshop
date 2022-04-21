using System;
using System.Collections.Generic;
using System.Linq;

namespace TheStillHeron.TestWorkshop.Console.FamilyPlanning
{
    public class FamilyPlanner
    {
        public IList<FamilyMember> FamilyMembers { get; set; }

        public string DayPlan()
        {
            // ex.2
            var plan = "";

            foreach (var member in FamilyMembers)
            {
                plan += member.Chores
                    .Where(x => x.IsDue())
                    .Select(x => x.Name)
                    .Aggregate((total, item) => $"{total}\n{member.Name}: {item}");
            }

            return plan == "" ? "No chores today" : plan;
        }

        public static FamilyPlanner Basic()
        {
            return new FamilyPlanner
            {
                FamilyMembers = new List<FamilyMember>
                {
                    new FamilyMember
                    {
                        Name = "Elizabeth",
                        Chores = new List<Chore>
                        {
                            new Chore
                            {
                                Name = "Sweeping",
                                Cadence = ChoreCadence.Weekly,
                                OriginDate = new DateTime(2022, 01, 01) // Saturday
                            }
                        }
                    }
                }
            };
        }
    }
}