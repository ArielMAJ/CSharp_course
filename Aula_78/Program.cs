using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager group01 = new EmployeeManager();
            group01.AddEmployees();
            group01.IncreaseSalary();
            Console.WriteLine(group01);
        }
    }
    class EmployeeManager
    {
        public List<Employee> EmployeeList { get; private set; }

        public EmployeeManager(){
            EmployeeList = new List<Employee>();
        }

        public void AddEmployees()
        {

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i}:");
                Employee emp = new Employee();
                int Index = EmployeeList.FindIndex(x => x.Id > emp.Id);

                if ( Index == -1)
                    EmployeeList.Add(emp);
                else
                    EmployeeList.Insert(Index, emp);
            }

        }
        public void IncreaseSalary()
        {
            Console.Write("\nEnter the employee ID that will have salary increase: ");
            int ID = int.Parse(Console.ReadLine());
            int Pos = EmployeeList.FindIndex(x => x.Id == ID);
            if (Pos == -1)
            {
                Console.WriteLine("This Id does not exist!");
                return;
            }
            Console.Write("Enter the percentage: ");
            double Percent = double.Parse(Console.ReadLine());
            EmployeeList[Pos].Salary *= Percent/100.0;
        }

        public override string ToString()
        {
            string employees = "";
            foreach (Employee employee in EmployeeList)
            {
                employees += "\n"+employee;
            }

            return $"List of employees:{employees}";
        }
    }

    class Employee
    {
        private double _salary;

        public string Name { get; private set; }
        public int Id { get; private set; }


        public Employee()
        {
            Console.Write("Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Salary: ");
            _salary = double.Parse(Console.ReadLine());
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;
            }
        }
        public override string ToString()
        {
            return $"{Id}, {Name}, {_salary.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}