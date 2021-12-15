using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
           
             DMP:
            Console.WriteLine("Lütfen Bir Cümle Yazınız.");
            
          try
          {
              
               string neYazdi = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] kelimeDizisi = neYazdi.Split(' '); //boşlukla kelimeleri ayırdığını varsay
            Console.WriteLine("Kelime Sayısı :" + kelimeDizisi.Length);

            int sayac = 0;
            for (int i = 0; i < neYazdi.Length; i++)
            {
                //harf harf listemizde varmı varsa sayacımız 1 harf var diyor. kontrol ediyoruz.
                if (liste.Contains(neYazdi[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("toplam {0} tane  harf vardır.", sayac);
            Console.ReadLine();
           
          }
          catch (Exception)
          {
              
              goto DMP;
          }
        }
    }
}
