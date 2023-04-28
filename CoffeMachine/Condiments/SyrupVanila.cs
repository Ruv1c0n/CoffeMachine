using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    class SyrupVanila : ConSyrup
    {
        protected static string SYRUP_TYPE = "Ванильный";

        public SyrupVanila()
        {
            DESCRIPTION = "Ванильный";
        }

        public SyrupVanila(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr + "(" + SYRUP_TYPE + ")";
        }
    }
}
