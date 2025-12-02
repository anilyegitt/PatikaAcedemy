using System;

namespace Metod_Tanımlama
{
    class Extension
    {
        public void Run()
        {

            //Rekürsif- Öz yinelemeli
            //3^4 = 3x3x3x3


            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metodlar
            string ifade = "ibrahim anıl yeğit";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces());
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

        }

    }

   public class Islemler
    {

        public int Expo(int sayi, int üs)
        {

            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;
        }

        //Expo(3,4)
        //Expo(3,3)*3;
        //Expo(3,2)*3*3;
        //Expo(3-1)3*3*3*;
        //3*3*3*3=3^4;

    }


    public static class Extensionn
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains("");
        }

        public static string RemoveWhiteSpaces (this string param)
        {;
            string[] dizi = param.Split(' ');
            return string.Join("", dizi);
        }
    }
}
