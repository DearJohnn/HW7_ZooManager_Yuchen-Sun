using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManager
{
    public class Raptor: Bird
    {
        public Raptor(string name)
        {
            emoji = "🦅";
            species = "Raptor";
            this.name = name;
            reactionTime = 1;
            prey = new List<string>() { "mouse", "cat" };

        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a Raptor.");
            Hunt(prey,1);
        }
    }
}
