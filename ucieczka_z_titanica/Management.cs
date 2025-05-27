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

        public int Is_Right_Task1(string output)
        {
            if (int.TryParse(output, out int number))
            {
                if (number == 24)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Error, give the NUMBER for the answer.");
                return -1;
            }
        }
        public int Is_Right_Task2(string output)
        {
            if (int.TryParse(output, out int number))
            {
                if (number == 3)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Error, give the NUMBER for the answer.");
                return -1;
            }
        }
        public int Is_Right_Task3(string output)
        {
            output = output.ToLower();
            if(Contains(output, "cabde"))
            {
                if(output == "cabde")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            Console.WriteLine("Error, give the LETTERS and only");
            return -1;
        }
        public bool Contains(string output, string key)
        {
            return output.All(c => key.Contains(c));
        }

        public int Is_Right_Shuffle1(string output)
        {
            if (int.TryParse(output, out int number))
            {
                if (number == 1 || number == 2 || number == 3)
                {
                
                    return number;
                }
                else
                {
                    Console.WriteLine("Error, give the CORRECT number of the choosen way.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Error, give the NUMBER of the choosen way.");
                return -1;
            }
        }
        public int Is_Right_Shuffle2(string output)
        {
            if (int.TryParse(output, out int number))
            {
                if (number == 1 || number == 2)
                {

                    return number;
                }
                else
                {
                    Console.WriteLine("Error, give the CORRECT number of the choosen way.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Error, give the NUMBER of the choosen way.");
                return -1;
            }
        }
        public int Is_Right_Shuffle3(string output)
        {
            if (int.TryParse(output, out int number))
            {
                if (number == 2 || number == 3)
                {

                    return number;
                }
                else
                {
                    Console.WriteLine("Error, give the CORRECT number of the choosen way.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Error, give the NUMBER of the choosen way.");
                return -1;
            }
        }
        public int Is_Right_Shuffle4(string output)
        {
            if (int.TryParse(output, out int number))
            {
                if (number == 1 || number == 3)
                {

                    return number;
                }
                else
                {
                    Console.WriteLine("Error, give the CORRECT number of the choosen way.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Error, give the NUMBER of the choosen way.");
                return -1;
            }
        }
    }
}

