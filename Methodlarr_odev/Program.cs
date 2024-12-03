using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlarr_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplama(5, 7);
            //bu method bizim için toplama işlemini yaptı
            Console.WriteLine(Toplam2(5,12));
            Console.WriteLine(Toplam3(3,5,5,5,55,5,5,5,5,5,523,23));
        }
        //bu bir metoddur şimdi bunu çağıralım
        static void Toplama(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+ sayi2);
        }
        //void yazınca git bişey yap bişey getir anlamına gelir veri döndürmek istiyorsam return sayı veya string bunun için yapmam gereken int string yazmak
        static int Toplam2(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int Toplam3(params int[] sayilar)
        {
            return sayilar.Sum();
        }    
    }
}
