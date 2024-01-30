namespace ShopEstre.Domain.Entities
{
    public class Player
    {
        public Guid PlayerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Number { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Photo { get; set; } = string.Empty;
        public int Age { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public List<PlayerTeamTournaments> TeamsByTournament { get; set; }
        public Player(string name, string lastName, int number, DateTime dateOfBirth, int userId)
        {
            PlayerId = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            Number = number;
            DateOfBirth = dateOfBirth;
            Age = CalculateAge();
        }

        public Player(string name, string lastName, int number, DateTime dateOfBirth)
        {
            Name = name;
            LastName = lastName;
            Number = number;
            DateOfBirth = dateOfBirth;
        }

        public Player()
        {
            PlayerId = Guid.NewGuid();
        }

        private int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > today.AddYears(-age))
                age--;
            return age;
        }

    }
}
