using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManager
{
    interface IPredator
    {
        List<string> preys { get; set; }//Create a List<string> to store the preys which can get and set
        void Hunt(List<string> preys, int distence);//Create a Hunt function all perdators can call
    }
}
