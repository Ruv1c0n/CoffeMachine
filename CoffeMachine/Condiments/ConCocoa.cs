using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    class ConCocoa : CondimentsBase
    {
        private static double COST = 120;
        private static string descr = " + порция какао 7гр";

        public ConCocoa(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr;
        }
        public ConCocoa()
        {
            DESCRIPTION = "Какао";
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
        public override double Cost()
        {
            return 120;
        }
    }
}
