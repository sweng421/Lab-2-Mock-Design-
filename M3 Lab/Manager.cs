using ControlledAccess;
using System;

namespace GeneralAccess
{
    public class Manager : Employee
    {
        private string title = "Manager";
        private Blacksmith delegateBlacksmith;
        public Manager (string name, int age)
        {
            SetName (name);
            SetAge (age);
            SetTitle (title);
            XYZ.SaveEmployee (this);
        }
        public void Evaluate (Employee employee, int score)
        {
            if (!onHoliday)
            {
                if (delegateEmployee != null)
                {
                    delegateEmployee.SetLikert(delegateScore);
                }
                employee.SetLikert(score);
            }
            
        }
    }
}
