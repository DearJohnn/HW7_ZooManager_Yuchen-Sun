using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManager
{
    public class Chick: Bird
    {
        public Chick(string name)
        {
            emoji = "🐥";
            species = "chick";
            this.name = name;
            reactionTime = new Random().Next(6, 11);
            predator = new List<string>() { "cat" };
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a chick.");
            Flee(predator,1);
            if (turnsCounter == 4)
            {
                Game.GrowUp(this);
            }
        }
    }
}
