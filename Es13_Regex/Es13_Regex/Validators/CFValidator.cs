using Es13_Regex.Interface;
using System.Text.RegularExpressions;

namespace Es13_Regex
{
    public sealed class CFValidator : IValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^[A-Z]{6}\d{2}[ABCDEHLMPRST]\d{2}[A-Z]\d{3}[A-Z]$",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public bool Validate(string input) => _validationRegex.IsMatch(input);
    }
}
