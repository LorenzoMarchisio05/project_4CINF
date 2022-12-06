using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Es12_Email.Validators
{
    public static class NameValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^\p{L}{2,}",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool Validate(string input) => _validationRegex.IsMatch(input);

    }
}
