using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    class SelectBeverage : IStrategy
    {
        public int Select(CoffeMashineCapacity capacity, Dictionary<string, int> beverage, Dictionary<string, int> list2)
        {
            foreach (var bev in beverage)
            {
                Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value);
            }
            int drink = Convert.ToInt32(Console.ReadLine());

            capacity.Espresso();

            Console.WriteLine();
            return drink;
        }
    }
}
