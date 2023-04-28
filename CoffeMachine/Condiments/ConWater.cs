using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    class ConWater : CondimentsBase
    {
        private static double COST = 7;
        private static string descr = " + вода 100мл";

        public ConWater(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr;
        }
        public ConWater()
        {
            DESCRIPTION = "Вода";
        }
        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
        public override double Cost()
        {
            return 7;
        }
    }
}
