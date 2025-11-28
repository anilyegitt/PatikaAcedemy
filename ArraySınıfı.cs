using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    class ArraySınıfı
    {
        public void Run()
        {
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("Sıradız Dizi");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("Array Clear");
            //sayiDizisi elemanlarını kullanarak 2.index ten itibaten 2 tane elemanı 0'lar
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("Array IndexOf");
            Array.IndexOf(sayiDizisi, 23);
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
                       

          
        }
    }
}
