namespace CoffeMachine.Beverage
{
    class Doppio : BeverageBase
    {
        public Doppio()
        {
            DESCRIPTION = "Доппио";
        }

        public override double GetCost()
        {
            return 65;
        }
        public override double Cost()
        {
            return 65;
        }
    }
}
