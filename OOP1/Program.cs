using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;
            // bu şekilde oluşturabilirz değişkeni bunun bir çeşidi daha mevcuttur
            Product product2=new Product { Id = 2,CategoryId = 3,
                ProductName = "Kitap",UnitPrice= 300 ,UnitInStock = 4};
            // Buda diğer çeşidi
            // yazım kurallari aynen böyle olmalıdır 
            // şimdi manager ekleme işlemi yapacak clasın içine gidip
            //ekleme yapmak için gerekli olan kodları yazacağız
            // sonra ekleyeceğimiz parametreyi gireceğiz
            ProductManager productManager = new ProductManager();
            productManager.Add(product1); // artık productı tuttuk tek tek ıd categori tutmicam
        }
    }
}