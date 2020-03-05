using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThing.Things
{
    class Hockey
    {
        public int _lapsSkated;
        public bool isReady { get; set; }

        public string name;
        public Hockey()
        {
            isReady = true;
            _lapsSkated = 0;
            name = "";
        }

        public void ReadyUp(string name)
        {
            if (isReady)
            {
                Console.WriteLine($"{name} is ready to play");
            }
            else
            {
                Console.WriteLine($"{name} is not ready to play");
            }
        }

        public void Laps(int laps)
        {
            Console.WriteLine($"I have skated {laps} laps.");
        }
    }
}
