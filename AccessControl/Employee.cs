using AccessControl;
using System;
using System.Diagnostics;

namespace ControlledAccess
{
    public class Employee
    {
        private string name;
        private int age;
        private string title;
        private int salary;
        private string[] messages;
        private int Likert = 0;
        public bool onHoliday = false;
        public Employee delegateEmployee;
        public int delegateScore;
        static public Company XYZ;

        public Employee()
        {
            if (XYZ == null)
            {
                XYZ = new Company();
            }
        }

        internal void SetSalary (int value)
        {
            this.salary = value;
        }

        public int GetSalary ()
        {
            return salary;
        }

        public void SetLikert(int val)
        {
            if (title == "Accountant" || title == "Blacksmith")
                this.Likert = val;
            Console.WriteLine("Likert Score for " + GetName() + " : " + val + "\n");
        }

        public int GetLikert()
        {
            return this.Likert;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName() 
        {
            return this.name;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetTitle(string title)
        {
            this.title = title;

            if (title == "Manager")
                SetSalary(50000);
            else if (title == "Accountant")
                SetSalary(45000);
            else
                SetSalary(35000);
        }
        public void Receive (string msg)
        {
            messages = new string[1];
            this.messages[0] = msg;
            for (int i = 0; i < messages.Length; i++)
            {
                Console.WriteLine("\nMessage from Craig: " + messages[i]);
                Console.WriteLine("\n");
            }
        }
        public void Delegate(int score, Employee employee, Employee emp)
        {
            if (onHoliday)
            {
                employee.delegateScore = score;
                employee.delegateEmployee = emp;
            }
            else
                Console.WriteLine("Cannot delegate duty\n");
        }
    }
}
