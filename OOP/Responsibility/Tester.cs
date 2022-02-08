using OOP.CalculationRules.Interface;

namespace OOP.Responsibility
{
    public class Tester: Responsibility
    {
        public Tester(ICalculationRule calculationRule)
            :base(calculationRule)
        {

        }
    }
}
