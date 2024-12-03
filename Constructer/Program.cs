using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructer == Yapıcı Blok
            // Constructer Bir clası newlediğimiz zaman çalışan bloktur
            // yani class ilkez oluşturulduğu zaman bir kez çalışan bir bloktur bir daha çalışmaz

            Customer customer = new Customer { Id=1,FirstName="Carl",LastName="Galler",City="Newyork" };
            // Buraya veri ekleyelim ve print edelim 
            Console.WriteLine(customer.FirstName);
            // yukarıdaki kodu çalıştırdığım da önce constructerın içindeki sonra FirstName gelecek
            // Constructeri bir metod gibide kullanabiliriz 
            // birden fazla Constructer da yapabliirz yazabilirz
            // parametresi olmayan Constructera defult Constructer denir ve birden fazla yazdığımızda bu her zaman defult olarak çalışmasın diyorsak eğere 
            // Boş bir Constructer en yukarıda yazmak bunun için yeterlidir

            // Şimdi bir tana daha sınıf yappıp bir constructer örneğği daha yapıcam 
            // Customer1 Clasından
            Customer1 customer1 = new Customer1(3,"ahmet","can","ankara");  
            // Constructer sayensinde bu kullanımı yapabildik 
            // Ama bu değerleri ıd name gibi yerlere atanabilmesi için Constructer içinde bunları atamamız lazım
            // Bu kullanımı yaparkeen Öbür kullanımı yapmak için boş constructer tanımladım bazen boş tanımlamamız gerekmez yapmak zorunda olmasını isteyebiliriz
            
        }
    }
    class Customer
    {
        public Customer()
        {
            // İster bunu çağır ister çağırbu bu blok çalışır
            // sen ile bu clası çağırdıysan bu Constructer çalışır
            Console.WriteLine("BURASI OTOMATİK ÇAŞIŞACAK");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
    class Customer1
    {
        public Customer1()
        {
            
        }
        public Customer1(int ıd,string firstname,string lastname,string city)
        {
            Id = ıd;
            FirstName = firstname;
            LastName = lastname;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
