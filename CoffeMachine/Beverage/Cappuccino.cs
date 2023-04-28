namespace CoffeMachine.Beverage
{
    class Cappuccino : BeverageBase
    {
        public Cappuccino()
        {
            DESCRIPTION = "Каппучино";
        }

        public override double GetCost()
        {
            return 60;
        }
        public override double Cost()
        {
            return 60;
        }
    }
}
