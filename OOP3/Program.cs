using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            // TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKredimanager = new KonutKrediManager();
            //konutKredimanager.Hesapla();


            // DEMEKKİ İNTERFACELERDE MİRASLAMA MANTIĞI GİBİ CLASSLARI REFERANS ALABİLİR
            //IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager1.Hesapla();

            //IKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager1.Hesapla();

            //IKrediManager konutKredimanager1 = new KonutKrediManager();
            //konutKredimanager1.Hesapla();
            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            IKrediManager konutKredimanager1 = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //HANGİ KREDİ GİDERSE ONUN HESAPLASI ÇALIŞCAK
            ILoggerservice dataloggerservice = new DatabaseLoggerService();
            ILoggerservice fileloggerservice = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager1,dataloggerservice);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager1,tasitKrediManager1 };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);




        }
    }
}
