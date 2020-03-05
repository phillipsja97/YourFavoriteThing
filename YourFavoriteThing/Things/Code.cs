using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThing.Things
{
    class Code
    {
        public bool isCoding;
        public int _codeGoal;
        public int _codeHours;
        public string name;
        public Code(int codeGoal)
        {
            _codeGoal = codeGoal;
            isCoding = true;
            name = "";
        }

        public void Coding(string name)
        {
            if (isCoding)
            {
                Console.WriteLine($"Shhhh.. {name} is coding");
            }
            else
            {
                Console.WriteLine($"What a bum, {name} is not coding right now");
            }
        }

        public void codeCount(string name, int codeHours)
        {
            _codeHours += codeHours;

            if (codeHours >= _codeGoal)
            {
                Console.WriteLine($"Congratulations, {name}! You have completed your goal by coding for {codeHours}!");
            }
            else
            {
                var hoursLeft = _codeGoal - codeHours;
                Console.WriteLine($"Keep working, {name}. You only have {hoursLeft} hours left until you have hit your code goal!");
            }

        }
    }
}
