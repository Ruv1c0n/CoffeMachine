namespace CoffeMachine.Beverage
{
    class HotChocolate : BeverageBase
    {
        public HotChocolate()
        {
            DESCRIPTION = "Горячий шоколад";
        }

        public override double GetCost()
        {
            return 120;
        }
        public override double Cost()
        {
            return 120;
        }
    }
}
