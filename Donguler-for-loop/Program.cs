using System;

namespace Donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
           //  Ekrandan Girilen Sayıya Kadar Olan Tek Sayılarını Ekrana Yazdır.
          Console.WriteLine("Lütfen Bir Sayı Giriniz.");
          int sayac=int.Parse(Console.ReadLine());
        for(int i=1;i<=sayac;i++)
        {
            if(i%2==1)
            {
              Console.WriteLine(i);
            }
        
        }              
        int teklertoplami=0;
        int ciftlertoplami=0;
        for (int i=1;i<1000;i++)
        {                             
              if(i%2==1)
             teklertoplami=teklertoplami+i;              
             if(i%2==0)
             ciftlertoplami=ciftlertoplami+i;
        }
        Console.WriteLine(ciftlertoplami+teklertoplami);

  for (int k=1; k<10; k+=1)
  {
        if(k==4)
        Console.WriteLine(k);
        break;
  }
           for (int i=1; i<10; i=i+1)
          {
                if(i==4)
                Console.WriteLine(i);
                continue;
          }
        }
    }
}
