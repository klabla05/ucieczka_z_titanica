using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    internal class Speed
    {
        private int timeLimit;
        public Speed() 
        {
            timeLimit = 0;
        }
        public void Difficulty_Speed(Difficulty difficulty)
        {
            int choice = difficulty.Choose_Difficulty();
            if (choice == 1)
            {
                timeLimit = 0;
            }
            else if (choice == 2)
            {
                timeLimit = 2000;
            }
            else if (choice == 3)
            {
                timeLimit = 1000;
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public async Task Speed_Timer()
        {
            if (timeLimit <= 0) return;
            int count = 0;
            Console.WriteLine("Started");
            Task.Run(async () =>
            {
                await Task.Delay(timeLimit);
                while (count < 5)
                {
                    Console.WriteLine("Careful, the water is rising!");
                    await Task.Delay(timeLimit);
                    count++;
                }
            });
        }

    }
}
