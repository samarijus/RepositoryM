using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDKepykla.M.S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek vienas darbuotojas gali iskepti duonos kepalu per valanda: ");
            int kepaluSk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek darbuotoju turi kepykla: ");
            int darbuotojuSk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo savikaina: ");
            double kepaloSavikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo pardavimo kaina: ");
            double kepaloPardavimoK = Convert.ToDouble(Console.ReadLine());
            int dienosKepaluSk;
            dienosKepaluSk = kepaluSk * darbuotojuSk * 8;
            double bendraSavikaina = dienosKepaluSk * kepaloSavikaina;
            double pelnas = kepaloPardavimoK * dienosKepaluSk - bendraSavikaina;

            Console.WriteLine("Per diena iskepta duonos kepalu: " + dienosKepaluSk);
            Console.WriteLine("Visu kepalu savikaina: " + bendraSavikaina);
            Console.WriteLine("Gautas pelnas: " + pelnas);
            Console.ReadKey();
        }
    }
}
