using System;

namespace Clas_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.Izlenme_orani = 58;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Engin Demirog";
            kurs2.Izlenme_orani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Engin Demirog";
            kurs3.Izlenme_orani = 48;

            //Console.WriteLine(kurs1.KursAdi +": "+kurs1.Egitmen);
            //Console.WriteLine(" İzlenme Oranı: " + kurs1.Izlenme_orani
            //);
            // şimdi bu oluşturduğumuz kursları bir listeye atayalım
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i].Egitmen);
            }
            // tabi biz bu kısımda classa veriyi gönderdik 
            //sonra onları çağırdık ama bu her zaman böyle 
            // olmaz genelde gömülü olur clasın içinde

        }
    }
    class Kurs
    {   
        //prop yazdıkda geldi public yani dışardan erişilebilir
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int Izlenme_orani {  get; set; }  
    }
}
