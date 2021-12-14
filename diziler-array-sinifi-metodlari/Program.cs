using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] SayiDizisi={23,12,4,86,72,3,11,17};
            Console.WriteLine("*** Sırasız Dizi ***");
            foreach(var sayi in SayiDizisi)            
            Console.WriteLine(sayi);
            
            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(SayiDizisi);
            foreach(var sayi in SayiDizisi)            
            Console.WriteLine(sayi);
            
            //Clear
            Console.WriteLine("**** Array Clear ****");
            //SayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elamanı 0'lar.
            Array.Clear(SayiDizisi,1,2); // 1.indexten başlayarak 2 tane elemana 0 indexi atadı            
            foreach(var sayi in SayiDizisi)            
            Console.WriteLine(sayi);
            //Reverse
            Console.WriteLine("**** Array Reverse ****");
            Array.Reverse(SayiDizisi);
            foreach(var sayi in SayiDizisi)            
            Console.WriteLine(sayi);
            //IndexOf
            Console.WriteLine("**** Array IndexOf ****");            
            Console.WriteLine(Array.IndexOf(SayiDizisi,23)); //verdiğimiz değerin dizideki index numarasını veriyor 
            //Resize
            Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref SayiDizisi,9); // sayı dizisi boyutunu 9 yap 8 elemanlıydı 9 elemanlı oldu
            SayiDizisi[8]=99;
            foreach(var sayi in SayiDizisi)            
            Console.WriteLine(sayi);

        }
    }
}
