﻿using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class ConSugar : CondimentsBase
    {
        protected static string TYPE = "Опционально";
        private static double COST = 5;
        private static string descr = " + сахар 6гр";
        protected string out_description = "Сахар";


        public ConSugar(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr;
        }
        public ConSugar()
        {
            DESCRIPTION = "Сахар";
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
    }
}
