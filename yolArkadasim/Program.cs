int bodrumFiyat = 4000; int marmarisFiyat = 3000; int cesmeFiyat = 5000;
int karaYoluFiyat = 1500; int havaYoluFiyat = 4000;
string lokasyon; int kisiSayisi = 0; int ulasimSecimi = 0; int toplamFiyat = 0;
string devam = "evet";

while (devam == "evet")
{
    while (true)
    {
        Console.WriteLine("Gidebileceğiniz lokasyonlar: Bodrum, Marmaris, Çeşme");
        Console.Write("Lütfen gitmek istediğiniz lokasyonu seçin: ");
        lokasyon = Console.ReadLine().ToLower();

        if (lokasyon == "bodrum" || lokasyon == "marmaris" || lokasyon == "çeşme")
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz lokasyon girdiniz. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
        }
    }


    if (lokasyon == "bodrum")
    {
        toplamFiyat = toplamFiyat + bodrumFiyat;
    }
    else if (lokasyon == "marmaris")
    {
        toplamFiyat = toplamFiyat + marmarisFiyat;
    }
    else if (lokasyon == "çeşme")
    {
        toplamFiyat = toplamFiyat + cesmeFiyat;
    }

    while (true)
    {
        Console.Write("Lütfen tatili kaç kişi planladığınızı girin: ");
        if (int.TryParse(Console.ReadLine(), out kisiSayisi) && kisiSayisi > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen pozitif bir sayı giriniz.");
        }
    }


    while (true)
    {
        Console.WriteLine("Ulaşım seçenekleri:");
        Console.WriteLine("1 - Kara yolu (Kişi başı gidiş-dönüş 1500 TL)");
        Console.WriteLine("2 - Hava yolu (Kişi başı gidiş-dönüş 4000 TL)");
        Console.Write("Lütfen ulaşım seçimini yapınız (1 veya 2): ");
        if (int.TryParse(Console.ReadLine(), out ulasimSecimi) && (ulasimSecimi == 1 || ulasimSecimi == 2))
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz seçim yaptınız. Lütfen 1 veya 2 yazınız.");
        }
    }

    if (ulasimSecimi == 1)
    {
        toplamFiyat = toplamFiyat + kisiSayisi * karaYoluFiyat;
    }
    else if (ulasimSecimi == 2)
    {
        toplamFiyat = toplamFiyat + kisiSayisi * havaYoluFiyat;
    }

    Console.WriteLine($"\nSeçtiğiniz lokasyon: {lokasyon}");
    Console.WriteLine($"Kişi sayısı: {kisiSayisi}");
    Console.WriteLine($"Ulaşım şekli: {(ulasimSecimi == 1 ? "Kara yolu" : "Hava yolu")}");
    Console.WriteLine($"Toplam tatil maliyeti: {toplamFiyat} TL");
    Console.WriteLine("Yeniden başka bir tatil için harcama planı çıkartmamı ister misin ? ");
    devam = Console.ReadLine().ToLower();

}

Console.WriteLine("İyi Günler :) ");