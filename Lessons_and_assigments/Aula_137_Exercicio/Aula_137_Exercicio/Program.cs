using System;
using Aula_137_Exercicio.Entities;

namespace Aula_137_Exercicio
{
    class Program
    {

        static void Main(string[] args)
        {
            TaxPayerManager myTaxPayers = new TaxPayerManager();
            myTaxPayers.addTaxPayers();
            myTaxPayers.TotalTaxes();
        }

    }


}



