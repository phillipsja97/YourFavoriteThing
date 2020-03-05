using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThing.Things
{
    class Pets
    {
        public string name;
        public string speaks;
        public string type;

        public Pets()
        {
            name = "";
            speaks = "";
            type = "";
        }

        public void PetType(string name, string type)
        {
            Console.WriteLine($"{name} is a {type}.");
        }

        public void PetSpeak(string name, string type, string message)
        {
            if (type == "Dog")
            {
                Console.WriteLine($"Woof Woof! This means that {name} is saying {message}.");
            }
            else if (type == "Cat")
            {
                Console.WriteLine($"Meow, Meow! This means that {name} is saying {message}");
            }
        }
    }
}
