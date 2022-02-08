using OOP.CalculationRules.Interface;

namespace OOP.Responsibility
{
    public class Developer : Responsibility
    {
        public Developer(ICalculationRule calculationRule) 
            : base(calculationRule)
        {

        }
    }
}
