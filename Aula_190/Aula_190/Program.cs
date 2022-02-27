using System;
using System.Globalization;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace Aula_190
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string aula = "Aula_190"; //Using file from last class this time
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0, 6);
            rootPath = rootPath.Remove(rootPath.IndexOf("Aula_"));
            rootPath = Path.Combine(rootPath, $"{aula}\\{aula}\\");
            string sourcePath = Path.Combine(rootPath, "");

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string folderItem in folders)
                {
                    Console.WriteLine(folderItem);
                }

                var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("\nFiles: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(sourcePath + "\\newfolder");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}