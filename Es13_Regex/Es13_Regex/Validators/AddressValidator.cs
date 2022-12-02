using Es13_Regex.Interface;
using System.Text.RegularExpressions;

namespace Es13_Regex
{
    public sealed class AddressValidator : IValidator
    {
        // via roma 21 
        // largo degli eroi
        // corso regina elena 2B
        // strada della creusa 39
        private static Regex _validationRegex = new Regex(
            @"^(VIA|LARGO|CORSO|STRADA|VIALE|PIAZZA)\P{L}+[A-Z]?)$", 
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public bool Validate(string input) => _validationRegex.IsMatch(input.Replace(" ", ""));
    }
}
