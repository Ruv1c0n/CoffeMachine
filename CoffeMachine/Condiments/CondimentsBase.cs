using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    //Основа для ингредиентов
    abstract class CondimentsBase : BeverageBase
    {
        public BeverageBase beverageBase;
    }
}
