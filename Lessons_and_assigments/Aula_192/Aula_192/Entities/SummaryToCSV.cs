using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Aula_192.Entities
{
    internal class SummaryToCSV
    {
        List<ProductSalesSummary> list;

        public SummaryToCSV()
        {
            list = new List<ProductSalesSummary>();
        }

        public void Read(string path)
        {

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] row = sr.ReadLine().Split(',');
                        string productName = row[0];
                        double price = double.Parse(row[1], CultureInfo.InvariantCulture);
                        int amount = int.Parse(row[2]);

                        Product product = new Product(productName, price);

                        list.Add(new ProductSalesSummary(product, amount));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        } 

        public void WriteSummary(string path)
        {

            Directory.CreateDirectory(path);

            try
            {

                using (StreamWriter sw = File.AppendText(path+"\\summary.csv"))
                {
                    foreach (ProductSalesSummary prod in list)
                    {
                        sw.WriteLine(prod.Summary());
                    }
                }
            }
            catch (IOException ex) { Console.WriteLine("Error: " + ex); }
        }
    }
}
