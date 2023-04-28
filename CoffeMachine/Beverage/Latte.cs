namespace CoffeMachine.Beverage
{
    class Latte : BeverageBase
    {
        public Latte()
        {
            DESCRIPTION = "Латте";
        }

        public override double GetCost()
        {
            return 80;
        }
        public override double Cost()
        {
            return 80;
        }
    }
}
