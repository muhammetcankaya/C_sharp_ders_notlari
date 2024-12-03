Console.WriteLine("Hello, World!");
        
for (int i = 1; i < 10; i=i+1)
{
    // i=1 i 10 dan küçük olduğu sürecce çalıştır 
    // i++ veya i=i+1 i+=1 her döngü bittiğinde bir ekle
    Console.WriteLine(i); 
}

// liste verileri array yani dizilerde tanımlanır
// bir string array 
string[] dersler = new string[] 
{"soyut cebir","analiz","diferansiyel denklemler" };
// gercek hayatta böyle olur
//string[] dersler = kurslarıgetir();
// kursları getir bir veri kaynağı başka yerden gelir

for (int i = 0; i < dersler.Length; i++)
{
    
    string ders = dersler[i];
    Console.WriteLine(dersler[i]);
    ders = " " + ders;
    for (int j = 0; j < ders.Length; j++)
    {

    Console.WriteLine("    " + ders[j]); 
    } 
    //burada da güzel bir for döngsü örneği oldu
}

foreach (string ders in dersler)
{
    // for döngüsünün bir çeşiti yani aynısı
    // yukardakinin aynısını yapalım
    Console.WriteLine(ders);
    foreach (var der in ders)
    {
        Console.WriteLine(der);
        //for döngüsnünden çok daha kolay
    }
}


















