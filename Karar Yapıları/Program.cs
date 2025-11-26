using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi konu çalışsın?");
            Console.WriteLine("1 - If / Else / Ternary");
            Console.WriteLine("2 - Switch Case");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                var ifElse = new If_ElseIf_Ternary_If();
                ifElse.Run();
            }
            else if (secim == "2")
            {
                var sc = new Switch_Case();
                sc.Run();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim");
            }
        }
    }
}