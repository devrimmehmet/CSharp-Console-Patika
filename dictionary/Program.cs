using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int,string> kullanıcılar=new Dictionary<int, string>();
            //keyler uniq olmazsa patlar dikkat etmen lazım bir elemana bir key
            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12,"Devrim Mehmet Pattabanoğlu");
            kullanıcılar.Add(18,"Hüseyin Kazım Pattabanoğlu");
            kullanıcılar.Add(20,"Zoa Moa");

            //Dizinin elemanlarına erişim
            Console.WriteLine("***** Dizi Elemanlarına Erişim *****");
            Console.WriteLine(kullanıcılar[12]); //12.keye sahip elemanı getir
          
            Console.WriteLine("***** Dizinin Bütün Elemanlarına Erişim *****");
            foreach(var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
            //Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanıcılar.Count);
            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Devrim Mehmet Pattabanoğlu")); //true atar böyle bir valueye sahip eleman var
            //Remove
            Console.WriteLine("***** Remove *****");
            kullanıcılar.Remove(10);
             foreach(var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
            //Keys
            Console.WriteLine("***** Keys *****");
            foreach(var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("***** Values *****");
            foreach(var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }
      }
    }
}
