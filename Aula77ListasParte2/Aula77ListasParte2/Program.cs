using System;
using System.Collections.Generic;

namespace Aula77ListasParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            Console.WriteLine("---------- COMANDO Add ----------"); // Comando ADD adiciona ao final da lista
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Add("Suzan");
            lista.Add("Phil");
            lista.Add("May");
            lista.Add("Danny");
            lista.Add("Joy");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------- COMANDO Insert ----------"); // Comando INSERT insere em um determinado índice
            lista.Insert(2, "Marco");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------- COMANDO Count ----------");
            Console.WriteLine($"Tamanho da lista: {lista.Count}");

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO Find ----------"); // Encontra o primeiro elemento da lista de acordo com um predicado

            // O predicado pode ser uma função ou uma expressão lambda. Será usado uma função
            string primeiroElemento = lista.Find(VerificaPrimeiroElemento);
            Console.WriteLine($"Primeiro nome que começa com a letra A é: {primeiroElemento}");

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO FindLast ----------"); // Encontra o último elemento da lista de acordo com um predicado

            // O predicado pode ser uma função ou uma expressão lambda. Será usado uma expressão lambda
            string ultimoElemento = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Último nome que começa com a letra A é: {ultimoElemento}");

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO FindIndex ----------"); // Encontra o primeiro índice da lista de acordo com um predicado

            // O predicado pode ser uma função ou uma expressão lambda. Será usado uma função
            int primeiroIndice = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Primeiro índice que começa com a letra A é: {primeiroIndice}");

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO FindLastIndex ----------"); // Encontra o último índice da lista de acordo com um predicado

            // O predicado pode ser uma função ou uma expressão lambda. Será usado uma expressão lambda
            int ultimoIndice = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Último nome que começa com a letra A é: {ultimoIndice}");

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO FindAll ----------"); // Filtrar a lista de acordo com um predicado

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine($"A lista filtrada somente com os nomes que contém 5 caracteres:");

            foreach(string item in lista2)
            {
                Console.WriteLine(item);
            }

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO Remove ----------");

            lista.Remove("Alex");
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO RemoveAll ----------");

            lista.RemoveAll(x => x[0] == 'M');
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO RemoveAt ----------"); // Remove um elemento pela posição

            lista.RemoveAt(0);
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            // =============================================================================================================================================== //
            Console.WriteLine();
            Console.WriteLine("---------- COMANDO RemoveRange ----------"); // Remove um ou mais elementos através de um índice e uma contagem

            lista.RemoveRange(1, 3); // Remover a partir do índice 1, 3 elementos.
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public static bool VerificaPrimeiroElemento(string inicial)
        {
            return inicial[0] == 'A';
        }
    }
}
