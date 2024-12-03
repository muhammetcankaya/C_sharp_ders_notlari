using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Odevler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ternory nedir nasıl kulanılır
            int sayi = 54;

            var sonuc = sayi % 2 == 0 ? "çift" : "tek";
            Console.WriteLine(sonuc);

            //switch yapısı
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            //while yapısı
            // şart sağlanana kadar yapmaya devam eder
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
           //buda tersten

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
            ;

        }
    }
}
