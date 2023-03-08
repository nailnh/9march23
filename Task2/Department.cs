using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2AcsM
{
    internal class Department
    {
        Employee[] employees = new Employee[0];
        Employee employee;
        public string Name;
        public int EmployeeLimit = 1;
        public double SalaryLimit = 250;

        public void AddEmployee()
        {
            Console.WriteLine("Enter the employee's name: ");
            string name = Console.ReadLine();

            while (!char.IsUpper(name[0]))
            {
                Console.WriteLine("The first letter should be capitalised!");
                name = Console.ReadLine();
            }

            while (char.IsDigit(name[0]))
            {
                Console.WriteLine("The name cannot contain any digits");
                name = Console.ReadLine();
                name = employee.Name;
            }
            Console.WriteLine("Enter the employee's surname: ");
            string surname = Console.ReadLine();

            while (!char.IsUpper(name[0]))
            {
                Console.WriteLine("The first letter should be capitalised!");
                surname = Console.ReadLine();
            }

            while (char.IsDigit(name[0]))
            {
                Console.WriteLine("The surname cannot contain any digits");
                surname = Console.ReadLine();
                surname = employee.Surname;
            }


            Console.WriteLine("Enter the employee's salary: ");
            double salary = double.Parse(Console.ReadLine());

            while (salary < SalaryLimit)
            {
                Console.WriteLine("Minimum salary is 250, try to put correct amount!");
                salary = double.Parse(Console.ReadLine());
                salary = employee.Salary;
            }

            if (employees.Length < EmployeeLimit)
            {
                employee = new Employee(name, surname, salary);
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
            else
            {
                Console.WriteLine($"The empleyee limit is {EmployeeLimit}");
            }


        }
        public void ShowEmployees()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("\n\n**OUTPUT**\n\n");
                Console.WriteLine($"Employee Name: {employee.Name}\nEmployee Surname: {employee.Surname}\nEmpleyee Salary: {employee.Salary}");

            }
        }
    }
}
