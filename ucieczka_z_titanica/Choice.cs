using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    internal class Choice
    {
        Management management = new Management();
        public bool Choice1()
        {
            int result1 = 0;
            Console.WriteLine("You pass by the man trapped in the handcuffs.");
            Console.WriteLine("His face is quite familliar, you saw him somewhere before...");
            Console.WriteLine("YES! That is the murderer, that killed the family of four, the day after Titanic started the travel.");
            Console.WriteLine("What will you do? Free him (type number 1) or live be? (number 2)");
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result1 = management.Is_Right_Choice(answer);
                    if (result1 == 1 || result1 == 2) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            if (result1 == 1)
            {
                Console.WriteLine("You hurry to unfix the handcuffs, while the man starts to yell at you to be quicker. Well, it is not his most fortunate day, so you choose not to inspect");
                Console.WriteLine("Right after freeing him, you feel a punch on the face. Then on the stomach. You cough and see on your hand a bit of blood. From now one, you are slowly loosing blood, that was a defenetly a bad decision to help him");
                Thread.Sleep(20000);
                return false;
            }
            else if (result1 == 2)
            {
                Console.WriteLine("So you run by him");
                Thread.Sleep(7000);
                return true;
            }
                return false;
        }
        public bool Choice2()
        {
            int result2 = 0;
            Console.WriteLine("Suddenly, you hear a scream");
            Console.WriteLine("What will you do? ");
            Console.WriteLine("1. Check");
            Console.WriteLine("2. Pretend that you do not hear a thing");
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result2 = management.Is_Right_Choice(answer);
                    if (result2 == 1 || result2 == 2) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            if (result2 == 1)
            {
                Console.WriteLine("When you locate the owner of this big scream, you find young boy, cuddling with his toy");
                Console.WriteLine("With a soft smile, you convince him to run and try to find the boats around the Titanic, get on them");
                Console.WriteLine("After a bit of suspence, the boy runs off");
                Thread.Sleep(20000);
                return true;
            }
            else if(result2 == 2)
            {
                Console.WriteLine("You go by with your run");
                Thread.Sleep(7000);
                return false;
            }
            return false;
        }
        public bool Choice3()
        {
            int result3 = 0;
            Console.WriteLine("You see the sign to the cabin. The way there will take you some time, but maybe there will be something to speed down the drowning of the ship?");
            Console.WriteLine("What will you do?");
            Console.WriteLine("1. Go and try to do something");
            Console.WriteLine("2. Do not bother, still run");
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result3 = management.Is_Right_Choice(answer);
                    if (result3 == 1 || result3 == 2) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            if (result3 == 1)
            {
                Console.WriteLine("After following the signs, you arrive in the cabin.");
                Console.WriteLine("There are so many buttons, clicks, stuff to do things with sinking ship, but you do not know the clue about them.");
                Console.WriteLine("After consederation, you run off, not doing anything, to not make it all worse");
                Thread.Sleep(30000);
                return false;
            }
            else if (result3 == 2)
            {
                Console.WriteLine("You go by with your run");
                Thread.Sleep(7000);
                return true;
            }
            return false;
        }
    }
}
