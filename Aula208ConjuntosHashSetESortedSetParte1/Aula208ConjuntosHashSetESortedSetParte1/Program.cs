using System;
using System.Collections.Generic;

namespace Aula208ConjuntosHashSetESortedSetParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine(set.Contains("Computer"));

            Console.WriteLine();

            foreach (string hashSet in set)
            {
                Console.WriteLine(hashSet);
            }
        }
    }
}
