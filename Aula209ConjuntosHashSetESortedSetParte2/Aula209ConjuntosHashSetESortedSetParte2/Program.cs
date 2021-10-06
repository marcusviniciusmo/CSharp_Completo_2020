using System;
using System.Collections.Generic;

namespace Aula209ConjuntosHashSetESortedSetParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedSetA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> sortedSetB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(sortedSetA);
            PrintCollection(sortedSetB);

            Console.WriteLine();

            // UNION
            Console.WriteLine("Union");
            SortedSet<int> sortedSetC = new SortedSet<int>(sortedSetA);
            sortedSetC.UnionWith(sortedSetB);
            PrintCollection(sortedSetC);

            Console.WriteLine();

            // INTERSECTION
            Console.WriteLine("Intersection:");
            SortedSet<int> sortedSetD = new SortedSet<int>(sortedSetA);
            sortedSetD.IntersectWith(sortedSetB);
            PrintCollection(sortedSetD);

            Console.WriteLine();

            // DIFFERENCE
            Console.WriteLine("Difference:");
            SortedSet<int> sortedSetE = new SortedSet<int>(sortedSetA);
            sortedSetE.ExceptWith(sortedSetB);
            PrintCollection(sortedSetE);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write($"{obj} ");
            }

            Console.WriteLine();
        }
    }
}
