using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    internal class SyrupCaramel : ConSyrup
    {
        protected static string SYRUP_TYPE = "Карамель";

        public SyrupCaramel()
        {
            DESCRIPTION = "Карамельный";
        }

        public SyrupCaramel(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr + "(" + SYRUP_TYPE + ")";
        }

    }
}
