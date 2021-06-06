using System;
using System.IO;

namespace Aula191Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\marcu\source\repos\Aula191Path\file01.txt";

            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
            Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
            Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");
            Console.WriteLine();
        }
    }
}
