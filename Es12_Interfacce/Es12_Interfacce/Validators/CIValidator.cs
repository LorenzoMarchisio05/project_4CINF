using System.Text.RegularExpressions;

namespace Es12_Interfacce.Validators
{
    public static class CIValidator
    {
        private static Regex _ciValidationRegex = new Regex(
            "^[a-z]{2}[1-9]{5}[a-z]{2}$", 
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public static bool Validate(string cardNumber)
        {
            return _ciValidationRegex.IsMatch(cardNumber);
        }
    }
}