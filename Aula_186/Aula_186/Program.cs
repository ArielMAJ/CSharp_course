using System;
using System.IO;
using System.Reflection;

namespace Aula_186
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string aula = "Aula_186";
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0,6);
            rootPath = rootPath.Remove(rootPath.IndexOf("Aula_"));
            rootPath = Path.Combine(rootPath, $"{aula}\\{aula}\\");
            Console.WriteLine(rootPath);

            string sourcePath = Path.Combine(rootPath, "Files\\file01.txt"); // Relative path to the main directory in the second argument.
            Console.WriteLine(sourcePath);
            string targetPath = Path.Combine(rootPath, "Files\\file02.txt"); // Relative path to the main directory in the second argument.
            Console.WriteLine(targetPath);

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
            }
            catch (IOException ex) { Console.WriteLine("IOException: " + ex.Message); }
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines) { Console.WriteLine(line); }
        }
    }
}