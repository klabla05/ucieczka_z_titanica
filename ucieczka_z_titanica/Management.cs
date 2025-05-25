using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    internal class Management
    {
        public int Is_Right_Characters(string output)
        {
            if (int.TryParse(output, out int number))
            {
                if (number == 1 || number == 2)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Error, give the CORRECT number of the choosen character.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Error, give the NUMBER of the choosen character.");
                return -1;
            }
        }
        public int Is_Right_Difficulty(string output)
        {
            if (int.TryParse(output, out int number))
            {
                if (number == 1 || number == 2 || number == 3)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Error, give the CORRECT number of the choosen difficulty.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Error, give the NUMBER of the choosen difficulty.");
                return -1;
            }
        }
    }
}
