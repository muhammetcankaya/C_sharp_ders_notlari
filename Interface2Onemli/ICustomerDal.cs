using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2Onemli
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    // İNTERFACELERİ İMPLEMENTE İÇİN KULLANIRIZ
    // Diyelimki hem oracle hemde mssql le veri eklicez
    // bu interface ile her birine ayrı kullanım yapıcaz
    // normalde bunlarda ayrı classalrda yazılır 
    // görülsün diye birlikte yazıcam
    // metodları yani ekleme silme kodlarını sql için ayrı oracleiçin
    // ayrı olacak şekilde kendi classlarımız içinde yazıyoruz 
    // bizim isterfacemiz manager ile direkt bağlantı kurucak 
    // managerda biz ekle diyeceğiz 
    // bu sefer interface araya girip diyecekki hangisine ekleyelim 
    // çünkü ikisinide bağladı yani kodlarımız genişlemiş olucak 
    // diyelimki  bize dediki bir server daha gelicek o zaman napıcaz
    // bu sistem yoksa sıkıntı varsa
    // onu class oluşturcaz bizim interface onu implemente edicek
    // sonra managerda ekleme yaparken o secenekde olmuş olucak
    // yani bizim CustomerManager direkt sqlserver add ile iletişim kurmak 
    // yerine interface sonra isterse sql server add ile iletişim kuracak
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }
    }
    
}
