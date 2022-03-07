using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_204.Services
{
    internal static class BrazilTaxService
    {
        public static double Tax(double amount)
        {
            if (amount <= 100.0)
                return amount * 0.2;
            else
                return amount * 0.15;
        }
    }
}
