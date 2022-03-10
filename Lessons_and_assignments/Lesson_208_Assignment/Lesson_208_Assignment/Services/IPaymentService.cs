using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_208_Assignment.Services
{
    interface IPaymentService
    {
        double SimpleInterest(double amount, int months);
        double PaymentFee(double amount);
    }
}
