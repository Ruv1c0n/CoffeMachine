namespace CoffeMachine.Beverage
{
    class Macciato : BeverageBase
    {
        public Macciato()
        {
            DESCRIPTION = "Маккиато";
        }

        public override double GetCost()
        {
            return 100;
        }
        public override double Cost()
        {
            return 100;
        }
    }
}
