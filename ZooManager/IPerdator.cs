using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManager
{
    interface IPerdator
    {
        List<string> preys { get; set; }
        void Hunt(List<string> preys, int distence);
    }
}
