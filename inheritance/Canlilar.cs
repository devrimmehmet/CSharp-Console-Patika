using System;

namespace inheritance
{
   public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum yapar.");
        }
        public void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım yapar.");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }

}
