//15.08.2024 - Bu uygulama yarıçapını girdiğiniz daireyi çizer.
//Gökçehan Özdemir

using System;

namespace DaireCizme
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lütfen yarıçapı giriniz:");
            int yaricap = Convert.ToInt32(Console.ReadLine());
            int merkez = yaricap * 2;
            int orta = yaricap; 

            for (int y = 0; y <= merkez; y++)
            {
                for (int x = 0; x <= merkez; x++)
                {
                    // Dairenin içine giren noktaları kontrol eder
                    if ((Math.Pow(x - orta, 2) + Math.Pow(y - orta, 2)) <= Math.Pow(yaricap, 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
