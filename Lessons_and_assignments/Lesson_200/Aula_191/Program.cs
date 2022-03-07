using System;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace Aula_191
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string aula = "Aula_191";
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0, 6);
            rootPath = rootPath.Remove(rootPath.IndexOf("Aula_"));
            rootPath = Path.Combine(rootPath, $"{aula}\\{aula}\\");
            string sourcePath = Path.Combine(rootPath, "Files\\file01.txt");

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(sourcePath));
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetFileName: " + Path.GetFileName(sourcePath));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(sourcePath));
            Console.WriteLine("GetExtension: " + Path.GetExtension(sourcePath));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(sourcePath));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}