using System;
using System.Collections.Generic;

namespace Proje_1
{
    class numara
    {
        
        public string isim;
        public string soyisim;
        public long tel;

        public numara(string isim, string soyisim, long tel)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.tel = tel;
        }
        public static void numaraKaydet()
        {
            List<numara> Rehber = new List<numara>();
            Console.Write(" Ad: "); string isim = Console.ReadLine();
            Console.Write(" Soyad: "); string soyisim = Console.ReadLine();
            Console.Write(" Telefon: "); long tel = Convert.ToInt64(Console.ReadLine());
            numara yeniNumara = new numara(isim,soyisim,tel);               
            Rehber.Add(yeniNumara);                
            Console.WriteLine("Kayıt işlemi gerçekleştirildi.");                
            Inumara.ProgramKapat();
 
        }
        public static void numaraSil()
        {
            Console.WriteLine("Numara Siliyorum.");
            Inumara.ProgramKapat();
        }
        public static void numaraGuncelle()
        {
            Console.WriteLine("Numara Guncelliyorum.");
            Inumara.ProgramKapat();
        }
        public static void rehberdeArama()
        {   
            Console.WriteLine("rehberde arıyorum.");
            Inumara.ProgramKapat();
        }     
        public static void rehberListeleme()
        {
            Console.WriteLine("rehber listeliyorum.");
            Inumara.ProgramKapat();
        }
       
    }

}