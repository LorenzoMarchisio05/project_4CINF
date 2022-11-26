using System.Text.RegularExpressions;

namespace Es12_Interfacce.Validators
{
    public static class AnagraphValidator
    {
        private static Regex _namingValidationRegex = new Regex(
            @"^[\p{L} ,.'-]{2,}$", 
            RegexOptions.Compiled | RegexOptions.IgnoreCase);


        public static bool Validate(string value)
        {
            return _namingValidationRegex.IsMatch(value);
        }
    }
}