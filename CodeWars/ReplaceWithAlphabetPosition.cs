using System;
using System.Linq;

namespace CodeWars
{
    public static class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            // My way :)
            // return string.Join(" ", text.Select(c => Char.ToUpper(c) - 64).Where(n => n > 0 && n < 27));
                        
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
    }
}
