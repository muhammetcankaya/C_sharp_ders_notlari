using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassmetodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriId = 5;
            musteri.MusteriName = "ahmet";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri);
            musteriManager.Delete(musteri);
            musteriManager.Update(musteri);
        }
    }
}
