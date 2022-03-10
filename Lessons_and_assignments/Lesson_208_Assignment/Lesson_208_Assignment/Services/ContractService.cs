using System;
using System.Collections.Generic;
using Lesson_208_Assignment.Entities;

namespace Lesson_208_Assignment.Services
{
    internal static class ContractService
    {
        public static void ProcessContract(Contract contract, IPaymentService paymentService, int n_installments)
        {
            double baseInstallmentValue = contract.TotalValue / n_installments;

            for (int months = 1; months <= n_installments; months++)
            {
                double installmentValue =
                    baseInstallmentValue +
                    paymentService.SimpleInterest(baseInstallmentValue, months); // This is how the instructor does.
                 // paymentService.SimpleInterest(baseInstallmentValue) * months; // This is how I originally did.
                 // (there would be no "months" variable in the method paymentService.SimpleInterest)

                installmentValue += paymentService.PaymentFee(installmentValue);

                contract.Installments.Add(new Installment(contract.Date.AddMonths(months), installmentValue));
            }
        }
    }
}
