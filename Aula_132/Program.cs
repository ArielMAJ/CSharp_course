using System;
using System.Globalization;
using System.Collections.Generic;
using Aula_132.Entities;

namespace Aula_132
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            employeeManager.addEmployees();
            employeeManager.Payments();

        }
    }
}