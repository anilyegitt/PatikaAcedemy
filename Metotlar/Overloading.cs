using System;
using System.ComponentModel;

namespace Metod_Tanımlama
{
    class Overloading
    {

        public void Run()
        {
            // out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else { 
                Console.WriteLine("Başarısızz ");
        }

        Metodlar instance = new Metodlar();
            instance.Topla(5, 3, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            int ifade =999;
            instance.Yazdır(Convert.ToString(ifade));
            instance.Yazdır(ifade);

            instance.Yazdır("İbrahim", "Anıl");

            //Metod imzası
            //Metod Adı + parametre sayısı + parametre
        }

}
    class Metodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;

        }

        public void Yazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void Yazdır(int veri)
        {
            Console.WriteLine(veri);
        }

        public void Yazdır(string veri1 , string veri2)
        {

            Console.WriteLine(veri1 + veri2); 
        }
    }

}

