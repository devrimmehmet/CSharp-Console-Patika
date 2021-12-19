using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci=new Ogrenci();
            ogrenci.Isim="Devrim Mehmet";
            ogrenci.Soyisim="Pattabanoğlu";
            ogrenci.OgrenciNo=543;
            ogrenci.Sinif=1;
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

             Ogrenci ogrenci1=new Ogrenci("Hüseyin Kazim","Pattabanoğlu",250,1);
           
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();



        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim{get => isim; set => isim=value;}
        public string Soyisim
        {
            get{return soyisim;}  
            set{soyisim=value;}
        }
         public int OgrenciNo
        {
            get{return ogrenciNo;}  
            set{ogrenciNo=value;}
        }
         public int Sinif
        {
            get{return sinif;}  
            set
            {
                if(value<1)
                {
                Console.WriteLine("Sınıf En Az 1 Olabilir.");
                sinif=1;
                }else{sinif=value;}
                
            }
        }

        public Ogrenci()
        {

        }
        public Ogrenci(string isim,string soyisim,int ogrenciNo,int sinif)
        {
            Isim=isim;
            Soyisim=isim;
            OgrenciNo=ogrenciNo;
            Sinif=sinif;
        }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("****** Öğrenci Bilgileri ******");
            Console.WriteLine("Öğrenci Adı          :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı       :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci Numarası     :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı       :{0}",this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif=this.Sinif+1;
        }
        public void SinifDusur()
        {
            this.Sinif=this.Sinif-1;
        }
    }
}
