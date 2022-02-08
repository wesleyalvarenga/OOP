using OOP.CalculationRules.Interface;

namespace OOP.Responsibility
{
    public class DevOps : Responsibility
    {
        public DevOps(ICalculationRule calculationRule)
            : base(calculationRule)
        {

        }
    }
}
