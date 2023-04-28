using CoffeMachine.Beverage;

namespace CoffeMachine.Condiments
{
    //Основа для ингредиентов
    abstract class CondimentsBase : BeverageBase
    {
        public BeverageBase beverageBase;
    }
}
