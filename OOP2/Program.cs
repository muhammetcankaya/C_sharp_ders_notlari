using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musterş();
            //musteri1.Name = "Engin";
            //musteri1.Surname = "eroğlu";
            //musteri1.TaxNo = "vergi numarası yok çünkü şirket değil ne yazacak";

            //musteri1.CompanyName = "ne yazacak ????";

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CostumerNo = "12345";
            musteri1.Name = "name";
            musteri1.Surname = "surname";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CostumerNo = "123456";
            musteri2.CompanyName = "name";
            musteri2.TexNo = "23243422";

            // Musteri clasın diğerlerinin mirascısı olduğu için 
            // ikisininde referansını tutabilir
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            
            // bak veri tabanınına 4 müsteriyide gönderdik
            CostomerManager musteriManager = new CostomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);


        }
    }
}
