using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    class ConSugar : CondimentsBase
    {
        private static double COST = 5;
        private static string descr = " + сахар 6гр";


        public ConSugar(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr;
        }
        public ConSugar()
        {
            DESCRIPTION = "Сахар";
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
        public override double Cost()
        {
            return 5;
        }
    }
}
