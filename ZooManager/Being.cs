using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManager
{
    public class Being
    {
        public string emoji;
        public string species;
        public string name;
        public int reactionTime = 5;
        public List<string> prey = new List<string>();// Create a string list named prey to store all of the prey
        public List<string> predator = new List<string>();// Create a string list named predator to store all of the predator
        public int turnsCounter = 0;//Create a int named turnsCounter to count the number of this Being's turn
        public bool actRecorder = false;


        public Point location;

        /*Print out the current Being's location
         * Is called by Game class
         * No parameters
         * No return
         */
        public void ReportLocation()
        {
            Console.WriteLine($"I am at {location.x},{location.y}");
        }

        /*Print the names and locations of the Beings that have been active in the current turn
         *  Add ont to current Being's turnsCounter
         *  Is called by Game class
         *  No parameters
         *  No return
         */
        virtual public void Activate()
        {
            Console.WriteLine($"Being {name} at {location.x},{location.y} activated");
            turnsCounter++;
            actRecorder = true;

            if (turnsCounter == 1)
            {
                Console.WriteLine($"The {name} has taken {turnsCounter} turn.");
            }
            else
            {
                Console.WriteLine($"The {name} has taken {turnsCounter} turns.");
            }
        }

        /*loop all of the current Being's prey and look for the prey within the search range
         * Called by each Being subclass which can hunt
         * Pass two parameters one this the list of prey ,other one is the seek distence
         * No return
         */
        public void Hunt(List<string> prey, int distence)
        {
            foreach (string preyBeing in prey)
            {
                if (Game.Seek(location.x, location.y, distence, Direction.up, preyBeing) != 0)
                {
                    Game.Attack(this, Direction.up);
                    break;
                }
                else if (Game.Seek(location.x, location.y, distence, Direction.down, preyBeing) != 0)
                {
                    Game.Attack(this, Direction.down);
                    break;
                }
                else if (Game.Seek(location.x, location.y, distence, Direction.left, preyBeing) != 0)
                {
                    Game.Attack(this, Direction.left);
                    break;
                }
                else if (Game.Seek(location.x, location.y, distence, Direction.right, preyBeing) != 0)
                {
                    Game.Attack(this, Direction.right);
                    break;
                }
            }

        }

        /*loop all of the current Being's predator and run away from the first predator Being can find
        * Called by each Being subclass which can flee
        * Pass two parameters one is the list of predator , other one is the seek distence
        * No return
        */
        public void Flee(List<string> predator, int distence)
        {
            foreach (string predatorBeing in predator)
            {
                if (Game.Seek(location.x, location.y, distence, Direction.up, predatorBeing) != 0)
                {
                    if (Game.Retreat(this, Direction.down)) return;
                }
                if (Game.Seek(location.x, location.y, distence, Direction.down, predatorBeing) != 0)
                {
                    if (Game.Retreat(this, Direction.up)) return;
                }
                if (Game.Seek(location.x, location.y, distence, Direction.left, predatorBeing) != 0)
                {
                    if (Game.Retreat(this, Direction.right)) return;
                }
                if (Game.Seek(location.x, location.y, distence, Direction.right, predatorBeing) != 0)
                {
                    if (Game.Retreat(this, Direction.left)) return;
                }
            }

        }

    }
}
