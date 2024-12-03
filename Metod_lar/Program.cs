using System;

namespace Metod_lar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // metodlar gömülü fonksiyonlardır bunları kullanabiliriz istediğimiz zaman
            // Bu metodları kendimiz oluşturup classların içine gömebilirz
            // şuanda classları tekrar etmiş olduk
            Product product1=new Product();
            product1.Id= 1;
            product1.Adi = "Elma";
            product1.Fiyati = 50;
            product1.Aciklama = "kırmızı ve mayhoş";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Erik";
            product2.Fiyati = 40;
            product2.Aciklama = "Yeşil ve Ekşi";

            Product[] products =new Product[] { product1, product2 }; // burada array metoduna Product classı eklemiş olduk

            //foreach (Product product in products)   //Burada foreach metoduna Product eklemiş olduk class yani
            //{
            //    Console.WriteLine(product.Id+" "+ product.Adi+" "+product.Fiyati+" "+product.Aciklama);
            //    Console.WriteLine("-------------------");
            //}
            // instance - örnek oluşturma 
            // classa ulaşabilmek için onu o örneğe özel olarak
            //almam lazım 
            //sepetManager2 de eklenebilir onunlada metodlara
            //erişebiliriz
            // şimdi farklı bir mantık işleyecek
            //SepetManager sepetManager = new SepetManager();
            //sepetManager.Ekle();
            // biz classa parametre verdiğimiz için
            // eklenin içine artık değişkeni yazmamız lazım
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);

        }
    }

}
