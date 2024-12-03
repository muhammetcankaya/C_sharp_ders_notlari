using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceandAbstract.Abstract;
using InterfaceandAbstract.Concrete;
using InterfaceandAbstract.Entities;

namespace InterfaceandAbstract
{
    //Senaryo
    // Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
    // İki firma da müşterilerini veri tabanına kaydetmek istiyor
    // Starbucks müşterilerini kaydederken, mutlaka mernis doğrulaması istiyor
    // Nero müşterilerini kaydederken böyle bir şey istemiyor 
    // Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor 
    // ekleme işlemi yapacağım için bir interface oluşturmam gerekli
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                DateOfBirth = new DateTime(1975, 1, 6),
                FirstName = "Merve",
                LastName = "Karayıldız",
                NationalityId = "231321231"
            };
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(customer);
            
         


        }
    
    }

}
