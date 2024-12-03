using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassmetodDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("başarıyla yüklendi");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("başarıyla silinde");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("başarıyla güncellendi");
        }
    }
}
