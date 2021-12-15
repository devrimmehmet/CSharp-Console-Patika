using System;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
             DMP:
            Console.WriteLine("Lütfen Pozitif İki Tam Sayı Giriniz!");
            Console.WriteLine("1.Sayı :");
          try
          {
               int n,m;
               
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı :");
            m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Şimdi "+n+" adet pozitif sayi giriniz :");
            int[] dizi=new int[n];
            for(int i=0;i<n;i++){
                Console.WriteLine((i+1)+". Sayı :");
                dizi[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<n;i++){
                
               if(dizi[i]==m || (dizi[i])%m==0 )
               {
                   Console.WriteLine("Yazdığın "+(i+1)+".sayı "+m+"'e eşit yada bir tamsayıdır" +"("+dizi[i]+")");
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
