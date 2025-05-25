using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ucieczka_z_titanica
{
    public class Program
    {
        public static void Main()
        {
            Characters characters = new Characters();
            characters.Choose_Your_Character();
            Console.WriteLine();
            Difficulty difficulty = new Difficulty();
            difficulty.Choose_Difficulty();
            Begining begining = new Begining();
            Console.WriteLine();
            begining.Begining_Both(characters);
        }
    }
}
