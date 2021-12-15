using System;

namespace metotlar
{
    class Program
    {
        //static metotlarda sadece static classlar erişilebilir.
        static void Main(string[] args)
        {
            //Rrişim Belirteci : metoda nerden erişebilecez? public private gibi
            //Geri Dönüş Tipi  : Geri dönecekmi ? dönecekse ne dönecek ? geri dönmezse ''void'' yazılır. (metodun imzasına ait mutlaka yazılmalı)
            // metoda vereceğiniz isim ÇOK ÖNEMLİ adına bakarak işinizi görecek kalitede olmalı
            //Parametre Listesi: Hangi parametrelerle çalışacaksa
            //erisim_belirteci geri_donustipi metot_adi(parametrelistesi/arguman)
            //{
               // komutlar
            //}
            int a=2;
            int b=3;
            Console.WriteLine(a+b);


            int sonuc=Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek=new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString()); // Convert.ToString(sonuc)

            int sonuc2=ornek.ArttirVeTopla(ref a,ref b); //ref anahtar kelimesini kullanırsan değer değişir yani atama yapmışsın gibi olur gelen sonucu aya atar yine
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
        }
        static int Topla(int deger1,int deger2)
        {
            return(deger1+deger2);
        }
    }
    class Metotlar
    {
      public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
      public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
