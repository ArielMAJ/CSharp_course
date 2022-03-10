using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_208_Assignment.Services
{
    internal class BasicPaymentService : IPaymentService
    {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double SimpleInterest(double amount, int months)
        {
            return months * amount * MonthlyInterest;
        }
        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
