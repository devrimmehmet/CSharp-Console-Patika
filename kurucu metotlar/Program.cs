using System;

namespace kurucu_metotlar
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


            Calisan calisan1=new Calisan("Ayşe","Kara",23445678,"İnsan Kaynakları");   
            Console.WriteLine("Çalışan1");         
            calisan1.CalisanBilgileri();

            Console.WriteLine("************");
            Calisan calisan2=new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=12345678;
            calisan2.Departman="Satın Alma";
            Console.WriteLine("Çalışan2"); 
            calisan2.CalisanBilgileri();

            Calisan calisan3=new Calisan("Devrim Mehmet","Pattabanoğlu"); // numarasını ve departmanını null atıyor. intte 0 oluyor.
            Console.WriteLine("Çalışan3"); 
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        // kurucu metotların adı sınıfla aynı olmalı ve erişim belirleyicisi public olmalı geri dönüş tipide yoktur.
        //refaktör etmek iyileştirmek
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no, string departman)
        {
           this.Ad=ad;
           this.Soyad=soyad;
           this.No=no;
           this.Departman=departman;

        }
        public Calisan(string ad, string soyad)
        {
           this.Ad=ad;
           this.Soyad=soyad;
           
           
        }
        public Calisan() //bu overload işlemi eski sisteminde çalışmasını sağlar
        {

        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}",Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }
    }
}
