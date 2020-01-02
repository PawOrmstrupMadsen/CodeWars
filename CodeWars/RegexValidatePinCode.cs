using System.Linq;

namespace CodeWars
{
    public static class RegexValidatePinCode
    {
        // My way
        public static bool ValidatePin(string pin) => pin.Any(c => !char.IsDigit(c)) ? false : pin.Length == 4 || pin.Length == 6;

        //public static bool ValidatePin(string pin)
        //{
        //    return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
        //}
    }
}
