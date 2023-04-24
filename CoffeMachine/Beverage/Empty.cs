using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    //Пустой элемент для обхода обработки исключений
    class Empty : BeverageBase
    {
        public Empty()
        {
            DESCRIPTION = "Пусто";
        }
        public override double GetCost()
        {
            return 0;
        }
        public override double Cost()
        {
            return 0;
        }
    }
}
