using System;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace Aula_187
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string aula = "Aula_187";
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0, 6);
            rootPath = rootPath.Remove(rootPath.IndexOf("Aula_"));
            rootPath = Path.Combine(rootPath, $"{aula}\\{aula}\\");
            string sourcePath = Path.Combine(rootPath, "Files\\file01.txt");

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(sourcePath, FileMode.Open);
                sr = new StreamReader(fs);

                // Simpler way of opening files (doesn't need FileStream):
                //sr = File.OpenText(sourcePath);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
            }
            catch (IOException ex) { Console.WriteLine("Error: " + ex); }
            finally { if (sr != null) sr.Close(); if (fs != null) fs.Close(); }
        }
    }
}