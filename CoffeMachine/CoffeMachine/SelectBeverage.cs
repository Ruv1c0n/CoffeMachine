using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    class SelectBeverage : IStrategy
    {
        public int Select(Dictionary<string, int> Beverage, Dictionary<string, int> list2)
        {
            foreach (var bev in Beverage)
            {
                Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value);
            }
            int drink = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return drink;
        }
    }
}
