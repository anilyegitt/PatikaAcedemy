using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Hangi konu çalışsın?");
                Console.WriteLine("1 - For");
                Console.WriteLine("2 - While Foreach");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    var forloop = new ForLoop();
                    forloop.Run();
                }
                else if (secim == "2")
                {
                    var whileForeach = new While_Foreach();
                    whileForeach.Run();
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim");
                }


                {

                }
            }
        }
    }
}

