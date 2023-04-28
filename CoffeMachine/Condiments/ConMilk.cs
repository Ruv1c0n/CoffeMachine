using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    class ConMilk : CondimentsBase
    {
        private static double COST = 20;
        private static string descr = " + молоко 100мл";

        public ConMilk(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr;
        }

        public ConMilk()
        {
            DESCRIPTION = "Молоко";
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
        public override double Cost()
        {
            return 20;
        }
    }
}
