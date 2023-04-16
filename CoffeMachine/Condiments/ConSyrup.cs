using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    abstract class ConSyrup : CondimentsBase
    {
        protected static string SYRUP_TYPE = "";
        protected static string TYPE = "Опционально";
        protected static double COST = 5;
        protected static string descr = " + порция сиропа 10гр";
    }
}
