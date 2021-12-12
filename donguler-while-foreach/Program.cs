using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console yazdıran program.
         Console.WriteLine("Lütfen bir sayı giriniz.");
          int sayi=int.Parse(Console.ReadLine());
          int sayac=1;
          int toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine("1den girdiğiniz sayıya kadarki sayının ortalaması: "+toplam/sayi);

            char character ='a';
            while (character<='z')
            {
                 Console.Write(character);
                 character++;
            }

             Console.WriteLine("**** FOREACH ****");
             String[] arabalar={"BMW","TOYOTA","FORD","NİSSAN"};
             foreach (var araba in arabalar)
             {
                 Console.WriteLine(araba);
             }
        }
    }
}
