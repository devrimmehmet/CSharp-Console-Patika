using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int değer=2;
            string degisken=null;
            string Degisken=null;
            byte b=5;           //1 byte 
            sbyte c=-5;         //1 byte
            short d=11;         //2 byte
            ushort e=12;        //2 byte
            Int16 i16=2;        //2 byte
            int i =2 ;          //4 byte yer kaplar
            Int32 i32=2;        //4 byte yer kaplar
            Int64 i64=9;        //8 byte yer kaplar
            uint ui=2;          //4 byte yer kaplar
            long l=4;           //8 byte yer 
            ulong ul=5;         //8 byte 
            float f=5;          //4 byte    /reel sayılar
            double doub=5;      //8 byte    /reel sayılar
            decimal dec=10;     //16 byte   /reel sayılar
            char tek='2';       //2 byte
            string str="DevrimMehmet"; // sınırsız
            bool bl=true;       //
            bool b2=false;      //
            DateTime dt=DateTime.Now;
            Console.WriteLine("Tarih Saat Şu an :"+dt);

            object o1="x";
            object o2='y';
            object o3=4;
            object o4=4.3;

            //string ifadeler
            string str1= string.Empty;
            str1="Devrim Mehmet Pattabanoğlu";
            string ad="Devrim Mehmet";
            string soyad="Pattabanoğlu";
            string tamisim=ad+" "+soyad;

            //integer tanımlama şekilleri
            int integer1=5;
            int integer2=3;
            int integer3=integer1+integer2;
            
            //boolean

            bool bool1=10<2;
            
            
            //degisken dönüşümleri
            string str20="20";
            int int20=20;
            
            string yenideger=str20+int20.ToString();
            Console.WriteLine(yenideger);
           
            int int21=int20+Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22=int20+int.Parse(str20); // çıktısı 40

            //date time
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime + " " + hour);




            //Console.WriteLine(değer);


           // int degisken5=5;
           // string degisken5="Merhaba";
          // short degisken55=32,767;
            // Console.WriteLine(degisken55);

        }
    }
}
