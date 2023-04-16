using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class SyrupVanila : ConSyrup
    {
        protected static string SYRUP_TYPE = "Ванильный";
        protected string out_description = "Ваниль";

        public SyrupVanila()
        {
        }

        public SyrupVanila(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr + "(" + SYRUP_TYPE + ")";
        }
    }
}
