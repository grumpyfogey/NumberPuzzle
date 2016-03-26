using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberPuzzle
{
    /// <summary>
    /// Taken from:https://gist.github.com/fdeitelhoff/5052484
    /// </summary>
    static class Permutation
    {
        public static IEnumerable<IEnumerable<T>> Permute<T>(this IList<T> v)
        {
            ICollection<IList<T>> result = new List<IList<T>>();

            Permute(v, v.Count, result);

            return result;
        }

        private static void Permute<T>(IList<T> v, int n, ICollection<IList<T>> result)
        {
            if (n == 1)
            {
                result.Add(new List<T>(v));
            }
            else
            {
                for (var i = 0; i < n; i++)
                {
                    Permute(v, n - 1, result);
                    Swap(v, n % 2 == 1 ? 0 : i, n - 1);
                }
            }
        }

        private static void Swap<T>(IList<T> v, int i, int j)
        {
            var t = v[i];
            v[i] = v[j];
            v[j] = t;
        }
    }
}
