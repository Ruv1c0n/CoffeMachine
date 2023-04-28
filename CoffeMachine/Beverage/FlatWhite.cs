namespace CoffeMachine.Beverage
{
    class FlatWhite : BeverageBase
    {
        public FlatWhite()
        {
            DESCRIPTION = "Флет Уайт";
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
