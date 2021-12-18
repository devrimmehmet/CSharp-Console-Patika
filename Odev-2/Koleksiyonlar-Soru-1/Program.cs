using System;
using System.Collections;
namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
        //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
        //(ArrayList sınıfını kullanara yazınız.)
        //Negatif ve numeric olmayan girişleri engelleyin.
        //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList asalListe=new ArrayList();
            ArrayList Liste=new ArrayList();
            int sayi;
            int n=20;
            int kacinci=1;
            int sayac=0;
         for(int i =0;i<n;i++)
         {
             Console.Write((kacinci)+".Sayıyı Giriniz: ");
            kacinci+=1;
             try
             {
                  sayi=Convert.ToInt32(Console.ReadLine());
                  if(sayi<0){
                      Console.WriteLine("Lütfen Negatif Sayı Girişi veya Numeric Olmayan girişler yapmayın ");
                      kacinci-=1;
                      n+=1;
                  }
                  for(int j=2;j<sayi;j++)
                  {
                      if(sayi%j==0){
                          sayac++;
                      }
                      
                  }
                  if(sayac>0|| sayi==1 || sayi==0 )
                  {
                          Console.WriteLine(sayi+" ASAL Sayı Değildir");
                        Liste.Add(sayi);
                  }
                  if((sayac==0 || sayi==2) && sayi>0)
                  { 
                      if(sayi!=1 && sayi!=0 )
                    {
                        Console.WriteLine(sayi+" ASAL Sayıdır.");
                         asalListe.Add(sayi);
                    }
                          
                  }
                      sayac=0;

             }
             catch 
             {
                 
                 Console.WriteLine("Lütfen Negatif Sayı Girişi veya Numeric Olmayan girişler yapmayın ");
                 kacinci-=1;
                 n+=1;
             }
             if(kacinci>20){
             Console.WriteLine("Tebrikler 20 Sayı Girişi Yaptınız.");
             Liste.Sort();
             asalListe.Sort();
             Console.WriteLine("Girdiğiniz Sayılardan Asal Olmayanların Sıralı Hali");
             int toplam=0;
             int ortalama=0;
             foreach(var item in Liste)
             {
                 
                 Console.WriteLine(item);
                 toplam=toplam+Convert.ToInt32(item);
                 ortalama=toplam/Liste.Count;
             }
             Console.WriteLine("Girdiğiniz Sayılardan Asal Olmayanların Toplamı: "+toplam);
             Console.WriteLine("Girdiğiniz Sayılardan Asal Olmayanların Ortalaması: " +ortalama);
             toplam=0;
             ortalama=0;
             Console.WriteLine("Girdiğiniz Asal Sayıların Sıralı Hali");
             foreach(var item in asalListe)
             {
                 
                 Console.WriteLine(item);
                 toplam=toplam+Convert.ToInt32(item);
                 ortalama=toplam/asalListe.Count;
             }
            Console.WriteLine("Girdiğiniz Asal Sayıların Toplamı: "+toplam);
             Console.WriteLine("Girdiğiniz Asal Sayıların Ortalaması: " +ortalama);
            }

         }
         
        }
    }
}
