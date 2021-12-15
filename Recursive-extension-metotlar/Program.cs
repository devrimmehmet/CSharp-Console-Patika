using System;

namespace Recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Rekürsif - Öz Yinelemeli
           //3^4=3*3*3*3

           int result=1;
           for(int i=1;i<5;i++)
           {
               result=result*3;
               Console.WriteLine(result);
               Islemler instance=new();
               Console.WriteLine(instance.Expo(3,4));
           }

           //Extension Metotlar
           string ifade="Devrim Mehmet Pattabanoğlu";
           bool sonuc=ifade.CheckSpaces();
           Console.WriteLine(sonuc);
           if(sonuc)
           {
               Console.WriteLine(ifade.RemoveWhiteSpaces());
           }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            int[] dizi={9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();
            int sayi=5;
            Console.WriteLine(sayi.IsEvenNumber());
            int sayi1=4;
            Console.WriteLine(sayi1.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    public class Islemler{

        public int Expo(int sayi,int üs)
        {
            if(üs<2){
            return sayi;
            }
            return Expo(sayi,üs-1)*sayi;
        }
        //Expo(3,4)
        //Expo(3,3)*3
        //Expo(3,2)*3 *3
        //Expo(3,1)*3 *3 *3
        //3        *3 *3 *3 

    }
    public static class Extension // Static olmak zorunda extension  
    {
        public static bool CheckSpaces(this string param){ //this ifadesi eklenmeli
           return param.Contains("");
        }
        public static string RemoveWhiteSpaces(this string param){
            string[] dizi=param.Split(" "); //Stringi boşluklara göre ayır ve diziye al
            return string.Join("*",dizi);
        }
        public static string MakeUpperCase(this string param){ //this ifadesi eklenmeli
           return param.ToUpper();
        }
        public static string MakeLowerCase(this string param){ //this ifadesi eklenmeli
           return param.ToLower();
        }
        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param){
            foreach(int item in param){
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param){
            return param%2==0;
        }
        public static string GetFirstCharacter(this string param){
            return param.Substring(0,1);
        }
    }
}
