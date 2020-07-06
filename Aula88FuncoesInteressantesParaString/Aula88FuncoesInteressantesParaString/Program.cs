using System;

namespace Aula88FuncoesInteressantesParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";
            Console.WriteLine($"Original: {original}.");

            string maiuscula = original.ToUpper();  // Maíuscula
            Console.WriteLine($"ToUpper: {maiuscula}.");

            string minuscula = original.ToLower();  // Minúscula
            Console.WriteLine($"ToLower: {minuscula}.");

            string semEspaco = original.Trim(); // Sem Espaços no início e fim
            Console.WriteLine($"Trim: {semEspaco}.");

            int procura1 = original.IndexOf("bc"); // Busca o primeiro índice que contém a expressão
            Console.WriteLine($"IndexOf('bc'): índice {procura1}.");

            int procura2 = original.LastIndexOf("bc"); // Busca o último índice que contém a expressão
            Console.WriteLine($"LastIndexOf('bc'): índice {procura2}.");

            string recorte1 = original.Substring(3);    // Recorta um 'pedaço' da string a partir de um índice
            Console.WriteLine($"Substring(3): {recorte1}.");

            string recorte2 = original.Substring(2, 7); // Recorta um 'pedaço' da string a partir de um índice com um determinado número de elementos
            Console.WriteLine($"Substring(2, 7): {recorte2}.");

            string troca1 = original.Replace('a', 'x'); // Substitui todo caractere 'a' por x''
            Console.WriteLine($"Replace('a', 'x'): {troca1}.");

            string troca2 = original.Replace("abc", "xy");  // Substitui tida string 'abc' por 'xy'
            Console.WriteLine($"Replace('abc', 'xy'): {troca2}.");

            bool nula = string.IsNullOrEmpty(original); // Verifica se a string é vazia ou nula
            Console.WriteLine($"IsNullOrEmpty: {nula}.");

            bool espacoEmBranco = string.IsNullOrWhiteSpace(original); // Verifica se a string é nula ou foi preenchida com espaços em branco
            Console.WriteLine($"IsNullOrWhiteSpace: {espacoEmBranco}.");
        }
    }
}
