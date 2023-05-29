using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4_v2
{
    class Employee
    {
        private static int counter = 0;

        public int Id { get; }
        public string FullName { get; }
        public int Department { get; set; }
        public double Salary { get; set; }

        public Employee(string fullName, int department, double salary)
        {
            this.Id = ++counter;
            this.FullName = fullName;
            this.Department = department;
            this.Salary = salary;
        }

        public static double TotalSalaryExpenses(Employee[] employees)
        {
            double total = 0;
            foreach (Employee employee in employees)
            {
                total += employee.Salary;
            }
            return total;
        }

        public static Employee FindEmployeeWithMinSalary(Employee[] employees)
        {
            Employee employeeWithMinSalary = employees[0];
            foreach (Employee employee in employees)
            {
                if (employee.Salary < employeeWithMinSalary.Salary)
                {
                    employeeWithMinSalary = employee;
                }
            }
            return employeeWithMinSalary;
        }

        public static Employee FindEmployeeWithMaxSalary(Employee[] employees)
        {
            Employee employeeWithMaxSalary = employees[0];
            foreach (Employee employee in employees)
            {
                if (employee.Salary > employeeWithMaxSalary.Salary)
                {
                    employeeWithMaxSalary = employee;
                }
            }
            return employeeWithMaxSalary;
        }

        public static double AverageSalaryByDepartment(Employee[] employees, int department)
        {
            double total = 0;
            int count = 0;
            foreach (Employee employee in employees)
            {
                if (employee.Department == department)
                {
                    total += employee.Salary;
                    count++;
                }
            }
            return count != 0 ? total / count : 0;
        }

        public static void IndexSalaryByDepartment(Employee[] employees, int department, double percentage)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Department == department)
                {
                    employee.Salary += (employee.Salary * percentage) / 100;
                }
            }
        }

        public static Employee[] GetAllEmployeesByDepartment(Employee[] employees, int department)
        {
            int count = 0;
            foreach (Employee employee in employees)
            {
                if (employee.Department == department)
                {
                    count++;
                }
            }
            Employee[] employeesByDepartment = new Employee[count];
            int i = 0;
            foreach (Employee employee in employees)
            {
                if (employee.Department == department)
                {
                    employeesByDepartment[i] = employee;
                    i++;
                }
            }
            return employeesByDepartment;
        }

        public static void PrintEmployees(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Id: {0}, Полное имя: {1}, Зарплата: {2}", employee.Id, employee.FullName, employee.Salary);
            }
        }

        public static void PrintEmployeesWithSalaryLessThan(Employee[] employees, double salary)
        {
            Console.WriteLine("Сотрудники с зарплатой менее {0}:", salary);
            foreach (Employee employee in employees)
            {
                if (employee.Salary < salary)
                {
                    Console.WriteLine("Id: {0},Полное имя : {1}, Зарплата: {2}", employee.Id, employee.FullName, employee.Salary);
                }
            }
        }

        public static void PrintEmployeesWithSalaryGreaterThanOrEqualTo(Employee[] employees, double salary)
        {
            Console.WriteLine("Сотрудники с заработной платой, превышающей или равной {0}:", salary);
            foreach (Employee employee in employees)
            {
                if (employee.Salary >= salary)
                {
                    Console.WriteLine("Id: {0}, Полное имя: {1}, Зарплата: {2}", employee.Id, employee.FullName, employee.Salary);
                }
            }
        }
    }
}