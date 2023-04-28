using CoffeMachine.Beverage;
using CoffeMachine.CoffeMachine;
using CoffeMachine.Condiments;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(55, 25);
            CCoffeMachine cm = new CCoffeMachine();
            cm.TurnOn();
            cm.TurnOff();
        }
    }
}