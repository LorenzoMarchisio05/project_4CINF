using System.Text.RegularExpressions;

namespace Es12_Email.Validators
{
    public static class TextValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^\p{L}{2,}$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool Validate(string input) => _validationRegex.IsMatch(input);

    }
}
