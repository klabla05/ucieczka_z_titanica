using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    internal class Tasks
    {
        Management management = new Management();
        public bool Task1()
        {
            int result;
            Console.WriteLine("After a short run, you reach the locked door.");
            Console.WriteLine("The lock has a note attached that sayes:");
            Console.WriteLine("*A fish’s head is 3 centimeters long. Its tail is the same length as the head plus half the body. The body is as long as the head and tail together. How long is the fish?*");
            Console.WriteLine(" - So the answer is the key to the door - you realise with a bit of relief");
            Console.WriteLine("What will be you solution? Think deep, there is only one chance to give the answer. Rememeber, type ONLY the numbers");
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result = management.Is_Right_Task1(answer);
                    if (result == 1 || result == 0) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            if(result == 1) { return true; }
            return false;
        }
        public bool Task2()
        {
            int result2;
            Console.WriteLine("After a short run, you reach the locked door.");
            Console.WriteLine("The lock has a note attached that sayes:");
            Console.WriteLine("*There are two ducks in front of a duck, two ducks behind a duck and a duck in the middle. How many ducks are there?*");
            Console.WriteLine(" - So again, the answer is the key to the door - you realise with a bit of relief");
            Console.WriteLine("What will be you solution? Think deep, there is only one chance to give the answer. Rememeber, type ONLY the numbers");
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result2 = management.Is_Right_Task2(answer);
                    if (result2 == 1 || result2 == 0) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            if (result2 == 1) { return true; }
            return false;
        }
        public bool Task3()
        {
            int result2;
            Console.WriteLine("After a short run, you once again reach the locked door.");
            Console.WriteLine("The lock has a note attached that sayes:");
            Console.WriteLine("*Five people were eating apples, A finished before B, but behind C. D finished before E, but behind B. What was the finishing order?*");
            Console.WriteLine(" - So again, the answer is the key to the door - you realise with a bit of relief");
            Console.WriteLine("What will be you solution? Think deep, there is only one chance to give the answer. Type only the letters, the sequence, without the space, enter ect.");
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result2 = management.Is_Right_Task3(answer);
                    if (result2 == 1 || result2 == 0) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            if (result2 == 1) { return true; }
            return false;
        }
    }
}
