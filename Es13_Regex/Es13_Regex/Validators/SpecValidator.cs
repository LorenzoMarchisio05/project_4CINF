using Es13_Regex.Interface;
using System.Text.RegularExpressions;

namespace Es13_Regex
{
    public sealed class SpecValidator : IValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^(INF|MEC|ELT|TUR|AFM)$", 
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public bool Validate(string input) => _validationRegex.IsMatch(input);
    }
}
