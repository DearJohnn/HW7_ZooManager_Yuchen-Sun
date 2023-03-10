using System;
using System.Collections.Generic;

namespace ZooManager
{
    public static class Game
    {
        static public int numCellsX = 4;
        static public int numCellsY = 4;

        static private int maxCellsX = 10;
        static private int maxCellsY = 10;


        static public List<List<Zone>> BeingZones = new List<List<Zone>>();
        static public Zone holdingPen = new Zone(-1, -1, null);
        static public List<Being> being = new List<Being>();

        /*Set up game
         * Called by index page
         * No paraemeters
         * No return
         */
        static public void SetUpGame()
        {
            for (var y = 0; y < numCellsY; y++)
            {
                List<Zone> rowList = new List<Zone>();
                for (var x = 0; x < numCellsX; x++) rowList.Add(new Zone(x, y, null));
                BeingZones.Add(rowList);
            }
        }

        /*Add a row or column to the game board
         * Called by index page
         * Pass one paraemeter direction enum
         * No return
         */
        static public void AddZones(Direction d)
        {
            if (d == Direction.down || d == Direction.up)
            {
                if (numCellsY >= maxCellsY) return; 
                List<Zone> rowList = new List<Zone>();
                for (var x = 0; x < numCellsX; x++)
                {
                    rowList.Add(new Zone(x, numCellsY, null));
                }
                numCellsY++;
                if (d == Direction.down) BeingZones.Add(rowList);
                
            }
            else 
            {
                if (numCellsX >= maxCellsX) return;
                for (var y = 0; y < numCellsY; y++)
                {
                    var rowList = BeingZones[y];
                    if (d == Direction.right) rowList.Add(new Zone(numCellsX, y, null));
                }
                numCellsX++;
            }
        }

        /*Get, take, and place the Being to the zone
         * Called by index page
         * Pass one paraemeter which is the Zone be clicked
         * No return
         */
        static public void ZoneClick(Zone clickedZone)
        {
            Console.Write("Got Being ");
            Console.WriteLine(clickedZone.emoji == "" ? "none" : clickedZone.emoji);
            Console.Write("Held Being is ");
            Console.WriteLine(holdingPen.emoji == "" ? "none" : holdingPen.emoji);
            if (clickedZone.occupant != null) clickedZone.occupant.ReportLocation();
            if (holdingPen.occupant == null && clickedZone.occupant != null)
            {
                Console.WriteLine("Taking " + clickedZone.emoji);
                holdingPen.occupant = clickedZone.occupant;
                holdingPen.occupant.location.x = -1;
                holdingPen.occupant.location.y = -1;
                holdingPen.occupant.turnsCounter = 0;//The turn counter returns to zero after it is held
                clickedZone.occupant = null;
                //ActivateBeings();
            }
            else if (holdingPen.occupant != null && clickedZone.occupant == null)
            {
                Console.WriteLine("Placing " + holdingPen.emoji);
                clickedZone.occupant = holdingPen.occupant;
                clickedZone.occupant.location = clickedZone.location;
                holdingPen.occupant = null;
                Console.WriteLine("Empty spot now holds: " + clickedZone.emoji);
                ActivateBeings();
            }
            else if (holdingPen.occupant != null && clickedZone.occupant != null)
            {
                Console.WriteLine("Could not place Being.");
            }
        }

        /*Create a Being object for holdingPen according to the species
         * Called by index page
         * Pass one paraemeter is the string of the species
         * No return
         */
        static public void AddBeingToHolding(string BeingType)
        {
            if (holdingPen.occupant != null) return;
            if (BeingType == "cat") holdingPen.occupant = new Cat("Fluffy");
            if (BeingType == "mouse") holdingPen.occupant = new Mouse("Squeaky");
            if (BeingType == "raptor") holdingPen.occupant = new Raptor("Birdy");
            if (BeingType == "chick") holdingPen.occupant = new Chick("Chicky");
            if (BeingType == "alien") holdingPen.occupant = new Alien("Alien");
            Console.WriteLine($"Holding pen occupant at {holdingPen.occupant.location.x},{holdingPen.occupant.location.y}");
            //ActivateBeings();
        }

