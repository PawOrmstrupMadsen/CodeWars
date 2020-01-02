using System.Linq;

namespace CodeWars
{
    public static class RegexValidatePinCode
    {
        public static bool ValidatePin(string pin) => pin.Any(c => !char.IsDigit(c)) ? false : pin.Length == 4 || pin.Length == 6;
    }
}
