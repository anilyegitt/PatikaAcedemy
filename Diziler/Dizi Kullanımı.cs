using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    class Dizi_Kullanımı
    {
        public void Run()
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };
            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngüler dizi kullanımı
            //klavyeden girilen n  tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısı giriniz", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());

            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;

            }
            Console.WriteLine("Ortalama" + toplam / diziUzunlugu);
        }
    }
}
