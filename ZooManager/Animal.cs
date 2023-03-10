using System;
using System.Collections.Generic;
namespace ZooManager
{
    public class Animal: Being, IPrey, IPredator
    {
        public List<string> predators 
        {
            get
            {
                return predator;
            }
            set
            {
                predator = predators;
            }
        }

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
        
    }
}
