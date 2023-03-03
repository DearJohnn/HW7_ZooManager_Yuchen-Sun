using System;
using System.Collections.Generic;
namespace ZooManager
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            emoji = "🐱";
            species = "cat";
            this.name = name;
            reactionTime = new Random().Next(1, 6); 
            prey = new List<string>() { "mouse" ,"chick"};
            predator = new List<string>() { "raptor" };
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a cat. Meow.");
            Flee(predator,1);
            Hunt(prey,1);
           
        }
        
    }
}

