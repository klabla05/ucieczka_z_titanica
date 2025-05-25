using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    public class Characters
    {
        public string character_string { get; set; }
        Management management = new Management();
        public int character {  get; set; } 
        public Characters() 
        {
            this.character_string = string.Empty;
            this.character = 0;
        }
        public void Choose_Your_Character()
        {
            Console.WriteLine("In this part, you are required to choose your character for the game ahead.");
            Console.WriteLine("Choose visely, there is no coming back from it!");
            Console.WriteLine("Remember, each of your decisions can save you or drown you.");
            Console.WriteLine();
            Console.WriteLine("Characters to choose are listed below. To make your decision, just type the number of you choosen.");
            Console.WriteLine("1.Rose - the female, young aristocrate.");
            Console.WriteLine("2.Jack - young sailour boy, with some experience in the dangerous waters.");
            while (true)
            {
                try
                {
                    character_string = Console.ReadLine();
                    character = management.Is_Right_Characters(character_string);                   
                    if(character == 2 || character == 1) { break; }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error, give the NUMBER and only (without the space etc.");
                }
            }
        }
    }
}
