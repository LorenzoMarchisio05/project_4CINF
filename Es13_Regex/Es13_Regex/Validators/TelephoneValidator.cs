using Es13_Regex.Interface;
using System.Text.RegularExpressions;

namespace Es13_Regex
{
    public sealed class TelephoneValidator : IValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^\d{9,10}$",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public bool Validate(string input) => _validationRegex.IsMatch(input);
    }
}
