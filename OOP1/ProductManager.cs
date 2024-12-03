using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        // Product product kısmı aslında tipi product clası olan
        // yani dinamik yapıda olan
        // Product tan ıd çekersek int olan isim çekersek string olan bir yapı
        // yani bu ekleme işlemini o classdan alacağız aslında 
        // dediğim gibi normalde o class yerine veri tabanı geçer 
        public void Add(Product product)
        {
            //ürün eklemek için oluşturulan class
            // Normal şartlarda aldığımız productı burdan buradaki işlemler ile
            // VerİTabanına iletme kodlarını yazacağız henüz veritabanını işlemediğimiz için
            // Nasıl bir şey yapacağız bakalım
            //kısa bir bilgi 
            // int double bool ... bunlar değer tipdir
            // diziler ,class ,abstract class ,interface ... referans tipdir 
            // bir clasın içine değer tip gönderirsen değeri alır
            // referans tip gönderirsen referansı alır ordaki değişiklir kalıcı olur
            // diğerinde olmaz
            Console.WriteLine(product.ProductName + " Eklendi:");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+ "Güncellendi;");
        }
        //void ne işe yarar
        //bir şey yap git ekle, git sil, git güncelle bitir
        // void bir işi yapar bitirir değeri arkada saklamaz return etmez ama onun 
        // yerine şöyle yaparsak
        // publid int topla(int sayı1,int sayı2); return sayı1=sayı2 artık bunu bir değişkende tutabiliriz void kullanma veya kullanmama sebebimiz yokrur

    }
}
