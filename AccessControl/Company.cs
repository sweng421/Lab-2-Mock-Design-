using ControlledAccess;
using System;
using System.Linq;

namespace AccessControl
{
    public class Company
    {
        static Employee[] employees = new Employee[10];

        public void SaveEmployee (Employee emp)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                    continue;
                else
                {
                    employees[i] = emp;
                    break;
                }
            }
        }
        public void GetEmployeeNames()
        {
            Console.Write("Employees: ");
            foreach (Employee emp in employees)
            {
                if (emp == null)
                    break;
                else if (emp.GetName() == "Craig")
                    continue;
                else
                {
                    Console.WriteLine(emp.GetName());
                    Console.Write("\t   ");
                }
            }
            Console.WriteLine("\n");
            Console.Write("Owner: ");
            foreach (Employee emp in employees)
            {
                if (emp.GetName() == "Craig")
                {
                    Console.WriteLine(emp.GetName());
                    break;
                }
                else
                    continue;
            }
        }
    }
}
