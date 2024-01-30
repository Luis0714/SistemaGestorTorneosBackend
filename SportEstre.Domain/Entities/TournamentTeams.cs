using ShopEstre.Domain.Interfaces.Repositories;

namespace ShopEstre.Domain.Entities
{
    public class TournamentTeams
    {
        public Guid TourmentTeamsId { get; set; }
        public Guid TournamentId { get; set; }
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
        public Tournament Tournament { get; set; }
        public bool IsActive { get; set; }

        public TournamentTeams(Tournament tournament, Team team, bool isActive)
        {
            TourmentTeamsId = Guid.NewGuid();
            Tournament = tournament;
            Team = team;
            IsActive = isActive;
        }
        public TournamentTeams(bool isActive)
        {
            IsActive = isActive;
        }

        public TournamentTeams()
        {
            TourmentTeamsId = Guid.NewGuid();
        }
    }
}
