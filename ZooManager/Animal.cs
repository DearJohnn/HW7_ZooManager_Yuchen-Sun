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
        public List<string> prey = new List<string>();// Create a string list named prey to store all of the prey
        public List<string> predator = new List<string>();// Create a string list named predator to store all of the predator
        public int turnsCounter = 0;//Create a int named turnsCounter to count the number of this animal's turn


        public Point location;
        /*Print out the current animal's location
         * Is called by Game class
         * No parameters
         * No return
         */
        public void ReportLocation()
        {
            Console.WriteLine($"I am at {location.x},{location.y}");
        }

        /*Print the names and locations of the animals that have been active in the current turn
         *  Add ont to current animal's turnsCounter
         *  Is called by Game class
         *  No parameters
         *  No return
         */
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

        /*loop all of the current animal's prey and look for the prey within the search range
         * Called by each Animal subclass which can hunt
         * Pass two parameters one this the list of prey ,other one is the seek distence
         * No return
         */
        public void Hunt(List<string> prey, int dist)
        {
            foreach (string preyAnimal in prey)
            {
                if (Game.Seek(location.x, location.y,dist,Direction.up, preyAnimal) != 0)
                {
                    Game.Attack(this, Direction.up);
                }
                else if (Game.Seek(location.x, location.y, dist, Direction.down, preyAnimal) != 0)
                {
                    Game.Attack(this, Direction.down);
                }
                else if (Game.Seek(location.x, location.y,dist, Direction.left, preyAnimal) != 0)
                {
                    Game.Attack(this, Direction.left);
                }
                else if (Game.Seek(location.x, location.y,dist, Direction.right, preyAnimal) != 0)
                {
                    Game.Attack(this, Direction.right);
                }
            }
                
        }

        /*loop all of the current animal's predator and run away from the first predator animal can find
        * Called by each Animal subclass which can flee
        * Pass two parameters one is the list of predator , other one is the seek distence
        * No return
        */
        public void Flee(List<string> predator, int dist)
        {
            foreach (string predatorAnimal in predator)
            {
                if (Game.Seek(location.x, location.y,dist,Direction.up, predatorAnimal) != 0)
                {
                    if (Game.Retreat(this, Direction.down)) return;
                }
                if (Game.Seek(location.x, location.y,dist,Direction.down, predatorAnimal) != 0)
                {
                    if (Game.Retreat(this, Direction.up)) return;
                }
                if (Game.Seek(location.x, location.y, dist, Direction.left, predatorAnimal) != 0)
                {
                    if (Game.Retreat(this, Direction.right)) return;
                }
                if (Game.Seek(location.x, location.y, dist, Direction.right, predatorAnimal) != 0)
                {
                    if (Game.Retreat(this, Direction.left)) return;
                }
            }
                
        }

    }
}
