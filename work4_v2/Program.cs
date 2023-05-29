using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Employee[] employees = new Employee[10];
                employees[0] = new Employee("Косых Иван Андреевич", 1, 1000000000.0);
                employees[1] = new Employee("Комочков Денис Александрович", 2, 4000000.0);
                employees[2] = new Employee("Коробов Влад Андреевич", 3, 600.0);
                employees[3] = new Employee("Жуков Антон Павлович", 4, 4500000.0);
                employees[4] = new Employee("Шевченко Макар Николаевич", 5, 420000.0);
                employees[5] = new Employee("Логунов Данил", 1, 5500000.0);
                employees[6] = new Employee("Королёв Андрей", 2, 480000.0);
                employees[7] = new Employee("Ламтюгина Олеся", 3, 6500000000.0);
                employees[8] = new Employee("Калашников Пётр Витальевич", 4, 470000.0);
                employees[9] = new Employee("Ларин Данил", 5, 410000.0);

                Console.WriteLine("Общие расходы на заработную плату в месяц: " + Employee.TotalSalaryExpenses(employees));
                Console.WriteLine("Сотрудник с минимальной зарплатой: " + Employee.FindEmployeeWithMinSalary(employees).FullName);
                Console.WriteLine("Сотрудник с максимальной зарплатой: " + Employee.FindEmployeeWithMaxSalary(employees).FullName);

                int department = 2;
                Console.WriteLine("Средняя заработная плата по отделу {0}: {1}", department, Employee.AverageSalaryByDepartment(employees, department));

                double percentage = 10;
                Console.WriteLine("Повышение заработной платы в отделе {0} by {1}%:", department, percentage);
                Employee.IndexSalaryByDepartment(employees, department, percentage);
                Employee.PrintEmployees(Employee.GetAllEmployeesByDepartment(employees, department));

                Console.WriteLine("Сотрудники в разбивке по отделам {0}:", department);
                Employee.PrintEmployees(Employee.GetAllEmployeesByDepartment(employees, department));

                double salary = 5000;
                Employee.PrintEmployeesWithSalaryLessThan(employees, salary);
                Employee.PrintEmployeesWithSalaryGreaterThanOrEqualTo(employees, salary);
                Console.ReadKey();
            }
        }
    }
  }
