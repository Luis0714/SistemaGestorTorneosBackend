namespace ShopEstre.Domain.Entities
{
    public class Game
    {
        public Guid GameId { get; set; }
        public Guid LocalTeamId { get; set; }
        public Guid VisitingTeamId { get; set; }
        public Team LocalTeam { get; set; }
        public Team VisitingTeam { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public string Location { get; set; }

        public Game(Team localTeam, Team visitingTeam, string location, DateTime startDate, DateTime startTime)
        {
            GameId = Guid.NewGuid();
            LocalTeam = localTeam;
            VisitingTeam = visitingTeam;
            Location = location;
            StartDate = startDate;
            StartTime = startTime;
        }

        public Game(Guid localTeamId, Guid visitingTeamId, string location, DateTime startDate, DateTime startTime)
        {
            LocalTeamId = localTeamId;
            VisitingTeamId = visitingTeamId;
            Location = location;
            StartDate = startDate;
            StartTime = startTime;
        }

        public Game()
        {
            GameId = Guid.NewGuid();
        }
    }
}
