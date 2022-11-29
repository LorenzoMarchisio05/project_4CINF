using System.Text.RegularExpressions;

namespace Es12_Email.Validators
{
    public static class EmailValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^\p{L}+@\w+.\w+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool Validate(string input) => _validationRegex.IsMatch(input);

    }
}
