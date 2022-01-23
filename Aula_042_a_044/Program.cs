using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto product01 = new Produto();
            product01.AskInfo();
            //product01.PrintInfo();
            Console.WriteLine(product01);
            product01.AdicionarProdutos();
            product01.RemoverProdutos();

        }
    }
}