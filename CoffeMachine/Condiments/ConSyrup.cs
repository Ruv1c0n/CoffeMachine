using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class ConSyrup : CondimentsBase
    {
        protected static string SYRUP_TYPE = "";
        protected static string TYPE = "Опционально";
        protected static double COST = 5;
        protected static string descr = " + порция сиропа 10гр";
        protected string out_description = "Сироп";

        public ConSyrup()
        {
            DESCRIPTION = "Сироп";
        }
        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
    }
}
