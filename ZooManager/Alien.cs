using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManager
{
    public class Alien: Being, IPredator
    {
        //Inherit from Being's fields and inherit from IPerdator
        public List<string> preys
        {
            get
            {
                return prey;
            }
            set
            {
                prey = preys;
            }
        }

        public Alien(string name)
        {
            emoji = "👽";
            species = "alien";
            this.name = name;
            reactionTime = 1;
            prey = new List<string>() { "mouse", "cat" ,"chick","raptor"};// Can Hunt all kind of Animals

        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a Alien.");
            Hunt(prey, 1);
        }
    }
}
