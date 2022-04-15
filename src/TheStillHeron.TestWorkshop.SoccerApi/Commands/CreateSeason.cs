using TheStillHeron.TestWorkshop.SoccerApi.Domain;
using TheStillHeron.TestWorkshop.SoccerApi.Repository;

namespace TheStillHeron.TestWorkshop.SoccerApi.Commands
{
    public class CreateSeason
    {
        private SeasonRepository _repo;

        public CreateSeason(SeasonRepository repo)
        {
            _repo = repo;
        }

        public void Execute(string name, string year)
        {
            var id = System.Guid.NewGuid();
            var season = new Season
            {
                Id = id,
                Name = name,
                Year = year
            };
            _repo.Put(season);
        }
    }
}
