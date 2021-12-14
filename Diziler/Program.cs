using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] renkler =new string[5];
            string [] hayvanlar={"Kedi","Köpek","Kuş","Maymun"}; //boyutu 4
            int [] dizi;
            dizi= new int [5];

            // Dizilere değer atama ve Erişim
            renkler[0]="Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3]=10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını alan program
            
            Console.WriteLine("Lütfen Dizinin Eleman Sayısını Giriniz.");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];
            for(int i=0; i<diziUzunlugu;i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz",i+1);
                sayıDizisi[i]=int.Parse(Console.ReadLine());
            }
            int toplam=0;
            foreach (var sayi in sayıDizisi)
            {
                toplam+=sayi;
            }
            Console.WriteLine("Ortalama : "+ toplam/diziUzunlugu);
        }
    }
}
