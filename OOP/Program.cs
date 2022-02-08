using OOP.CalculationRules;
using OOP.Responsibility;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var dev = new Employee(new Developer(new DeveloperCalculation()), 7598);
            Console.WriteLine($"Developer Sallary: {dev.Calculation()}");

            var devops = new Employee(new DevOps(new DevOpsCalculation()), 5000);
            Console.WriteLine($"DevOps Sallary: {devops.Calculation()}");

            var tester = new Employee(new Tester(new TesterCalculation()), 3600);
            Console.WriteLine($"Tester Sallary: {tester.Calculation()}");

            Console.ReadKey();
        }
    }
}
