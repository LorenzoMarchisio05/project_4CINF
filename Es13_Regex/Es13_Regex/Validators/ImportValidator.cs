using Es13_Regex.Interface;
using System.Text.RegularExpressions;

namespace Es13_Regex
{
    public sealed class ImportValidator : IValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^\d{1,},\d{2}$", 
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public bool Validate(string input) => _validationRegex.IsMatch(input);
    }
}
