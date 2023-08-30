using AccessControl;
using ControlledAccess;
using System;

namespace GeneralAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            string onHoliday;
            Accountant jane = new Accountant("Jane", 56);
            Accountant joe = new Accountant("Joe", 41);
            Manager mary = new Manager ("Mary", 32);
            Manager john = new Manager("John", 30);
            Blacksmith jack = new Blacksmith("Jack", 35);
            Blacksmith katie = new Blacksmith("Katie", 28);
            Blacksmith amy = new Blacksmith("Amy", 25);
            Blacksmith lin = new Blacksmith("Lin", 23);
            Blacksmith greg = new Blacksmith("Greg", 22);
            Owner craig = new Owner("Craig", 45);

            Console.WriteLine("Is " + john.GetName() + " on holiday?");
            onHoliday = Console.In.ReadLine();

            Console.WriteLine("\nLikert Score for " + jack.GetName() + " : Not set");
            if (onHoliday == "Yes")
            {
                john.onHoliday = true;
                john.Delegate(4, mary, jack);
            }
            else
                john.Evaluate(jack, 4);

            Console.WriteLine("Likert Score for " + katie.GetName() + " : Not set");
            mary.Evaluate(katie, 5);

            Console.WriteLine(mary.GetName() + "'s salary: $" + mary.GetSalary());
            Console.WriteLine(jack.GetName() + "'s salary: $" + jack.GetSalary());
            craig.Send("Good Job", john, jane, jack);

            Owner.XYZ.GetEmployeeNames();
        }
    }
}
