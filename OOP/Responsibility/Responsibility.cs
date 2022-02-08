using OOP.CalculationRules.Interface;

namespace OOP.Responsibility
{
    public abstract class Responsibility
    {
        public ICalculationRule _calculationRule { get; private set; }
        
        protected Responsibility(ICalculationRule calculationRule)
        {
            _calculationRule = calculationRule;
        }
    }
}
