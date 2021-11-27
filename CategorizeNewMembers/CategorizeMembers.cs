using System.Collections.Generic;
using System.Linq;

namespace CodeKata.CategorizeNewMembers
{
    public class CategorizeMembers
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> result = new List<string>();

            foreach (int[] element in data)
            {
                result.Add(IsSenior(element));
            }

            return result;
        }

        private static string IsSenior(int[] member)
        {
            if (member[0] >= 55 && member[1] > 7)
                return "Senior";
            return "Open";
        }
    }
}
