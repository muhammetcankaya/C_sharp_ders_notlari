using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {   
        // prob(snippet ) 
        // Burası 
        public int Id { get; set; }
        public int CategoryId { get; set; }//foreign key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}
