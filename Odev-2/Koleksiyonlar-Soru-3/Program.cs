using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
                //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

                Console.WriteLine("Bir Cümle Giriniz.");
                string cumle=Console.ReadLine();
                 string liste = "AEİIOÖUÜ" + "aeiıoöuü";
                List<string> SesliHarfler=new List<string>();
            
            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                //harf harf listemizde varmı varsa sayacımız 1 harf var diyor. kontrol ediyoruz.
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                    SesliHarfler.Add(cumle[i].ToString());
                }
            }
            Console.WriteLine("toplam {0} tane sesli harf vardır.", sayac);
            SesliHarfler.Sort();
            Console.Write("Sıralı şekilde listesi: ", sayac);
            foreach(var item in SesliHarfler)
            {
                Console.Write(item+" ");
            }
        }
    }
}
