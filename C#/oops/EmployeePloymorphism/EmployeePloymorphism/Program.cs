using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePloymorphism.Model;

namespace EmployeePloymorphism
{
    class Program
    {

        static void Main(string[] args)
        {
            Manager manager = new Manager(1234, "Ashwini", 2000);
            var type = manager;
            PrintSalaryInfo(manager);

            Developer developer = new Developer(5678, "Harshada", 3000);
            var typed = developer;
            PrintSalaryInfo(developer);

            Accountant accountant = new Accountant(9012, "Dipesh", 1000);
            var typea = accountant;
            PrintSalaryInfo(accountant);

            Console.ReadLine();
        }

        public static void PrintSalaryInfo(Employee employee)
        {
            Console.WriteLine("Employee No." + employee.EmpNo);
            Console.WriteLine("Name :" + employee.EmpName);
            Console.WriteLine("Basic Salary:" + employee.Getbasic);
            Console.WriteLine("Net Salary :" + employee.CalculateNetSalary());
            Console.WriteLine("Employee Role:" + employee.Designation());
            Console.WriteLine("GetHashCode :" + employee.GetHashCode());
            Console.WriteLine("GetType :" + employee.GetType());

            if (employee is Manager)
            {
                Manager m = employee as Manager;
                Console.WriteLine("HRA Amt:" + m.HraAmt);
                Console.WriteLine("Ta Amt:" + m.TaAmt);
                Console.WriteLine("Da Amt:" + m.DaAmt);
            }

            if (employee is Developer)
            {
                Developer d = employee as Developer;
                Console.WriteLine("Da Amt" + d.DaAmt);
                Console.WriteLine("Insentive Amt" + d.InsentiveAmt);
            }

            if (employee is Accountant)
            {
                Accountant a = employee as Accountant;
                Console.WriteLine("Da Amt" + a.PerkAmt);
            }
        }
    }
}
