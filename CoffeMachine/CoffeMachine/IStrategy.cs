using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    public interface IStrategy
    {
        int Select(Dictionary<string, int> list);
    }
}
