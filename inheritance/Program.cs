using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım - Miras Alma - Miras Verme
            //                       Canlılar
            //                          |
            //        Bitkiler                        Hayvanlar
            //    |             |                |                 |
            // Tohumlu      Tohumsuz        Surungenler         Kuslar

            TohumluBitkiler tohumlubitki=new TohumluBitkiler();
           
           
            tohumlubitki.TohumlaCogalma();

            Console.WriteLine("***********************");
            Kuslar martı=new Kuslar();
           
            
            martı.Ucmak();
        }
    }
}
