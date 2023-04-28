using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    //Пустой элемент для обхода обработки исключений
    class Empty : CondimentsBase
    {
        private static double COST = 0;

        public Empty()
        {
            DESCRIPTION = "Ничего";
        }

        public Empty(BeverageBase beverage)
        {
            BeverageBase bev = new Beverage.Empty();
            if (beverage != null)
            {
                this.beverageBase = beverage;
                DESCRIPTION = beverageBase.GetDescription();
            }
            else
            {
                this.beverageBase = bev;
            }
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
        public override double Cost()
        {
            return 0;
        }
    }
}
