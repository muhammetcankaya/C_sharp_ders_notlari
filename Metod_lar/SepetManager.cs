using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Metod_lar
{
    internal class SepetManager
    {
        //burda classsların başka kullanımını gördük 
        //Bu cclasın içine ben spete ekleme işini yerleştirdim
        // tabi bu işlem daha komplike olacak gerçek hayatta 
        //Bunu çağırdığımızda class dan metodu çağırmış olucaz 
        // metodda sepete ekleme
        // bunun içine sepetten çıkarda ekleyebilirdik oda 
        // Farklı bir metod olurdu
        //public void Ekle()
        //{
        //    Console.WriteLine("Sepete eklendi");
        //}

        // Burada daha farklı bir kullanım yapacağız
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi :"+product.Aciklama);
        }
        //şimdi yukarııdaki ile aşağıdakini farkını anlayalım yukardaki product classında product değişkeni alıyor
        // ve bu değişken o clasın içinde barının ürün adı fiyatı açıklaması gibi verileri tutuyor ekstradan 2 değişken
        //atamaya gerek kalmıyor ama iyi yanı bu sadece bu değil hatta bu önemli bile değil
        //diyelimki aşağıdakini kullanıp ürünleri sayfanın bir çok yerine ekledik ve bize bir değişken daha eklememizi
        //söylediler ne yapacağız burda bir değişken oluşturcağız ekstradan console kısmına yazacağız 
        // buna ek olarak her sayfa o koda o veriyi ekleyeceğiz
        //ama üstte veriyi zaten classdan aldık bizim o veriye ekleyeceğiz tek şey o clasa gidip değişkenş oluşturcaz
        //ve veriyi clasa gömeceğiz bu kadar ikisi arasın inanılmaz bir fark mevcuttur kaçırma
        // bu olaya kapsülleme denir (encapsulation)

        public void Ekle2(string urunad,int urunfiyat,string acıklama_urun)
        {
            Console.WriteLine("urunle alakalı bilgiler"+urunad+" "+urunfiyat+" "+acıklama_urun);
        }
    }
}
