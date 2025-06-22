//Class lar kullanılmadan yazılmış kod=
/*
string[] urunler = { "Filtre", "Mocha", "Latte", "Americano", "ÇIKIŞ" };
decimal[] fiyatlar = { 90, 120, 150, 100, 0 };
int[] sepetUrun = new int[5];
int[] sepetFiyat = new int[5];

decimal bakiye = 0;
int puan = 0;
Random rnd = new Random();

Console.WriteLine("HOŞGELDİNİZ KAFETERYA UYGULAMASINA!");

do
{
    GosterDurum();
    MenuGoster();
    BakiyeIslemleri();

    int secim = MusteriSecim();

    if (secim == 5)
    {
        Console.WriteLine("\nÇıkış yapılıyor...");
        SepetiGoster();
        break;
    }

    if (secim < 1 || secim > 5)
    {
        Console.WriteLine("Geçersiz seçim. Lütfen 1-5 arasında bir sayı giriniz.");
        Console.Clear();
        continue;
    }

    MSIsleme(secim);

    Console.Write("\nBaşka bir sipariş vermek ister misiniz? (E/H): ");
    string devam = Console.ReadLine().ToUpper();
    if (devam != "E")
    {
        Console.WriteLine("\nTeşekkürler! Çıkış yapılıyor...");
        SepetiGoster();
        break;
    }

} while (true);

void MenuGoster()
{
    Console.WriteLine("\n--- MENÜ ---");
    for (int i = 0; i < urunler.Length; i++)
    {
        Console.WriteLine($"{i + 1} - {urunler[i]}: {fiyatlar[i]} TL");
    }
}

void BakiyeIslemleri()
{
    Console.WriteLine("\nBakiye yüklemek ister misiniz?");
    Console.WriteLine("1 - Evet");
    Console.WriteLine("2 - Hayır");
    string secim = Console.ReadLine();

    if (secim == "1")
    {
        Console.Write("Yüklenecek bakiye tutarını giriniz: ");
        bakiye += decimal.Parse(Console.ReadLine());
        Console.WriteLine("Bakiye yüklendi.");
    }
    else if (secim == "2")
    {
        Console.WriteLine("Bakiye yüklenmedi.");
    }
    else
    {
        Console.WriteLine("Geçersiz seçim. Devam ediliyor...");
    }
}

int MusteriSecim()
{
    Console.Write("\nLütfen siparişinizi yapın (1-5): ");
    return int.Parse(Console.ReadLine());
}

void MSIsleme(int secim)
{
    int index = secim - 1;

    Console.Write("Kaç adet istiyorsunuz? ");
    int adet = int.Parse(Console.ReadLine());

    decimal tutar = fiyatlar[index] * adet;

    if (tutar > bakiye)
    {
        Console.WriteLine("Yetersiz bakiye. Lütfen bakiyenizi kontrol edin.");
        return;
    }

    bakiye -= tutar;
    int kazanilanPuan = rnd.Next(5, 21);
    puan += kazanilanPuan;

    sepetUrun[index] += adet;
    sepetFiyat[index] += (int)tutar;

    Console.WriteLine($"\n{urunler[index]} x{adet} siparişiniz alındı.");
    Console.WriteLine($"Tutar: {tutar} TL | Kazanılan Puan: {kazanilanPuan} | Kalan Bakiye: {bakiye} TL | Toplam Puan: {puan}");

    if (puan >= 100)
    {
        Console.WriteLine("Tebrikler! 100 puanı geçtiniz, bir ücretsiz kahve kazandınız!");
        puan -= 100;
    }
}

void SepetiGoster()
{
    Console.WriteLine("\nSİPARİŞ SEPETİNİZ:");
    for (int i = 0; i < urunler.Length - 1; i++)
    {
        if (sepetUrun[i] > 0)
        {
            Console.WriteLine($"{urunler[i]} x{sepetUrun[i]} = {sepetFiyat[i]} TL");
        }
    }
    Console.WriteLine($"Toplam Puan: {puan} | Kalan Bakiye: {bakiye} TL\n");
}

void GosterDurum()
{
    Console.WriteLine($"\nMevcut Bakiye: {bakiye} TL | Mevcut Puan: {puan}");
}
 */


//class oluştur kahve için 


using CA_ClassHomeworkCoffeOrderingAppRevizyon1;


Coffee coffee = new Coffee();
coffee.Name = "Filtre";
coffee.Price = 90;

Coffee coffee1 = new Coffee();
coffee1.Name = "Mocha";
coffee1.Price = 120;

