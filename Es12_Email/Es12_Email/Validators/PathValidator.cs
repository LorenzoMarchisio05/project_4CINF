using System.Text.RegularExpressions;

namespace Es12_Email.Validators
{
    public static class PathValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^[A-Z/]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool Validate(string input) => _validationRegex.IsMatch(input);

    }
}
