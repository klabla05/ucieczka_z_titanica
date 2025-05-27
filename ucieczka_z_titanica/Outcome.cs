using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    internal class Outcome
    {
        Choice choice = new Choice();
        Decision_Shuffle decision_shuffle = new Decision_Shuffle();
        Tasks task = new Tasks();
        public bool boy = false;
        public int sum = 0;
        /*Outcome is counted by:
        - Choice (mostly) - each one is a 50 pkt for the good outcome
        - Decision_Shuffle - each small good decision, about 1 pkt
        - Tasks - each answered great question is adding 30 pkt
        Summary: 3*50 + 30*3 +  1*30 = 270
        270-200 - the best ending (BUT REQUIRED TO SAVE THE BOY)
        199 - 100 - so-so ending
        99-0 - worst one*/
        public int Outcome_To_Ending()
        {
            for(int i =  0; i < 5; i++)
            {
                bool choice0 = decision_shuffle.Outcome();
                if (choice0)
                {
                    sum++;
                }
            }
            bool choice1 = choice.Choice1();
            if (choice1)
            {
                sum = sum + 50;
            }
            for (int i = 0; i < 5; i++)
            {
                bool choice0 = decision_shuffle.Outcome();
                if (choice0)
                {
                    sum++;
                }
            }
            bool task1 = task.Task1();
            if (task1)
            {
                sum = sum + 30;
            }
            for (int i = 0; i < 5; i++)
            {
                bool choice0 = decision_shuffle.Outcome();
                if (choice0)
                {
                    sum++;
                }
            }
            bool task2 = task.Task2();
            if (task2)
            {
                sum = sum + 30;
            }
            bool choice2 = choice.Choice2();
            if (choice2)
            {
                sum = sum + 50;
                boy = true;
            }
            for (int i = 0; i < 10; i++)
            {
                bool choice0 = decision_shuffle.Outcome();
                if (choice0)
                {
                    sum++;
                }
            }
            bool choice3 = choice.Choice3();
            if(choice3)
            {
                sum = sum + 50;
            }
            for (int i = 0; i < 5; i++)
            {
                bool choice0 = decision_shuffle.Outcome();
                if (choice0)
                {
                    sum++;
                }
            }
            bool task3 = task.Task3();
            if (task3)
            {
                sum = sum + 30;
            }
            return sum;
        }
    }
}
