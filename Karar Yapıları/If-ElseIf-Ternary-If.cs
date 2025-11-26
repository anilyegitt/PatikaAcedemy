using System;

namespace Karar_Yapıları
{

        internal class If_ElseIf_Ternary_If
    {
            public void Run()
            {
                int time = DateTime.Now.Hour;

                if (time >= 6 && time <= 11)
                    Console.WriteLine("Günaydın");
                else if (time >= 12 && time <= 18)
                    Console.WriteLine("İyi Günler");
                else
                    Console.WriteLine("İyi Geceler");
            }
        }
    }
