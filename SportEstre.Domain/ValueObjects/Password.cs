using System.Text.RegularExpressions;

namespace ShopEstre.Domain.ValueObjects
{
    public partial record Password
    {
        private const string Pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";
        
        private Password(string value) => Value = value;

        public static Password? Create(string value)
        {
            if (string.IsNullOrEmpty(value) || !PasswordRegx().IsMatch(value))
            {
                return null;
            }

            return new Password(value);
        }

        public string Value { get; set; }

        [GeneratedRegex(Pattern)]
        private static partial Regex PasswordRegx();
    }
}
