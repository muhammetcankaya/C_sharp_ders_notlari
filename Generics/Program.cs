using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Şu yukarıda sehiirler listeri 
            // Köşeli parantez içinde string yazıyor ya 
            // Bu tipini söylüyor bunu bizde classlarımızda kullanabiliriz
            // ara not tipler int string olabilir aynı zamanda bir class da olabilir 
            // class Mylist<T> Bu kullanım sayesinde ben clasımı 
            // Gneric class yapmış oldum yani bir liste gibi 
            // tip isteyecek ve tipler ile çalışacak 
            List<string> sehirler = new List<string>();
            //sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.add("ankara");
            sehirler2.add("ankara");
            sehirler2.add("ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T>
    {
        // Bir array oluşturdum
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            // Ve bunu 0 elemanlı yaptım
            _array = new T[0];
        }
        public void add(T item)
        {
            _tempArray= _array;
            _array = new T[_array.Length +1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length -1] = item;
        }
        
        public int Count
        {
            get { return _array.Length; }
        }
    }
        
}
