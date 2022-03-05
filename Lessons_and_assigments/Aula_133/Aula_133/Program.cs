using System;
using System.Globalization;
using Aula_133.Entities;

namespace Aula_133
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            productManager.addProducts();
            productManager.PriceTags();

        }
    }
}
