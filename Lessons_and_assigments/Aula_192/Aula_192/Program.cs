using System;
using System.Globalization;
using System.Reflection;
using Aula_192.Entities;

namespace Aula_192
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string aula = "Aula_192";
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0, 6);
            rootPath = rootPath.Remove(rootPath.IndexOf("Aula_"));
            rootPath = Path.Combine(rootPath, $"{aula}\\{aula}\\");

            string sourcePath = Path.Combine(rootPath, "sales.csv");
            string targetPath = Path.Combine(rootPath, "out");

            SummaryToCSV summaryToCSV = new SummaryToCSV();

            summaryToCSV.Read(sourcePath);
            summaryToCSV.WriteSummary(targetPath);
            Console.WriteLine("Done writing summary!");
        }
    }
}