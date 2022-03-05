using System;
using System.Globalization;
using System.Reflection;
using System.IO;

namespace Aula_188
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string aula = "Aula_187"; //Using file from last class this time
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0, 6);
            rootPath = rootPath.Remove(rootPath.IndexOf("Aula_"));
            rootPath = Path.Combine(rootPath, $"{aula}\\{aula}\\");
            string sourcePath = Path.Combine(rootPath, "Files\\file01.txt");

            //try
            //{
            //    using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream) { Console.WriteLine(sr.ReadLine()); }
            //        }
            //    }
            //}
            //catch (IOException ex) { Console.WriteLine("Error: " + ex); }

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}