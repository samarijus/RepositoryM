using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDIfElseM.S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2 && skaicius1 < 100)
            {
                Console.WriteLine(skaicius1);
                Console.Read();
            }
            else if (skaicius2 > 0 && skaicius2 > skaicius1)
            {
                Console.WriteLine(skaicius2);
                Console.Read();
            }
            else if (skaicius1 > skaicius2 && skaicius1 > skaicius3 || skaicius1 > 0)
            {
                Console.WriteLine(skaicius1);
                Console.Read();
            }
            else if (skaicius3 >= 5 && skaicius3 <= 10 || skaicius3 > skaicius1 || skaicius3 > skaicius2)
            {
                Console.WriteLine(skaicius3);
                Console.Read();
            }
        }
    }
}
