using System;
using System.Globalization;
using System.Reflection;
using System.IO;

namespace Aula_189
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string aula = "Aula_189";
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0, 6);
            rootPath = rootPath.Remove(rootPath.IndexOf("Aula_"));
            rootPath = Path.Combine(rootPath, $"{aula}\\{aula}\\");
            string sourcePath = Path.Combine(rootPath, "Files\\file01.txt");
            string outputPath = Path.Combine(rootPath, "Files\\file02.txt");

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(outputPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException ex) { Console.WriteLine("Error: " + ex); }
        }
    }
}