namespace CoffeMachine.Beverage
{
    //Основа для напитков
    public abstract class BeverageBase
    {
        protected string DESCRIPTION;
        public string GetDescription()
        {
            return DESCRIPTION;
        }

        //Возвращает общую цену напитка составленного от базы
        public abstract double GetCost();
        //Возвращает стоимость конкретного элемента
        public abstract double Cost();
    }
}
