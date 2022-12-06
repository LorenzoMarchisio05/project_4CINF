using System.Text.RegularExpressions;

namespace Es12_Email.Validators
{
    public static class EmailValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool Validate(string input) => _validationRegex.IsMatch(input);

    }
}
