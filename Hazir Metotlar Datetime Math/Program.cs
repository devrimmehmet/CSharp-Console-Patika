using System;

namespace Hazir_Metotlar_Datetime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(DateTime.Now); // günün tarihi 
          Console.WriteLine(DateTime.Now.Date); 
          Console.WriteLine(DateTime.Now.Day);
          Console.WriteLine(DateTime.Now.Month);
          Console.WriteLine(DateTime.Now.Year);
          Console.WriteLine(DateTime.Now.Hour);
          Console.WriteLine(DateTime.Now.Minute);
          Console.WriteLine(DateTime.Now.Second);

          Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın günü
          Console.WriteLine(DateTime.Now.DayOfYear); // yılın kaçıncı günündeyim.
          Console.WriteLine(DateTime.Now.ToLongDateString()); // 18 Aralık 2021 Cumartesi
          Console.WriteLine(DateTime.Now.ToShortDateString()); // 18.12.2021

          
          Console.WriteLine(DateTime.Now.ToLongTimeString()); //15:28:55
          Console.WriteLine(DateTime.Now.ToShortTimeString()); //15:28 

          Console.WriteLine(DateTime.Now.AddDays(2)); // 2gün ekle
          Console.WriteLine(DateTime.Now.AddHours(3)); // 3saat ekle
          Console.WriteLine(DateTime.Now.AddSeconds(30)); //30 saniye ekle
          Console.WriteLine(DateTime.Now.AddMonths(5)); // ay ekle
          Console.WriteLine(DateTime.Now.AddYears(3)); //yıl ekle
          Console.WriteLine(DateTime.Now.AddMilliseconds(50)); // milisaniye ekle

          //DateTime Format
          Console.WriteLine(DateTime.Now.ToString("dd")); //18
          Console.WriteLine(DateTime.Now.ToString("ddd")); // Cmt
          Console.WriteLine(DateTime.Now.ToString("dddd")); // Cumartesi

          Console.WriteLine(DateTime.Now.ToString("MM")); //12
          Console.WriteLine(DateTime.Now.ToString("MMM")); // Ara
          Console.WriteLine(DateTime.Now.ToString("MMMM")); // Ara

          Console.WriteLine(DateTime.Now.ToString("yy")); //21
          Console.WriteLine(DateTime.Now.ToString("yyy")); //2021 //gereksiz 
          Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021
            string metin="07:05:45PM";
            DateTime dateTime = DateTime.ParseExact(metin, "hh:mm:sstt", System.Globalization.CultureInfo.InvariantCulture);
            string metin2=dateTime.ToString("HH:mm:ss");
           Console.WriteLine("HackerRank saat:"+metin2);

            Console.WriteLine("*** MATH KÜTÜPHANESİ ***");
          //Math Kütüphanesi
          Console.WriteLine(Math.Abs(-25)); //25 Mutlak Değer
          Console.WriteLine(Math.Sin(10)); // Sin10 Değeri
          Console.WriteLine(Math.Cos(10));
          
          Console.WriteLine(Math.Ceiling(10.1)); //10dan büyük en küçük tam sayı 11
          Console.WriteLine(Math.Round(10.1)); // aşağı yukarı yuvarla 10
          Console.WriteLine(Math.Round(10.7)); // aşağı yukarı yuvarla 11
          Console.WriteLine(Math.Floor(10.7)); // 10

          Console.WriteLine(Math.Max(2,6));
          Console.WriteLine(Math.Min(2,6));

          Console.WriteLine(Math.Pow(3,4)); // 3^4 üzeri 4
          Console.WriteLine(Math.Sqrt(9));  //karekök alıyor 3
          Console.WriteLine(Math.Log(9)); //9un e tabanındaki logaritmik karşılığını getirir
          Console.WriteLine(Math.Exp(9)); //e üzeri 3
          Console.WriteLine(Math.Log10(10)); //10 sayısının logaritma 10 tabanındaki karşılığı

        }
    }
}
