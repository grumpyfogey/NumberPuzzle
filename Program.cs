using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberPuzzle
{
    /// <summary>
    /// <para>A little number puzzle.</para>
    /// <para>Arrange the numbers 1 to 9 in such a way that:</para>
    /// <para>a * bc = de   (bc means 10*b+c)</para>
    /// <para>       + fg</para>
    /// <para>       = hi</para>
    /// <para>The code for heap's algorithm can be found here: https://gist.github.com/fdeitelhoff/5052484 </para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var permutationsNumbers = numbers.Permute();

            int numberOfPermutation = 1;

            foreach (var permutation in permutationsNumbers)
            {
                List<int> listPermutation = permutation.ToList();

                int firstInt = listPermutation[0] * (10*listPermutation[1] + listPermutation[2]);
                int secondInt = 10 * listPermutation[3] + listPermutation[4];
                int thirdInt = 10 * listPermutation[5] + listPermutation[6];
                int fourthInt = 10 * listPermutation[7] + listPermutation[8];

                Console.Write("{0}\r", numberOfPermutation);

                if (firstInt == secondInt)
                {
                    if (secondInt + thirdInt == fourthInt)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", listPermutation[0],
                            listPermutation[1], listPermutation[2], listPermutation[3],
                            listPermutation[4], listPermutation[5], listPermutation[6],
                            listPermutation[7], listPermutation[8]);
                    }
                }

                numberOfPermutation++;
            }

            Console.ReadKey();

        }
    }
}
