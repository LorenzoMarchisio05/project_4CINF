using System;
using System.Text.RegularExpressions;

namespace Es12_Interfacce
{
    public static class AnagraphValidator
    {
        private static Regex _namingValidationRegex = new Regex("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)");


        public static bool Validate(string value)
        {
            return _namingValidationRegex.IsMatch(value);
        }
    }
}