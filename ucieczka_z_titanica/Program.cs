using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    public class Program
    //https://parade.com/970343/parade/logic-puzzles/
    //https://loquiz.com/2024/11/12/15-challenging-logic-puzzles-and-their-answers/
    {
        public static async Task Main()
        {
            Characters characters = new Characters();
            characters.Choose_Your_Character();
            Console.WriteLine();
            Difficulty difficulty = new Difficulty();
            Speed speed = new Speed();
            speed.Difficulty_Speed(difficulty);
            Begining begining = new Begining();
            Console.WriteLine();
            //begining.Begining_Both(characters);
            speed.Speed_Timer();
            Outcome outcome = new Outcome();
            int sum = outcome.Outcome_To_Ending();
            Ending ending = new Ending();
            ending.End(outcome, sum);
        }
    }
}
