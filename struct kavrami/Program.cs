using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Diktortgen diktorgen=new Diktortgen();
            diktorgen.kisaKenar=3;
            diktorgen.uzunKenar=4;
            Console.WriteLine("Class Alan Hesabı :{0}",diktorgen.AlanHesapla());

            Diktortgen_Struct diktortgen_struct;
            diktortgen_struct.kisaKenar=3;
            diktortgen_struct.uzunKenar=4;
            Console.WriteLine("Struct Alan Hesabı :{0}",diktortgen_struct.AlanHesapla());

            // uzman görüşü 16 byte kadar struct kullanın  
            // 16bytten sonrası icin class kullanın
        }
    }
    class Diktortgen
    {
        public int kisaKenar;
        public int uzunKenar;
        public Diktortgen()
        {
            kisaKenar=3;
            uzunKenar=4;
        }
        public long AlanHesapla()
        {
            return this.kisaKenar*this.uzunKenar;
        }
    }
    struct Diktortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;
       
        public long AlanHesapla()
        {
            return this.kisaKenar*this.uzunKenar;
        }
    }
}
