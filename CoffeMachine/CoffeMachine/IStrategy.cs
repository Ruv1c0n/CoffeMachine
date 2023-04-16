using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    public interface IStrategy
    {
        public int Select(Dictionary<string, int> beverageCond, Dictionary<string, int> beverageSyrup = null);
    }
}
