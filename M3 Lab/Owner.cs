using ControlledAccess;
using System.Net.Mail;

namespace GeneralAccess
{
    public class Owner : Employee
    {
        private string title = "Owner";
        public Owner(string name, int age)
        {
            SetName(name);
            SetAge(age);
            SetTitle(title);
            XYZ.SaveEmployee(this);
        }

        public void Send (string msg, params Employee[] employee)
        {
            foreach (Employee e in employee) 
            {
                e.Receive (msg + " " + e.GetName());
            }
        }

    }
}
