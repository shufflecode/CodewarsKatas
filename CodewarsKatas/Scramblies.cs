using System.Collections.Generic;
using System.Linq;

namespace CodewarsKatas
{
    public static class Scramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            var chars = str2.ToCharArray();
            var orgLenght = str2.Length;
            var hits = new List<char>();

            foreach (char t in chars)
            {
                if (!str1.Contains(t)) continue;
                hits.Add(t);
                str1 = str1.Remove(str1.IndexOf(t),1);
            }
            return hits.Count == orgLenght;
        }
    }
}