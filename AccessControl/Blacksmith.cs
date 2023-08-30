using ControlledAccess;
using System;
using System.Threading.Tasks;

namespace ControlledAccess
{
    public class Blacksmith : Employee
    {
        private string title = "Blacksmith";
        private Blacksmith delegateBlacksmith;
        Task task;
        public Blacksmith(string name, int age)
        {
            SetName(name);
            SetAge(age);
            SetTitle(title);
            XYZ.SaveEmployee(this);
        }

        public void Perform (Task task)
        {
            if (!onHoliday)
            {
                if (delegateBlacksmith != null)
                {
                    delegateBlacksmith.task.setTask("Complete");
                }
            }
                task.setTask("Complete");
        }

        public void Delegate(Task task, Blacksmith blacksmith)
        {
            if (onHoliday)
            {
                blacksmith.task = task;
                delegateBlacksmith = blacksmith;
            }
            else
                Console.WriteLine("Cannot delegate duty\n");
        }
    }
}
