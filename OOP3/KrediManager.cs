using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        //biz bu miraslama mantığını metod olarak yaptık yani bu 
        // metodları diğer sınıflar içinde barındırmak zorunda 
        // onları bu metodlara mecbur kıldık
        // Yeni bir kredi oluşcağı zaman bu ikisini tutumak zorunda 
        // interface(arayüz) 
        void Hesapla();
        void BiseyYap();

    }
}
