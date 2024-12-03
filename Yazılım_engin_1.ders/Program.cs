//class Program
//    {
//        static void main(string[] args)
//        {
//            //type safety - tip güvenliği
//        string kategori = "Kategori";

//        Console.WriteLine(kategori);
//        Console.WriteLine(kategori);
//        Console.WriteLine(kategori);
//        Console.WriteLine(kategori);
//        // BİR DEĞİŞKEN ATARKEN ONUN VERİ TİPİİNİ YAZMAK ZORUNDASIN
//        // Console.WriteLine(kategori); print etmek için kullanılır
//        //değişken kullanmak her zaman iyidirr
//        // Do not repeat yourself --- Kendini tekrarlama
//    }
//    }
//type safety - tip güvenliği

string kategori = "Kategori";

Console.WriteLine(kategori);
Console.WriteLine(kategori);
Console.WriteLine(kategori);
Console.WriteLine(kategori);

int ogrencisayisi = 32000;
double faizOrani = 1.45;

bool ogrencisistem_giris_kontrol = false;
Console.WriteLine(ogrencisistem_giris_kontrol);

// bool veri tipi true false onun için kullanılan değişken

// BİR DEĞİŞKEN ATARKEN ONUN VERİ TİPİİNİ YAZMAK ZORUNDASIN
// Console.WriteLine(kategori); print etmek için kullanılır
//değişken kullanmak her zaman iyidirr
// Do not repeat yourself ---  Kendini tekrarlama

if (ogrencisistem_giris_kontrol == true)
{
    Console.WriteLine("Sisteme giriş başarılır");
}
else
{
    Console.WriteLine("Sistem giriş başarılı değildir");
}
double dolarDun = 32.5;
double dolarBugun = 32.5;

if (dolarBugun>dolarDun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarBugun<dolarDun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("something gone wrong");
}

// bu kısım if else if else komutlarını nasıl çalışacağını gördük tabi 
// daha karışık örnekler kullanılabilir fakat zaten bunun algoritma mantığını 
//python dan biliyorum sadece yazılışını anlamam benim için yeterli olaaktır






