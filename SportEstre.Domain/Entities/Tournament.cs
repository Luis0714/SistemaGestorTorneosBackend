using ShopEstre.Domain.Enums;

namespace ShopEstre.Domain.Entities
{
    public class Tournament
    {
        public Guid TournamentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public EnumTypeTourment Type { get; set; } = EnumTypeTourment.Futbol;
        public Guid TournamentStateId { get; set; }
        public TournamentState TournamentState { get; set; }
        public List<TournamentTeams> TournamentTeams { get; set; }

        public Tournament(string name, DateTime createdDate, DateTime startDate, string description, EnumTypeTourment type, TournamentState state, List<TournamentTeams> tournamentTeams)
        {
            TournamentId = Guid.NewGuid();
            Name = name;
            CreatedDate = createdDate;
            StartDate = startDate;
            Description = description;
            Type = type;
            TournamentState = state;
            TournamentTeams = tournamentTeams;
        }
        public Tournament(string name, DateTime createdDate, DateTime startDate, string description, EnumTypeTourment type)
        {
            Name = name;
            CreatedDate = createdDate;
            StartDate = startDate;
            Description = description;
            Type = type;
        }
        public Tournament()
        {
            TournamentId = Guid.NewGuid();
        }
    }
}
