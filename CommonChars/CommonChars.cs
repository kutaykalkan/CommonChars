using System;
using System.Collections.Generic;

namespace CommonChars
{
    /// <summary>
    /// Time optimized function to find common chars btw 2 strings.
    /// </summary>
    public class CommonChars
    {
        public string FindCommonChars(string a, string b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException(@"Input strings can not be null");
            }
            HashSet<char> chars = new HashSet<char>();
            HashSet<char> result = new HashSet<char>();
            foreach (var c in a)
            {
                chars.Add(c);
            }

            foreach (var c in b)
            {
                if (chars.Contains(c))
                    result.Add(c);
            }
            return String.Join("", result);
        }
    }
}
