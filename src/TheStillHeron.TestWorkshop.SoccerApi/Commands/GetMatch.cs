using System;
using System.Collections.Generic;
using System.Linq;
using TheStillHeron.TestWorkshop.SoccerApi.Domain;
using TheStillHeron.TestWorkshop.SoccerApi.Repository;

namespace TheStillHeron.TestWorkshop.SoccerApi.Commands
{
    public class GetMatch
    {
        private SeasonRepository _repo;

        public GetMatch(SeasonRepository repo)
        {
            _repo = repo;
        }

        public Match Execute(string seasonToFetch, int roundNumber, int matchNumber)
        {
            var season = _repo.Get(seasonToFetch);

            var match = season
                .Rounds.Where(x => x.RoundNumber == roundNumber)
                .FirstOrDefault()
                ?.Matches.Where(x => x.MatchNumber == matchNumber)
                .FirstOrDefault();

            if (match == null)
            {
                throw new Exception("Not found");
            }

            return match;
        }
    }
}
