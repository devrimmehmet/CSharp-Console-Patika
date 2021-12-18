using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
           // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını
           // console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
           
       
            int[] sayilarim=new int[20];
           
           
            int n=20;
            int kacinci=1;
            
         for(int i =0;i<n;i++)
         {
             Console.Write((kacinci)+".Sayıyı Giriniz: ");
            kacinci+=1;
             try
             {
                  sayilarim[kacinci-2]=Convert.ToInt32(Console.ReadLine());
             }
             catch 
             {
                 
                 Console.WriteLine("Lütfen Numeric Olmayan girişler yapmayın ");
                 kacinci-=1;
                 n+=1;
             }

             if(kacinci>20)
             {
             Console.WriteLine("Tebrikler 20 Sayı Girişi Yaptınız.");
             Console.WriteLine("En Küçük 3 Sayınız");
             Array.Sort(sayilarim);
             Console.WriteLine(sayilarim[0]+","+sayilarim[1]+","+sayilarim[2]);
             Console.WriteLine("En Büyük 3 Sayınız");
             Console.WriteLine(sayilarim[19]+","+sayilarim[18]+","+sayilarim[17]);
             Console.WriteLine("En Küçük 3 Sayının ortalaması: "+((sayilarim[0]+sayilarim[1]+sayilarim[2]/3)));
             Console.WriteLine("En Büyük 3 Sayının ortalaması: "+((sayilarim[19]+sayilarim[18]+sayilarim[17]/3)));
            Console.WriteLine("İki Grubun Ortalama Toplamı: "+((sayilarim[19]+sayilarim[18]+sayilarim[17]/3)+(sayilarim[0]+sayilarim[1]+sayilarim[2]/3)));
            }

         }
        }
    }
}
