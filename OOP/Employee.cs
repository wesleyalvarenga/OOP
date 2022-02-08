using Resp = OOP.Responsibility.Responsibility;

namespace OOP
{
    public class Employee
    {
        private Resp Reponsabiblity { get; set; }
        public double BaseSalary { get; set; }

        public Employee(Resp responsibility, double baseSalary)
        {
            Reponsabiblity = responsibility;
            BaseSalary = baseSalary;
        }

        public double Calculation()
        {
            return Reponsabiblity._calculationRule.Calculation(this);
        }
    }
}