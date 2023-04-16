using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    class SelectCondiments: IStrategy
    {
        public int Select(Dictionary<string, int> beverageCond, Dictionary<string, int> beverageSyrup=null)
        {

            foreach (var bev in beverageCond)
            {
                Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value);
            }

            int num_condiment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); 

            if (num_condiment == 1)
            {
                foreach (var bev in beverageSyrup)
                {
                    Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value);
                }
                num_condiment = Convert.ToInt32(Console.ReadLine());
            }
            
            return num_condiment;
        }
    }
}
