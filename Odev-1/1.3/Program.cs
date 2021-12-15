using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
             DMP:
            Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Giriniz!");
            
          try
          {
               int n;
               
            n=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Şimdi "+n+" adet kelime giriniz :");

            string[] dizi=new string[n];
            for(int i=0;i<n;i++){
                Console.WriteLine((i+1)+". Kelime :");
                dizi[i]=Console.ReadLine();
            }
            Console.WriteLine("***Girdiğin Kelimeler Sondan Başa Doğru Sıralanırsa;");
            Array.Reverse(dizi);
            for(int i=0;i<n;i++){
                
               Console.WriteLine(dizi[i]);
            }
            Console.WriteLine("***Yukarıdaki sırada olur.");
          }
          catch (Exception)
          {
              Console.WriteLine("Pozitif Sayı girsene gardaşım. Patlattın Programı");
              goto DMP;
          }
        }
    }
}
