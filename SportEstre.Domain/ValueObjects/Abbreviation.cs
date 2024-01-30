namespace ShopEstre.Domain.ValueObjects
{
    public partial record Abbreviation
    {
        public string Value { get; }

        private Abbreviation(string value) => Value = value;

        public static Abbreviation Create(string value)
        {
            if (value.Length > 35) throw new ArgumentException("El nombre del equipo no puede tener más de 35 caracteres.");


            string[] words = value.Split(' ');

            if (words.Length == 1)
            {
                // Tomar las primeras tres letras o menos
                string abbreviation = value.Substring(0, Math.Min(3, value.Length)).ToUpper();
                return new Abbreviation(abbreviation);
            }
            else if (words.Length == 2)
            {
                // Tomar la primera letra de las dos palabras
                string abbreviation = $"{char.ToUpper(words[0][0])}{char.ToUpper(words[0][1])}{char.ToUpper(words[1][0])}";
                return new Abbreviation(abbreviation);
            }
            else
            {
                // Tomar las primeras letras de las tres primeras palabras
                string abbreviation = $"{char.ToUpper(words[0][0])}{char.ToUpper(words[1][0])}{char.ToUpper(words[2][0])}";
                return new Abbreviation(abbreviation);
            }
        }
    }
}
