namespace ControlledAccess
{
    public class Accountant : Employee
    {
        private string title = "Accountant";
        private Blacksmith delegateBlacksmith;
        public Accountant(string name, int age)
        {
            SetName(name);
            SetAge(age);
            SetTitle(title);
            XYZ.SaveEmployee(this);
        }

        public void Update (int value, params Employee[] employee)
        {
            foreach (Employee emp in employee) 
            {
                emp.SetSalary(value);
            } 
        }

    }
}
