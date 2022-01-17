using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDTrispalve
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Iveskite varda:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite amziu:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite megstama double skaiciu:");
            double skaicius = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mano vardas yra " + vardas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mano amzius yra " + amzius);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Mano skaicius yra " + skaicius);
            Console.ReadKey();
            
        }
    }
}