        /*Let the Being activate every turn
         * Called by ZoneClick and AddBeingToHolding function
         * No paraemeter
         * No return
         */
        static private void ActivateBeings()
        {
            for (var r = 1; r < 11; r++) 
            {
                for (var y = 0; y < numCellsY; y++)
                {
                    for (var x = 0; x < numCellsX; x++)
                    {
                        var zone = BeingZones[y][x];
                        if (zone.occupant != null && zone.occupant.reactionTime == r)
                        {
                            being.Add(zone.occupant);
                            if (!zone.occupant.actRecorder)//Check if activate in current turn
                            {
                                zone.occupant.Activate();
                            }
                            else
                            {
                                continue;
                            }
                            
                        }
                    }
                }
            }
            ResetActRecorder(being);// Reset the actrecorder
        }

        /*The end of the turn restores the state of the animal to false of actrecorder
         * Called by ActivateBeings() function
         * Pass one parameter which is the List of all the Being on the board
         * No return
         */
        static private void ResetActRecorder(List<Being> being)
        {
            foreach(Being ani in being)
            {
                ani.actRecorder = false;
            }
        }

        /*Looking for the presence of a target Being (prey or predator) within a certain distance in four directions
         * Called by Being class
         * Pass 5 parameters: search center x coordinate, y coordinate, search distance, direction, and search target
         * return a int which is the distence between search center and target
         */
        static public int Seek(int x, int y,int distence, Direction d, string target)
        {
            int i = 0;
            do
            {
                i++;
                switch (d)
                {
                    case Direction.up:
                        y --;
                        break;
                    case Direction.down:
                        y ++;
                        break;
                    case Direction.left:
                        x --;
                        break;
                    case Direction.right:
                        x ++;
                        break;
                }
                if (y < 0 || x < 0 || y > numCellsY - 1 || x > numCellsX - 1) break;
                if (BeingZones[y][x].occupant == null) continue;
                if (BeingZones[y][x].occupant.species == target)
                {
                    Console.WriteLine("Direction is " + d + " Distence is "+ i);
                    return i;
                }
                
            }
            while (i < distence);
            return 0;
            
        }

        /*Predators kill prey in four directions
         * Called by Being class
         * Pass two parameters one this the Being want to attack ,other one is the direction enum
         * No return
         */
        static public void Attack(Being attacker, Direction d)
        {
            Console.WriteLine($"{attacker.name} is attacking {d.ToString()}");
            int x = attacker.location.x;
            int y = attacker.location.y;

            switch (d)
            {
                case Direction.up:
                    BeingZones[y - 1][x].occupant = attacker;
                    break;
                case Direction.down:
                    BeingZones[y + 1][x].occupant = attacker;
                    break;
                case Direction.left:
                    BeingZones[y][x - 1].occupant = attacker;
                    break;
                case Direction.right:
                    BeingZones[y][x + 1].occupant = attacker;
                    break;
            }
            BeingZones[y][x].occupant = null;
        }

        /*Replace chick with raptor
         * Called by chick Being
         * Pass one parameter which is the chick need to be repleased
         * No return
         */
        static public void GrowUp(Being chick)
        {
            int x = chick.location.x;
            int y = chick.location.y;
            BeingZones[y][x].occupant = null;
            BeingZones[y][x].occupant = new Raptor("Birdy");
        }

        /*Look up, down, left, and right for an escape zone and move the current Being to this zone
         * Called by Being class
         * Pass two parameters one this the Being need to run ,other one is the direction enum
         * return a bool
         */
        static public bool Retreat(Being runner, Direction d)
        {
            Console.WriteLine($"{runner.name} is retreating {d.ToString()}");
            int x = runner.location.x;
            int y = runner.location.y;

            switch (d)
            {
                case Direction.up:
                    if (y > 0 && BeingZones[y - 1][x].occupant == null)
                    {
                        BeingZones[y - 1][x].occupant = runner;
                        BeingZones[y][x].occupant = null;
                        return true; 
                    }
                    return false; 
                case Direction.down:
                    if (y < numCellsY - 1 && BeingZones[y + 1][x].occupant == null)
                    {
                        BeingZones[y + 1][x].occupant = runner;
                        BeingZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
                case Direction.left:
                    if (x > 0 && BeingZones[y][x - 1].occupant == null)
                    {
                        BeingZones[y][x - 1].occupant = runner;
                        BeingZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
                case Direction.right:
                    if (x < numCellsX - 1 && BeingZones[y][x + 1].occupant == null)
                    {
                        BeingZones[y][x + 1].occupant = runner;
                        BeingZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
            }
            return false;
        }
    }
}

