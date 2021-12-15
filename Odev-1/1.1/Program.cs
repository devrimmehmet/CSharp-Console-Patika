using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            DMP:
            Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz :");
         
          try
          {
               int pozitif;
            pozitif=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Şimdi "+pozitif+" adet pozitif sayi giriniz :");
            int[] dizi=new int[pozitif];
            for(int i=0;i<pozitif;i++){
                Console.WriteLine((i+1)+". Sayı :");
                dizi[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<pozitif;i++){
                
               if(dizi[i]%2==0)
               {
                   Console.WriteLine("Yazdığın "+(i+1)+".sayı çift bir sayıdır" +"("+dizi[i]+")");
               } 
            }
          }
          catch (Exception)
          {
              Console.WriteLine("Pozitif Sayı girsene gardaşım. Patlattın Programı");
              goto DMP;
          }
            
            
        }
    }
}
