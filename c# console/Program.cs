using System;

namespace c__console
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hoş Geldiniz!");
            Console.WriteLine("Adınızı Giriniz :");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz :");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba "+name+" "+surname);
           
           
        }
    }
}
