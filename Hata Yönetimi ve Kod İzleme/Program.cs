using System;

namespace Hata_Yönetimi_ve_Kod_İzleme
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {

            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Gimiş olduğunuz sayı:" + sayi);
            }
            catch (Exception ex)
            {
              Console.WriteLine("Hata   " + ex.Message.ToString());
            }
            finally
            {
              Console.WriteLine("İşlem Tamamlandı");
            }


            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-2000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Vei Tipi Uygun Değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada büyük bir değer girdiniz");
                Console.WriteLine(ex);  
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı");
            }
        }
    }
}