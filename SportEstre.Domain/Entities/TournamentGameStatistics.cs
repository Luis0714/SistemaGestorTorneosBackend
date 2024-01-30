namespace ShopEstre.Domain.Entities
{
    public class TournamentGameStatistics
    {
        public Guid TournamentGameStatisticsId { get; set; }
        public Guid GameId { get; set; }
        public int LocalTeamScores { get; set; }
        public int VisitingScores { get; set; }
        public Game Game { get; set; }
        public TournamentGameStatistics(Game game, int localTeamScores, int visitingScores)
        {
            TournamentGameStatisticsId = Guid.NewGuid();
            Game = game;
            LocalTeamScores = localTeamScores;
            VisitingScores = visitingScores;
        }
        public TournamentGameStatistics(int localTeamScores, int visitingScores)
        {
            LocalTeamScores = localTeamScores;
            VisitingScores = visitingScores;
        }

        public TournamentGameStatistics()
        {
            TournamentGameStatisticsId = Guid.NewGuid();
        }
    }
}
