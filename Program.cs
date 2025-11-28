using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir konu seçiniz");
            Console.WriteLine("1 - Dizi ");
            Console.WriteLine("2 - Array");
            string secim = Console.ReadLine();

            if(secim == "1")
            {
                var dizi = new Dizi_Kullanımı();
                dizi.Run();
            }
            else if (secim=="2")
            {
                var array = new ArraySınıfı();
                array.Run();

            }
      

        }
    }
}
