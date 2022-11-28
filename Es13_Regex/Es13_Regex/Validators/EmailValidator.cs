using Es13_Regex.Interface;
using System.Text.RegularExpressions;

namespace Es13_Regex
{
    public class EmailValidator : IValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^[A-Z]{1,}@[A-Z]{1,}.[A-Z]{1,}$",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public bool Validate(string input) => _validationRegex.IsMatch(input);
    }
}