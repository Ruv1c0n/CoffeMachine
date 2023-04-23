using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    class SelectCondiments: IStrategy
    {
        public int Select(Dictionary<BeverageBase, int> Condiments, Dictionary<BeverageBase, int> Syrup=null)
        {

            foreach (var bev in Condiments)
            {
                Console.WriteLine("\t{0} - {1}", bev.Key.GetDescription(), bev.Value);
            }

            int num_condiment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); 

            if (num_condiment == 1)
            {
                foreach (var bev in Syrup)
                {
                    Console.WriteLine("\t{0} - {1}", bev.Key.GetDescription(), bev.Value);
                }
                num_condiment = Convert.ToInt32(Console.ReadLine());
            }

            capacity.Milk();

            return num_condiment;
        }
    }
}
