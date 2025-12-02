using System;

namespace Metod_Tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Konu Seçiniz");
            Console.WriteLine("1-Metod Tanımı");
            Console.WriteLine("2 OverLoadiing");
            Console.WriteLine("3 Extension");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                var metods = new Metod();
                metods.Run();

            }
            else if (secim == "2")
            {
                var ov = new Overloading();
                ov.Run();
            }
            else if (secim == "3")
            {
                var ext = new Extension();
                ext.Run();
            }
        }
    }
}

