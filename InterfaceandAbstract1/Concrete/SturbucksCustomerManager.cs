using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceandAbstract1.Abstract;
using InterfaceandAbstract1.Entities;

namespace InterfaceandAbstract1.Concrete
{
    public class SturbucksCustomerManager:BaseCustomerManager
    {
        // Bu olayın ne olduğunu anlamadım
        private ICustomerCheckService _customerCheckService;

        public SturbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        // bu aralık
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
