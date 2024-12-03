using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceandAbstract1.Abstract;
using InterfaceandAbstract1.Entities;

namespace InterfaceandAbstract1.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
