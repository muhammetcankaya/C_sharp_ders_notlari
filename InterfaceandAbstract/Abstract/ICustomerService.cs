﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceandAbstract.Entities;

namespace InterfaceandAbstract.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}