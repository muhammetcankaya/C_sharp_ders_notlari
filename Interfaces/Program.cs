using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    // interface isimleri başına I alır
    // İnterfaceler soyut yani Burada Iperson soyuttur diğerleri somuttur 
    //  diğer classlar soyut özellikleri interface sayesinde kazanır 
    // bu metod olabilir veya tanımlar olabilir genelde metod için kullanılır
    // belli metodları biz bu interface kullanarak diğer sınıflar içinde barındırıız
    // yani her sınıf için ayrı ayrı metod yazmayız olaki yazdık bu metodlardan birinde
    // değişiklik yapmamız gerektiğinde tek tek mi değiştircez 
    // Bunları Interface içinde soyut olarak tutarsak hepsinde tanımlarsak değişiklik 
    // gerektiği yerde htek br yerde değğişiklik yapmamız yeterli olur
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }  

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Addres { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
}
