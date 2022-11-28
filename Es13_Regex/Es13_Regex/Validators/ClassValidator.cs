using Es13_Regex.Interface;
using System.Text.RegularExpressions;

namespace Es13_Regex
{
    public sealed class ClassValidator : IValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^[1-5][A-G](INF|MEC|ELT|TUR|AFM)$", 
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public bool Validate(string input) => _validationRegex.IsMatch(input.Replace(" ", ""));
    }
}
