using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThing.Things
{
    class Chef
    {
        public bool isEating;
        public string _location;
        public string name;
        public Chef()
        {
            isEating = true;
            _location = "";
            name = "";
        }
        public void isHungry(string name)
        {
            if (isEating)
            {
                Console.WriteLine($"{name} is eating right now");
            }
            else
            {
                Console.WriteLine($"{name} is full");
            }
        }

        public void Restaurant(string name, string location)
        {
            Console.WriteLine($"{name} is eating at {location}.");
        }
    }
}
