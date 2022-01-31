using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklaiND2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveika skaiciu nuo 1 iki 10");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Bandykite atspeti slapta skaiciu\n Nuo 1 iki 10");
            int spejimas = Convert.ToInt32(Console.ReadLine());

            while (spejimas != skaicius)
            {
                if (spejimas < skaicius)
                {
                    Console.WriteLine("Slaptas skaicius yra didesnis");
                    Console.WriteLine("Bandykite atspeti slapta skaiciu\n Nuo 1 iki 10");
                    spejimas = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                else if (spejimas > skaicius)
                {
                    Console.WriteLine("Slaptas skaicius yra mazesnis");
                    Console.WriteLine("Bandykite atspeti slapta skaiciu\n Nuo 1 iki 10");
                    spejimas = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                else if (spejimas == skaicius)
                {
                    break;
                }
            }

            Console.WriteLine("Atspejote!");
            Console.ReadKey();
        }
    }
}

