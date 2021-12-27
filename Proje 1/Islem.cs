using System;
using System.Collections.Generic;
namespace Proje_1
{
public static class Islem
    {
        static List<Kisi> rehber = new List<Kisi>()
        {
            new Kisi("Devrim Mehmet", "Pattabanoğlu", "9999999999"),
            new Kisi("Mehmet Alper", "Sezer", "8888888888"),
            new Kisi("Tayfun", "Ünal", "7777777777"),
            new Kisi("Mehmet", "Arslan", "6666666666"),
            new Kisi("Burak", "Koca", "5555555555"),
    };
        
public static void NumaraEkle()
    {
            Console.Write("Ad      : ");     string isim = Console.ReadLine();
            Console.Write("Soyad   : ");     string soyisim = Console.ReadLine();
            Console.Write("Telefon : ");     string tel = Console.ReadLine();
            
            Kisi yeniKayit = new Kisi(isim, soyisim, tel);
            rehber.Add(yeniKayit);
          
            Console.WriteLine(isim +" "+soyisim+" rehbere başarıyla kaydedildi. "+"( Tel: "+tel+" )");
            Console.ReadKey(); // bir tuşa basmadan ekran kapanmasın yaptığı kaydı inceleyebilsin. 
    }
 public static void SecimHatasi()
        {
            Console.WriteLine("İstenmeyen bir giriş yaptınız ana menüye yönlendiriliyorsunuz.");
            Console.ReadKey();
        }
public static void NumaraSil()
    {
            Console.WriteLine("Lütfen rehberden silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            int kisiSayisi = rehber.Count;
            string silinecek = Console.ReadLine();
            bool Durum = true;

            for (int i = kisiSayisi - 1; i >= 0; i--)
            {
                if (rehber[i].isim == silinecek || rehber[i].soyisim == silinecek)
                {
                    Durum = false;
                    Console.WriteLine("{0} {1} rehberden silinmek üzere, onaylıyor musunuz ?(E/H)", rehber[i].isim, rehber[i].soyisim);
                    string cevap = Console.ReadLine();

                    if (cevap == "e" ||cevap == "E"  )
                    {
                        rehber.Remove(rehber[i]);
                        Console.WriteLine("Numara başarıyla silindi.");
                        Console.ReadKey();
                        Console.Clear();
                    }    
                    
                    if (cevap == "h" || cevap == "H")
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    if (cevap != "h" && cevap != "H" && cevap != "e" && cevap != "E" )
                    {
                        SecimHatasi();
                    }
                    
                }
            }

            if (Durum)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                int yenidenDene;
                while (!Int32.TryParse(Console.ReadLine(), out yenidenDene)){} 
                switch (yenidenDene)
                {
                    case 1:
                        Console.ReadKey();
                        Console.Clear();
                        break;
            
                    case 2:
                        NumaraSil();
                        break;
                    
                    default:{
                        SecimHatasi();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }
    }


public static void NumaraDegistir()
    {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            int kisiSayisi = rehber.Count;
            string numaraGuncelle = Console.ReadLine();
            bool Durum = true;

            for (int i = kisiSayisi - 1; i >= 0; i--)
            {
                if (rehber[i].isim == numaraGuncelle || rehber[i].soyisim == numaraGuncelle)
                {
                    Durum = false;
                    Console.WriteLine("{0} {1} ({2}) ilgili kişinin yeni numarasını giriniz.", rehber[i].isim, rehber[i].soyisim,rehber[i].tel);
                    rehber[i].tel= Console.ReadLine();
                    Console.WriteLine("Numara başarıyla güncellendi.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }

            if (Durum)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");

                int yenidenDene;
                while (!Int32.TryParse(Console.ReadLine(), out yenidenDene)){}
                switch (yenidenDene)
                {
                    case 1:
                        
                        Console.Clear();
                        break;
            
                    case 2:
                        Console.Clear();
                        NumaraDegistir();
                        break;
                    
                    default:{
                        SecimHatasi();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }
    }

public static void NumaraListele()
    {
            Console.WriteLine("(A-Z) Listeleme için : (1)");
            Console.WriteLine("(Z-A) Listeleme için : (2)");

            int yenidenDene;
            while (!Int32.TryParse(Console.ReadLine(), out yenidenDene)){}

            switch (yenidenDene)
            {
                case 1:{
                    rehber.Sort((x, y) => string.Compare(x.soyisim, y.soyisim));
                    rehber.Sort((x, y) => string.Compare(x.isim, y.isim));
                    Console.WriteLine("Arama sonuçlarınız:");
                    Console.WriteLine("**********************************************");
                    foreach (var kişi in rehber)
                    {
                        Console.WriteLine("İsim             : {0}", kişi.isim);
                        Console.WriteLine("Soyisim          : {0}", kişi.soyisim);
                        Console.WriteLine("Telefon Numarası : {0}", kişi.tel);
                        Console.WriteLine("-");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 2:{
                    rehber.Sort((x, y) => string.Compare(x.soyisim, y.soyisim));
                    rehber.Sort((x, y) => string.Compare(x.isim, y.isim));
                    rehber.Reverse();
                    Console.WriteLine("Arama sonuçlarınız:");
                    Console.WriteLine("**********************************************");
                    foreach (var kişi in rehber)
                    {
                        Console.WriteLine("İsim             : {0}", kişi.isim);
                        Console.WriteLine("Soyisim          : {0}", kişi.soyisim);
                        Console.WriteLine("Telefon Numarası : {0}", kişi.tel);
                        Console.WriteLine("-");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                
                default:{
                    Console.Clear();
                    SecimHatasi();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
    }

public static void NumaraArama()
    {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("\nİsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int yenidenDene;
            while (!Int32.TryParse(Console.ReadLine(), out yenidenDene)){}

            switch (yenidenDene)
            {
                case 1:{
                    Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    string arananIsim = Console.ReadLine();

                    rehber.Sort((x, y) => string.Compare(x.soyisim, y.soyisim)); // aynı isim soyisimde  biri varsa ilk sıradakini seçsin diye
                    rehber.Sort((x, y) => string.Compare(x.isim, y.isim));
                    Console.WriteLine("Arama sonuçlarınız:");
                    Console.WriteLine("**********************************************");

                    bool durum = true;

                    foreach (var kisi in rehber)
                    {
                        if (kisi.isim == arananIsim || kisi.soyisim == arananIsim)
                        {
                            durum = false;
                            Console.WriteLine("İsim             : {0}", kisi.isim);
                            Console.WriteLine("Soyisim          : {0}", kisi.soyisim);
                            Console.WriteLine("Telefon Numarası : {0}", kisi.tel);
                            Console.WriteLine("-");
                        }       
                    }

                    if (durum)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Aramayı sonlandırmak için      : (1)");
                        Console.WriteLine("* Yeniden denemek için           : (2)");

                        int yenidenDeneme;
                        while (!Int32.TryParse(Console.ReadLine(), out yenidenDeneme)){}
                        switch (yenidenDeneme)
                        {
                            case 1:
                                Console.ReadKey();
                                Console.Clear();
                                break;
            
                            case 2:
                                NumaraArama();
                                break;
                    
                            default:{
                                SecimHatasi();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 2:{
                    Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin numarasını giriniz:");
                    string arananNumara = Console.ReadLine();

                    rehber.Sort((x, y) => string.Compare(x.soyisim, y.soyisim));// aynı numarada  biri varsa ilk sıradakini seçsin diye
                    rehber.Sort((x, y) => string.Compare(x.isim, y.isim));
                    Console.WriteLine("Arama sonuçlarınız:");
                    Console.WriteLine("**********************************************");

                    bool durum = true;

                    foreach (var kişi in rehber)
                    {
                        if (kişi.tel == arananNumara)
                        {
                            durum = false;
                            Console.WriteLine("İsim             : {0}", kişi.isim);
                            Console.WriteLine("Soyisim          : {0}", kişi.soyisim);
                            Console.WriteLine("Telefon Numarası : {0}", kişi.tel);
                            Console.WriteLine("-");
                        }       
                    }
                    
                    if (durum)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Aramayı sonlandırmak için      : (1)");
                        Console.WriteLine("* Yeniden denemek için           : (2)");

                        int yenidenDenemek;
                        while (!Int32.TryParse(Console.ReadLine(), out yenidenDenemek)){}
                        switch (yenidenDenemek)
                        {
                            case 1:
                                Console.ReadKey();
                                Console.Clear();
                                break;
            
                            case 2:
                                NumaraArama();
                                break;
                    
                            default:{
                                SecimHatasi();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                
                default:{
                    Console.Clear();
                    SecimHatasi();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
    }
    }
}