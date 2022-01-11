using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - limonadas  2 - arbata  3 - kakava  4 - kava  5 - nieko ");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote limonada");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote arbata");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote kakava");
                    break;
                case 4:
                    Console.WriteLine("Jus pasirinkote kava");
                    break;
                case 5:
                    Console.WriteLine("Jus nieko nepasirinkote");
                    break;
                default:
                    Console.WriteLine("Blogai ivestas pasirinkimas");
                    break;
            }
            Console.ReadKey();
        }
    }
}
