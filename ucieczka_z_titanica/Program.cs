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
            /*Speed.Speed_Timer();
            Characters characters = new Characters();
            characters.Choose_Your_Character();
            Console.WriteLine();
            Difficulty difficulty = new Difficulty();
            Speed speed = new Speed();
            speed.Difficulty_Speed(difficulty);
            speed.Speed_Timer();
            Begining begining = new Begining();
            Console.WriteLine();
            begining.Begining_Both(characters);*/
            Tasks task = new Tasks();
            task.Task1();
            task.Task2();
            task.Task3();
        }
    }
}
