using System.Collections.Generic;

namespace CodeKata.ListFiltering
{
    public static class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> integers = new List<int>();

            foreach (object e in listOfItems)
            {
                if (e is int)
                {
                    integers.Add((int)e);
                }
            }
            return integers;
        }
    }
}
