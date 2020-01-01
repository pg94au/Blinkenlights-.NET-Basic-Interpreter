using System;
using System.Collections.Generic;
using System.Linq;

namespace Blinkenlights.Basic.App
{
    // TODO: Perhaps see if there is another efficient way to do this in .NET?
    // based on http://stackoverflow.com/a/3486820/1858296
    public static class SortedDictionaryExtensions
    {
        private static Tuple<int, int> GetPossibleIndices<TKey, TValue>(SortedDictionary<TKey, TValue> dictionary, TKey key, bool strictlyDifferent, out List<TKey> list)
        {
            list = dictionary.Keys.ToList();
            int index = list.BinarySearch(key, dictionary.Comparer);
            if (index >= 0)
            {
                // exists
                if (strictlyDifferent)
                    return Tuple.Create(index - 1, index + 1);
                else
                    return Tuple.Create(index, index);
            }
            else
            {
                // doesn't exist
                int indexOfBiggerNeighbour = ~index; //bitwise complement of the return value

                if (indexOfBiggerNeighbour == list.Count)
                {
                    // bigger than all elements
                    return Tuple.Create(list.Count - 1, list.Count);
                }
                else if (indexOfBiggerNeighbour == 0)
                {
                    // smaller than all elements
                    return Tuple.Create(-1, 0);
                }
                else
                {
                    // Between 2 elements
                    int indexOfSmallerNeighbour = indexOfBiggerNeighbour - 1;
                    return Tuple.Create(indexOfSmallerNeighbour, indexOfBiggerNeighbour);
                }
            }
        }

        public static TKey HigherKey<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
        {
            List<TKey> list;
            var indices = GetPossibleIndices(dictionary, key, true, out list);
            if (indices.Item2 == list.Count)
                return default(TKey);

            return list[indices.Item2];
        }
    }
}
