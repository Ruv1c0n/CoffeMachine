using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    //Основа для сиропов
    class ConSyrup : CondimentsBase
    {
        protected static string SYRUP_TYPE = "";
        protected static double COST = 5;
        protected static string descr = " + порция сиропа 10гр";

        public ConSyrup()
        {
            DESCRIPTION = "Сироп";
        }
        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
        public override double Cost()
        {
            return 5;
        }
    }
}
