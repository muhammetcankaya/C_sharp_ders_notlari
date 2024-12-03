using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2Onemli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());

            // bu haliyle oracle ekledi bu nu
            customerManager.Add(new SqlServerCustomerDal());
            //sql ekleme yaptı 
            // ikisine birden ekleme yapmamız gerekseydi napardık oda 45. videoda var zatan yapıcaz
            // bu çok önemliydi
        }
    }
}
