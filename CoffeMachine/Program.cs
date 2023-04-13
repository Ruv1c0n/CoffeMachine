using CoffeMachine.Beverage;
using CoffeMachine.CoffeMachine;
using CoffeMachine.Condiments;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CCoffeMachine cm = new CCoffeMachine();
            cm.Start();
            BeverageBase es = new Espresso();
            BeverageBase ess = new ConSugar(es);
            print(ess);
        }
        private static void print(BeverageBase beverage)
        {
            Console.WriteLine("Напиток {0}, Цена {1}", beverage.GetDescription(), beverage.GetCost());
        }
    }
}