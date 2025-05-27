using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    internal class Decision_Shuffle
    {
        Management management = new Management();
        int flag = 0;
        public int MakeDecision1()
        {
            int result1 = 0;
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result1 = management.Is_Right_Shuffle1(answer);
                    if (result1 == 1 || result1 == 2 || result1 == 3) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            return result1;
        }
        public int MakeDecision2()
        {
            int result2 = 0;
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result2 = management.Is_Right_Shuffle2(answer);
                    if (result2 == 1 || result2 == 2) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            return result2;
        }
        public int MakeDecision3()
        {
            int result3 = 0;
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result3 = management.Is_Right_Shuffle3(answer);
                    if (result3 == 3 || result3 == 2) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            return result3-1;
        }
        public int MakeDecision4()
        {
            int result4 = 0;
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine();
                    result4 = management.Is_Right_Shuffle4(answer);
                    if (result4 == 1 || result4 == 3) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            if (result4 == 3)
            {
                return result4 - 1;
            }
            return result4;

        }
        public int Decisions_Shuffle()
        {
            Random random = new Random();
            int decisions = random.Next(1, 5);
            int decision = 0;
            //List<bool> list = new List<bool>();
            if (decisions == 1)
            {
                Console.WriteLine("After a short run, you have a decision to make. Which way to go?");
                Console.WriteLine("To go straight - 2");
                Console.WriteLine("Or to turn right - 3");
                decision = MakeDecision3();
                //list = Shuffle(1, 2);
            }
            else if (decisions == 2)
            {
                Console.WriteLine("After a short run, you have a decision to make. Which way to go?");
                Console.WriteLine("To go left - type on the keyboard number 1");
                Console.WriteLine("To go straight - 2");
                decision = MakeDecision2();
                //list = Shuffle(1, 2);
            }
            else if (decisions == 3)
            {
                Console.WriteLine("After a short run, you have a decision to make. Which way to go?");
                Console.WriteLine("To go left - type on the keyboard number 1");
                Console.WriteLine("Or to turn right - 3");
                decision = MakeDecision4();
                //list = Shuffle(1, 2);
            }
            else if (decisions == 4)
            {
                Console.WriteLine("After a long run, you have a decision to make. Which way to go?");
                Console.WriteLine("To go left - type on the keyboard number 1");
                Console.WriteLine("To go straight - 2");
                Console.WriteLine("Or to turn right - 3");
                decision = MakeDecision1();
                flag++; 
                //list = Shuffle(2, 3);
            }
            return decision;
        }
        private List<bool> Shuffle(int max, int possibility)
        {
            Random random = new Random();
            int good = random.Next(1, max+1); //two or one
            List<int> index = Enumerable.Range(0, possibility+1).OrderBy(x => random.Next()).ToList(); //from 0 to how many possible to choose and shufle the spots
            HashSet<int> good_Ones = index.Take(good).ToHashSet(); //throw the good in the random order from above
            List<bool> bools = new List<bool>();    
            for (int i = 0; i < possibility; i++)
            {
              bools.Add(good_Ones.Contains(i));
            }
            return bools;
        }
        public bool Outcome()
        {
            int decision = Decisions_Shuffle();
            if(flag == 1)
            {
                flag--;
                List<bool> list_With_Flag = new List<bool>();
                list_With_Flag = Shuffle(2, 3);
                decision = decision - 1;
                if (list_With_Flag[decision])
                {
                    return true;
                }
                else return false;
            }
            else
            {
                List<bool> list = new List<bool>();
                list = Shuffle(1, 2);
                decision = decision - 1;
                if (list[decision])
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
