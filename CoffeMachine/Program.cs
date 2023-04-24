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
        }
    }
}