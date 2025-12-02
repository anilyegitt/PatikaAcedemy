using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Tanımlama
{
    class Metod
    {

        public void Run()
        {
            int a = 2, b = 3;
            Console.WriteLine(a + b);
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metodlarr ornek = new Metodlarr();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a + b));
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }

    }


    class Metodlarr
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);

        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }

    }
}

 
