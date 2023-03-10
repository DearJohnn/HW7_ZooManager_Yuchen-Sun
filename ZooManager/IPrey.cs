using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManager
{
    interface IPrey
    {
        List<string> predators { get; set; }//Create a List<string> to store the predators which can get and set
        void Flee(List<string> predators, int distence);//Create a Flee function all preys can call
    }
}
