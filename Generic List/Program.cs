using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class // T generic diyor object türündedir nesne alabilir
            //System.Collections.Generic
            // T-> object türündedir.

          
           List<int> sayiListesi=new List<int>();
           sayiListesi.Add(23);
           sayiListesi.Add(10);
           sayiListesi.Add(4);
           sayiListesi.Add(5);
           sayiListesi.Add(92);
           sayiListesi.Add(34);

           List<string> renkListesi=new List<string>();
           renkListesi.Add("Kırmızı");
           renkListesi.Add("Mavi");
           renkListesi.Add("Turuncu");
           renkListesi.Add("Sari");
           renkListesi.Add("Yeşil");

           //Count
           Console.WriteLine(renkListesi.Count);
           Console.WriteLine(sayiListesi.Count);

           foreach(var sayi in sayiListesi)
           {
               Console.WriteLine(sayi);
           }
           foreach(var renk in renkListesi)
           {
               Console.WriteLine(renk);
           }

           Console.WriteLine("Kolay Foreach Kullanımı");

           sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
           renkListesi.ForEach(renk=> Console.WriteLine(renk));

           Console.WriteLine("Listeden Eleman Cıkarma");

           sayiListesi.Remove(4);
           renkListesi.Remove("Yeşil");

           sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
           renkListesi.ForEach(renk=> Console.WriteLine(renk));

           sayiListesi.RemoveAt(0);
           renkListesi.RemoveAt(1);
           sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
           renkListesi.ForEach(renk=> Console.WriteLine(renk));

           Console.WriteLine("Liste İçerisinde Arama");
           if(sayiListesi.Contains(10))
           {
               Console.WriteLine("10 Liste İçerisinde bulundu!");
           }

           //Eleman ile İndex'e erişme
           Console.WriteLine(renkListesi.BinarySearch("Sari"));//unutma kontrol et burda bir sıkıntı var

           //Diziyi liste çevirme
           string[] hayvanlar={"Kedi","Köpek","Kuş"};
           List<string> hayvanListesi=new List<string>(hayvanlar);

           //Listeyi Nasıl Temizleriz?
           hayvanListesi.Clear();


           //Liste içerisinde Nesne Tutmak
           List<Kullanıcılar> kullanıcıListesi=new List<Kullanıcılar>();
           Kullanıcılar kullanıcı1=new Kullanıcılar();
           kullanıcı1.Isim="Devrim Mehmet";
           kullanıcı1.Soyisim="Pattabanoğlu";
           kullanıcı1.Yas=28;
           Kullanıcılar kullanıcı2=new Kullanıcılar();
           kullanıcı2.Isim="Hüseyin Kazım";
           kullanıcı2.Soyisim="Pattabanoğlu";
           kullanıcı2.Yas=15;

           kullanıcıListesi.Add(kullanıcı1);
           kullanıcıListesi.Add(kullanıcı2);

           List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();
           yeniListe.Add(new Kullanıcılar(){
               Isim="Deniz", Soyisim="Arda",Yas=24
           });

           foreach(var kullanici in kullanıcıListesi)
           {
                Console.WriteLine("Kullanıcı Adı:"+kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı:"+kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:"+kullanici.Yas);

           }
        yeniListe.Clear();
 

        }
    }
    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim{get => isim; set=> isim=value;}
        public string Soyisim{get => soyisim; set=> soyisim=value;}
        public int Yas{get => yas; set=> yas=value;}
    }
}
