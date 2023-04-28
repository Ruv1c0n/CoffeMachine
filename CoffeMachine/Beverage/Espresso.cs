namespace CoffeMachine.Beverage
{
    class Espresso : BeverageBase
    {
        public Espresso()
        {
            DESCRIPTION = "Эспрессо";
        }

        public override double GetCost()
        {
            return 40;
        }
        public override double Cost()
        {
            return 40;
        }
    }
}
