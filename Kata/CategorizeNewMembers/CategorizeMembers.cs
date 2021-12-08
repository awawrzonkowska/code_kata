using System.Collections.Generic;
using System.Linq;

namespace CodeKata.CategorizeNewMembers
{
    public class CategorizeMembers
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(x => IsSenior(x)).ToList();
        }

        private static string IsSenior(int[] member)
        {
            if (member[0] >= 55 && member[1] > 7)
                return "Senior";
            return "Open";
        }
    }
}
