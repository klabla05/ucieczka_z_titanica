using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    internal class Ending
    {
        /*Outcome is counted by:
        - Choice (mostly) - each one is a 50 pkt for the good outcome
        - Decision_Shuffle - each small good decision, about 1 pkt
        - Tasks - each answered great question is adding 30 pkt
        Summary: 3*50 + 30*3 +  1*30 = 270
        270-200 - the best ending (BUT REQUIRED TO SAVE THE BOY)
        199 - 100 - so-so ending
        99-0 - worst one*/
        public void End (Outcome outcome, int sum)
        {
            bool is_Boy = outcome.boy;
            if (is_Boy && sum >= 200)
            {
                Good();
            }
            else if (sum>=100 && sum< 200)
            {
                So_So();
            }
            else
            {
                Bad();
            }
        }
        public void Good()
        {
            Console.WriteLine("You finaly reach the main deck. To your attention comes a boat, just loading with people");
            Console.WriteLine("With your last breath, you grant yourself a spot next to...");
            Console.WriteLine(" - Hello! Look! I've made it! With Loopa! - greet you with exciement boy, that one, that you (now realise) saved");
            Console.WriteLine("After a cheerful small talk with him, you are at ease, you for sure made it! Just now, give it a bit time to arrive at the harbour");
        }
        public void So_So()
        {
            Console.WriteLine("You finaly reach the main deck. Unfortunalty, there is no boat on sight");
            Console.WriteLine("Then there is realisation. The only way to get out of this is to...");
            Console.WriteLine("You grab yourself a kind of raft, that someone started to build. You manage to finish the construction and get on it, just the time the Titanic is fully under the water");
            Console.WriteLine("From now one, you can only count on yourself and your ability to swim well... ");
        }
        public void Bad()
        {
            Console.WriteLine("You finaly reach the main deck. Unfortunalty, there is no boat on sight");
            Console.WriteLine("Then there is realisation. The water is now on your knees");
            Console.WriteLine("You try to grab yourself a kind of raft, that someone started to build, but you do not manage to finish the construction.");
            Console.WriteLine("In the eye blink - you are drowning");
            Console.WriteLine("You try to grab yourself a bit of air, but only make it worse.");
            Console.WriteLine("You blink one more time, and the last one in your life.");
        }
    }
}
