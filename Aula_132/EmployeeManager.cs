using System;
using System.Globalization;
using Aula_132.Entities;

namespace Aula_132
{
    internal class EmployeeManager
    {
        public List<Employee> employees { get; protected set; } = new List<Employee>();
        
        public EmployeeManager()
        {
        }

        public void addEmployees()
        {
            Console.Write("Enter the number of employees: ");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amount; i++)
            {
                addEmployee(i);
            }

        }

        public void addEmployee(int i_th = 1)
        {
            Console.WriteLine($"Employee #{i_th} data:");
            Console.Write("Outsourced [Y/N]? ");
            bool outsourced = Console.ReadLine().ToLower() == "y";
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double vph = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (outsourced)
            {
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                employees.Add(new OutsourcedEmployee(name, hours, vph, additionalCharge));
            }
            else
            {
                employees.Add(new Employee(name, hours, vph));
            }
        }

        public void Payments()
        {
            Console.WriteLine("\nPAYMENTS:");
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }


    }
}
