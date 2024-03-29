﻿using System.Text.RegularExpressions;

namespace ShopEstre.Domain.ValueObjects
{
    public partial record PhoneNumber
    {
        private const string Pattern = @"^\d{10}$";

        private PhoneNumber(string value) => Value = value;

        public static PhoneNumber? Create(string value)
        {
            if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value)) return null;
            return new PhoneNumber(value);
        }

        public string Value { get; init; }

        [GeneratedRegex(Pattern)]
        private static partial Regex PhoneNumberRegex();
    }
}
