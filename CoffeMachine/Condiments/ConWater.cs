﻿using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class ConWater : CondimentsBase
    {
        protected static string TYPE = "Основа";
        private static double COST = 7;
        private static string DESCRIPTION = " + вода 100мл";
        BeverageBase beverageBase;

        public ConWater(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + DESCRIPTION;
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
    }
}