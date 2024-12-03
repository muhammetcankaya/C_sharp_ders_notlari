using System;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Neden array(diziler) yerine list(listeler) kullanmalıyız
            // dört elemanlı bir array oluşturduğumuzu düşünelim 
            // bu arraye beşinci bir eleman daha oluşturup ona bir değer atamak 
            // istedimiğimiz zaman arrayler bizi hayal kırıklığına uğratır 
            // bu yüzden arrayler kullanım için verimsizdir şimdi bunu yapmaya calışayım 
            // ve zorluğunu görelim
            //string[] sayilar = new string[] {"1","2","3","4"};

            //for (int i = 0; i < 1; i++)
            //{
                
            //    string sayi1 = sayilar[i];
            //    string sayi2 = sayilar[i+1];
            //    string sayi3 = sayilar[i+2];
            //    string sayi4 = sayilar[i+3];
            //    sayilar = new string[] {sayi1,sayi2,sayi3,sayi4,"sayı5" };
            //    //şeklinde anca oldu bunu özel olarak yaptım genelleştirince çok daha zor olacak
            //}
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil"};
            isimler2.Add("Ahmet");
            foreach (string s in isimler2)
            {
                Console.WriteLine(s);
            }


            }
    }
}