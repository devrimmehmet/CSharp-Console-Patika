using System;

namespace Static_Sinif_ve_Uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //static sınıfın içinde static olmayan birşey kullanılamaz.
            //statik sınıflarda kalıtım işlemi uygulanamaz.
            Console.WriteLine("Çalışan Sayısı :{0}",Calisan.CalisanSayisi);
            Calisan calisan1=new Calisan("Devrim Mehmet","Pattabanoğlu","İnsan Kaynakları");
            Console.WriteLine("Çalışan Sayısı :{0}",Calisan.CalisanSayisi);
            Calisan calisan2=new Calisan("Hüseyin Kazim","Pattabanoğlu","İnsan Kaynakları");
            Calisan calisan3=new Calisan("Mehmet Alper","Sezer","İnsan Kaynakları");
            Console.WriteLine("Çalışan Sayısı :{0}",Calisan.CalisanSayisi);

            
            Console.WriteLine("Toplama işlemi Sonucu :{0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi Sonucu :{0}", Islemler.Cikar(400,50));

        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi{get=> calisanSayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan()
        {
            calisanSayisi=0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim=isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisanSayisi++;

        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
