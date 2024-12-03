using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceandAbstract1.Abstract;
using InterfaceandAbstract1.Concrete;
using InterfaceandAbstract1.Entities;

namespace InterfaceandAbstract1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                DateOfBirth = new DateTime(1975, 1, 6),
                FirstName = "merve",
                LastName = "kaya",
                NationalityId = "231321231"
            };
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(customer);

        }
    }
}
