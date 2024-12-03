using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceandAbstract1.Entities;

namespace InterfaceandAbstract1.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
