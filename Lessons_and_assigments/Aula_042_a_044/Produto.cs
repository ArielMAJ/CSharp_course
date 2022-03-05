using System;
using System.Globalization;

namespace Course
{
    class Produto
    {
        string? Nome;
        double Preco;
        int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\nNome: {Nome}\n" +
                $"Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Quantidade: {Quantidade}\n" +
                $"Valor total em estoque: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public void AskInfo()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Preço: ");
            Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos()
        {
            Console.Write($"\nProduto: {Nome}\n" +
                $"Digite quantos deseja adicionar ao estoque: ");
            Quantidade += int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //PrintInfo();
            Console.WriteLine(ToString());
        }
        public void RemoverProdutos()
        {
            Console.Write($"\nProduto: {Nome}\n" +
                $"Digite quantos deseja remover do estoque: ");
            Quantidade -= int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //PrintInfo();
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}\n" +
                $"Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Quantidade: {Quantidade}\n" +
                $"Valor total em estoque: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}