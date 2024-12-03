using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        // interface baya önemlidir miras ile baya bir ilgilidir ama anladım bunu ders sonunda yazdımm
        // interfacenin faydasını göreceğğiz simdi başvuru yap kısmına direkt olarak
        // IKrediManager vardı ya o ne yapacak bütün kredi tipllerinin hesaplanma türünü tutuyor dimi
        // o yuzde bu metoddaki değişkenin tipi neden IKrediManager kredimanager olmassın öyle olursa hepsini karıştırmadan görürürüm
        //iki ayrı değişkeni gönderdim ikisindede intarface kullandım birinde loglama yaptım birinde hesaplama esasında ikisinde de aynı şeyi yaptım
        // bu sistem sayesinde mesela yeni bir kredi tipi tanımladığımızda hiçbir sorun yaşamayız 
        // ayrıca interface bu şekilde çalışır bir miras mantığıyla çalışır metodları olur bunları classlara mirascıymış gibi tanım olarak verir 
        // her sınıf ayrı ayrı bu tanımları içinde barındırmak zorundadır 
        // aynı mirascılık gibi ama interface bu işim metodluhalidir
        public void BasvuruYap(IKrediManager kredimanager, ILoggerservice loggerservice)
        {
            //Başvuran bilgilerini değerlendirme
            // hangi krediyi gönderirsem bellekteki o kredi çalışır
            kredimanager.Hesapla();
            // hangi logger servisten geldiyse onu logla diyorum
            loggerservice.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler) { kredi.Hesapla(); }

        }
    }
}