Coffee coffee2 = new Coffee();
coffee2.Name = "Latte";
coffee2.Price = 150;

Coffee coffee3 = new Coffee();
coffee3.Name = "Americano";
coffee3.Price = 100;

Coffee coffee4 = new Coffee();
coffee4.Name = "ÇIKIŞ";
coffee4.Price = 0;


Coffee[] coffees = { coffee, coffee1, coffee2, coffee3, coffee4 };





//string[] urunler = { "Filtre", "Mocha", "Latte", "Americano", "ÇIKIŞ" };
//decimal[] fiyatlar = { 90, 120, 150, 100, 0 };



int[] sepetUrun = new int[5];
int[] sepetFiyat = new int[5];

decimal bakiye = 0;
int puan = 0;
Random rnd = new Random();

Console.WriteLine("HOŞGELDİNİZ KAFETERYA UYGULAMASINA!");

do
{
    GosterDurum();
    MenuGoster();
    BakiyeIslemleri();

    int secim = MusteriSecim();

    if (secim == 5)
    {
        Console.WriteLine("\nÇıkış yapılıyor...");
        SepetiGoster();
        break;
    }

    if (secim < 1 || secim > 5)
    {
        Console.WriteLine("Geçersiz seçim. Lütfen 1-5 arasında bir sayı giriniz.");
        Console.Clear();
        continue;
    }

    MSIsleme(secim);

    Console.Write("\nBaşka bir sipariş vermek ister misiniz? (E/H): ");
    string devam = Console.ReadLine().ToUpper();
    if (devam != "E")
    {
        Console.WriteLine("\nTeşekkürler! Çıkış yapılıyor...");
        SepetiGoster();
        break;
    }

} while (true);



void BakiyeIslemleri()
{
    Console.WriteLine("\nBakiye yüklemek ister misiniz?");
    Console.WriteLine("1 - Evet");
    Console.WriteLine("2 - Hayır");
    string secim = Console.ReadLine();

    if (secim == "1")
    {
        Console.Write("Yüklenecek bakiye tutarını giriniz: ");
        bakiye += decimal.Parse(Console.ReadLine());
        Console.WriteLine("Bakiye yüklendi.");
    }
    else if (secim == "2")
    {
        Console.WriteLine("Bakiye yüklenmedi.");
    }
    else
    {
        Console.WriteLine("Geçersiz seçim. Devam ediliyor...");
    }
}

void MenuGoster()
{
    for (int i = 0; i < coffees.Length; i++)
    {
        Console.WriteLine($"MENU= \n {i + 1}. {coffees[i].Name}= {coffees[i].Price}TL \n");
    }
}
int MusteriSecim()
{
    Console.Write("\nLütfen siparişinizi yapın (1-5): ");
    return int.Parse(Console.ReadLine());
}

void MSIsleme(int secim)
{
    int index = secim - 1;

    Console.Write("Kaç adet istiyorsunuz? ");
    int adet = int.Parse(Console.ReadLine());

    decimal tutar = coffees[index].Price * adet;

    if (tutar > bakiye)
    {
        Console.WriteLine("Yetersiz bakiye. Lütfen bakiyenizi kontrol edin.");
        return;
    }

    bakiye -= tutar;
    int kazanilanPuan = rnd.Next(5, 21);
    puan += kazanilanPuan;

    sepetUrun[index] += adet;
    sepetFiyat[index] += (int)tutar;

    Console.WriteLine($"\n{coffees[index].Name} x{adet} siparişiniz alındı.");
    Console.WriteLine($"Tutar: {tutar} TL | Kazanılan Puan: {kazanilanPuan} | Kalan Bakiye: {bakiye} TL | Toplam Puan: {puan}");

    if (puan >= 100)
    {
        Console.WriteLine("Tebrikler! 100 puanı geçtiniz, bir ücretsiz kahve kazandınız!");
        puan -= 100;
    }
}

void SepetiGoster()
{
    Console.WriteLine("\nSİPARİŞ SEPETİNİZ:");
    for (int i = 0; i < coffee.Name.Length - 1; i++)
    {
        if (sepetUrun[i] > 0)
        {
            Console.WriteLine($"{coffee.Name[i]} x{sepetUrun[i]} = {sepetFiyat[i]} TL");
        }
    }
    Console.WriteLine($"Toplam Puan: {puan} | Kalan Bakiye: {bakiye} TL\n");
}

void GosterDurum()
{
    Console.WriteLine($"\nMevcut Bakiye: {bakiye} TL | Mevcut Puan: {puan}");
}