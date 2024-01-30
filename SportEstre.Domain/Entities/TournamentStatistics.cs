namespace ShopEstre.Domain.Entities
{
    public class TournamentStatistics
    {
        public Guid TournametStatisticsId { get; set; }
        public Guid TounamentTeamsId { get; set; }
        public TournamentTeams TounamentTeam { get; set; }
        public int Position { get; set; }
        public int GamesPlayed { get; set; }
        public int MatchesWon { get; set; }
        public int MatchesTied { get; set; }
        public int MatchesLost { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsReceived { get; set; }
        public int DifferenceGoals { get; set; }
        public int Points { get; set; }

        public TournamentStatistics(TournamentTeams tounamentTeam, int position, int gamesPlayed, int matchesWon, int matchesTied, int matchesLost, int goalsScored, int goalsReceived, int differenceGoals, int points)
        {
            TournametStatisticsId = Guid.NewGuid();
            TounamentTeam = tounamentTeam;
            Position = position;
            GamesPlayed = gamesPlayed;
            MatchesWon = matchesWon;
            MatchesTied = matchesTied;
            MatchesLost = matchesLost;
            GoalsScored = goalsScored;
            GoalsReceived = goalsReceived;
            DifferenceGoals = differenceGoals;
            Points = points;
        }

        public TournamentStatistics(int position, int gamesPlayed, int matchesWon, int matchesTied, int matchesLost, int goalsScored, int goalsReceived, int differenceGoals, int points)
        {
            Position = position;
            GamesPlayed = gamesPlayed;
            MatchesWon = matchesWon;
            MatchesTied = matchesTied;
            MatchesLost = matchesLost;
            GoalsScored = goalsScored;
            GoalsReceived = goalsReceived;
            DifferenceGoals = differenceGoals;
            Points = points;
        }

        public TournamentStatistics()
        {
            TournametStatisticsId = Guid.NewGuid();
        }
    }
}
