using OOP.CalculationRules.Interface;

namespace OOP.CalculationRules
{
    public class DevOpsCalculation : ICalculationRule
    {
        public double Calculation(Employee employee)
        {
            return employee.BaseSalary * 0.98;
        }
    }
}
