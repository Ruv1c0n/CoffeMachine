namespace CoffeMachine.Beverage
{
    class Cocoa : BeverageBase
    {
        public Cocoa()
        {
            DESCRIPTION = "Какао";
        }

        public override double GetCost()
        {
            return 145;
        }
        public override double Cost()
        {
            return 145;
        }
    }
}
