using System;
using System.Collections.Generic;
namespace ZooManager
{
    public class Animal
    {
        public string emoji;
        public string species;
        public string name;
        public int reactionTime = 5;
        public List<string> prey = new List<string>();
        public List<string> predator = new List<string>();
        public int turnsCounter = 0;


        public Point location;

        public void ReportLocation()
        {
            Console.WriteLine($"I am at {location.x},{location.y}");
        }

        virtual public void Activate()
        {
            Console.WriteLine($"Animal {name} at {location.x},{location.y} activated");
            turnsCounter++;
            
            if(turnsCounter == 1)
            {
                Console.WriteLine($"The {name} has taken {turnsCounter} turn.");
            }
            else
            {
                Console.WriteLine($"The {name} has taken {turnsCounter} turns.");
            }
        }

        public void Hunt(List<string> prey, int dirt)
        {
            foreach (string preyAnimal in prey)
            {
                if (Game.Seek(location.x, location.y,dirt,Direction.up, preyAnimal) != 0)
                {
                    Game.Attack(this, Direction.up);
                }
                else if (Game.Seek(location.x, location.y, dirt, Direction.down, preyAnimal) != 0)
                {
                    Game.Attack(this, Direction.down);
                }
                else if (Game.Seek(location.x, location.y,dirt, Direction.left, preyAnimal) != 0)
                {
                    Game.Attack(this, Direction.left);
                }
                else if (Game.Seek(location.x, location.y,dirt, Direction.right, preyAnimal) != 0)
                {
                    Game.Attack(this, Direction.right);
                }
            }
                
        }

        public void Flee(List<string> predator, int dirt)
        {
            foreach (string predatorAnimal in predator)
            {
                if (Game.Seek(location.x, location.y,dirt,Direction.up, predatorAnimal) != 0)
                {
                    if (Game.Retreat(this, Direction.down)) return;
                }
                if (Game.Seek(location.x, location.y,dirt,Direction.down, predatorAnimal) != 0)
                {
                    if (Game.Retreat(this, Direction.up)) return;
                }
                if (Game.Seek(location.x, location.y, dirt, Direction.left, predatorAnimal) != 0)
                {
                    if (Game.Retreat(this, Direction.right)) return;
                }
                if (Game.Seek(location.x, location.y, dirt, Direction.right, predatorAnimal) != 0)
                {
                    if (Game.Retreat(this, Direction.left)) return;
                }
            }
                
        }

    }
}
