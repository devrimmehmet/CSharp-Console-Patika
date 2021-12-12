using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama
            int x=3;
            int y=3;
            y=y+2;
            Console.WriteLine(y);
            y+=3; // işlemli atama
            Console.WriteLine(y);
            y/=2; 
            Console.WriteLine(y);
            x*=2; 
            Console.WriteLine(x);
            
            //Mantıksal Operatörler
            // || && !
            bool isSuccess=true;
            bool isCompleted=false;
            if(isSuccess && isCompleted)
            Console.WriteLine("Ferfect!");
            if(isSuccess || isCompleted)
            Console.WriteLine("Great!");
            if(isSuccess && !isCompleted)
            Console.WriteLine("Fine!");


            //İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a=3;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(" Sonular burdan başlıyor \n"+sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);

            //İlişkisel Operatörler
            // /, *, +, -


            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+1;
            Console.WriteLine(sonuc1);

            // % : mod alır (bölümünden kalan)
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
