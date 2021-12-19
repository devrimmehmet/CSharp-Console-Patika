using System;

namespace sinif_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            // [Erişim Belirleyici] [Veri Tipi] OzellikAdi;    
            // [Erişim Belirleyici(public private internal protected)] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //      {
            //  //Metot Komutları    
            //      }   
            // }
            // Erişim Belirleyiciler
            // *Public Heryerden Erişilebilir
            // *Private Sadece Tanımlandığı Sınıf içerisinden erişilebilir
            // *Internal Sadece Kendi Bulunduğu Proje içerisinde erişilebilir
            // *Protected Sadece Tanımlandığı sınıfta veya o sınıftan kalıtım alan diğer sınıflardan
            Calisan calisan1=new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=23445678;
            calisan1.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("************");
            Calisan calisan2=new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=12345678;
            calisan2.Departman="Satın Alma";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}",Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }
    }

}
