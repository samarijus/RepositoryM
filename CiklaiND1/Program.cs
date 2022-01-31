using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklaiND1
{
    class Program
    {
        static void Main(string[] args)
        {
        ntojiOperacija:
            {
                Console.WriteLine("Iveskite 2 norimus skaicius");
                double skaicius1 = Convert.ToDouble(Console.ReadLine());
                double skaicius2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Iveskite aritmetines operacijos, kuria norite atlikti simboli");
                char operacija = Convert.ToChar(Console.ReadLine());

                switch (operacija)
                {
                    case '+':
                        Console.WriteLine($"{skaicius1 + skaicius2}");
                        break;
                    case '-':
                        Console.WriteLine($"{skaicius1 - skaicius2}");
                        break;
                    case '*':
                        Console.WriteLine($"{skaicius1 * skaicius2}");
                        break;
                    case '/':
                        Console.WriteLine($"{skaicius1 / skaicius2}");
                        break;
                    default:
                        Console.WriteLine("Operacija neegzistuoja");
                        break;
                }
            }
            Console.WriteLine("Jeigu norite atlikti dar viena operacija iveskite 1, jeigu norite nutraukti darba iveskite 0");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            if (pasirinkimas == 1)
            {
                goto ntojiOperacija;
            }
            else
            {
                Console.WriteLine("Skaiciuotuvas baige darba");
            }
            Console.ReadKey();
        }
    }
}
