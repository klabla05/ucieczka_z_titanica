using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    internal class Difficulty
    {
        int difficulty {  get; set; }
        string difficulty_string { get; set; }
        Management management = new Management();
        public Difficulty() 
        { 
            this.difficulty = 0;
            this.difficulty_string = string.Empty;
        }
        public int Choose_Difficulty()
        {
            Console.WriteLine("Choose your difficulty, write only the number of the choosen. Listed below.");
            Console.WriteLine("1. Easy-peasy: take your time");
            Console.WriteLine("2. Not-so-easy: to feel a bit of preassure");
            Console.WriteLine("3. Only-for-veterans: to have a short speedrun");
            while (true)
            {
                try
                {
                    difficulty_string = Console.ReadLine();
                    difficulty = management.Is_Right_Difficulty(difficulty_string);
                    if (difficulty == 2 || difficulty == 1 || difficulty == 3) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
            return difficulty;
        }
    }
}
