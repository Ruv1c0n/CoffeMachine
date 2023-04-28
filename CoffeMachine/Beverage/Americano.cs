namespace CoffeMachine.Beverage
{
    class Americano : BeverageBase
    {
        public Americano()
        {
            DESCRIPTION = "Американо";
        }

        public override double Cost()
        {
            return 50;
        }

        public override double GetCost()
        {
            return 50;
        }
    }
}
