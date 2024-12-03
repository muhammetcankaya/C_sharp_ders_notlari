using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Musteri
    {
        ////inheritng
        //// bu kullanım yanlıştır inheriting olmuş olur
        //// neden diye sorarsan bizim veri ekleyenler tüzelleri yani şirketleri
        //// normal müsteri gibi veriler eklemesine sebep olur o yüz ayrı iki class
        //// kurmak daha iyidir doğru olan budur

        //public int Id { get; set; }

        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string CompanyName { get; set; }
        //// Bir veri üzerinde çarpma bölme toplama yapmıyorsan bunları metinsel olarak almanda sakınca yoktu
        //public string TcNo { get; set; }
        //public string TaxNo { get; set; }

        //yukarıdsa ki kullanım yanlıştı doğrusunu yapıcaz
        public int Id { get; set; }
        public string CostumerNo { get; set; }
        //bizim tüzel ve gercek müsteriler buradan miras alacağı için bu iki bilgi onların içinde vardır
        // ayrı olarak diğer bilgileri içlelrinde barındırırlar kendilerine ait olunaları
    }
}
