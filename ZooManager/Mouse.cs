using System;
using System.Collections.Generic;
namespace ZooManager
{
    public class Mouse : Animal
    {
        public Mouse(string name)
        {
            emoji = "🐭";
            species = "mouse";
            this.name = name;
            reactionTime = new Random().Next(1, 4);
            predator = new List<string>() { "raptor", "cat" };
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a mouse. Squeak.");
            Flee(predator,1);
        }

    }
}

