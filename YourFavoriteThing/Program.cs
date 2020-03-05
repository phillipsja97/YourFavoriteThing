using System;
using YourFavoriteThing.Things;

namespace YourFavoriteThing
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Hockey();
            player.isReady = false;
            player.name = "Jamie";
            player.ReadyUp(player.name);
            player.Laps(34);

            var topChef = new Chef();
            topChef.name = "Bobby Flay";
            topChef.isEating = true;
            topChef._location = "Husk";
            topChef.isHungry(topChef.name);
            topChef.Restaurant(topChef.name, topChef._location);

            var coder = new Code(50);
            coder.isCoding = false;
            coder.name = "Will Smith";
            coder._codeHours = 45;
            coder.Coding(coder.name);
            coder.codeCount(coder.name, coder._codeHours);

            var fluffy = new Pets();
            Console.WriteLine("What is your new pets name?");
            fluffy.name = Console.ReadLine();
            Console.WriteLine($"Hi, {fluffy.name}. Is {fluffy.name} a Cat or a Dog.");
            fluffy.type = Console.ReadLine();
            fluffy.PetType(fluffy.name, fluffy.type);
            Console.WriteLine($"What does {fluffy.name} want to say? Type out the message");
            fluffy.speaks = Console.ReadLine();
            fluffy.PetSpeak(fluffy.name, fluffy.type, fluffy.speaks);

            Console.ReadLine();
        }
    }
}
