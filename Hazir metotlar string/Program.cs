using System;

namespace Hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2="Dersimiz Csharp";

            //length
            Console.WriteLine(degisken.Length);
            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            //Concat birleştirme
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));
            
            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0 , 1, -1
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken2.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Dersimiz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine("*** INDEXOF ***");
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Cs"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));
            //LastIndexOf aradığımız stringi en sondakini verir.
            Console.WriteLine(degisken.LastIndexOf("i"));

            //PadLieft, PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30)); // degisken2  harflerin toplamı ve boşluk toplam 30 karakter oluyor 30 boşluk eklemiyor dikkat
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*')); //boşluk yerine * koysun
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); // 10.karakterden sonrasını sil
            Console.WriteLine(degisken.Remove(5,3)); //hafızadan silmiyor DİKKAT.
            Console.WriteLine(degisken.Remove(0,1));  //0.karakterden itibaren 1 tane sil

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]); // boşluklara göre parçala ve oluşan dizide 1.indexi getir

            //Substring
            Console.WriteLine(degisken.Substring(4)); // 4.indexten başla sonuna kadar getir
            Console.WriteLine(degisken.Substring(4,6)); // 4.indexten başla 6 karakter getir
        }
    }
}
