using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    internal class SyrupChocolate : ConSyrup
    {
        protected static string SYRUP_TYPE = "Шоколадный";


        public SyrupChocolate(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr + "(" + SYRUP_TYPE + ")";
        }
        public SyrupChocolate()
        {
            DESCRIPTION = "Шоколадный";
        }

    }
}
