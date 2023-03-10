using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManager
{
    interface IPery
    {
        List<string> predators { get; set; }
        void Flee(List<string> predators, int distence);
    }
}
