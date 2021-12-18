using System;
using System.Collections;
using System.Collections.Generic;
namespace arrayList
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //System.Collections namepace

            ArrayList liste=new ArrayList();
         //   liste.Add("Ayşe");
         //   liste.Add(2);
         //   liste.Add(true);
         //   liste.Add('A');
         //   //içerisindeki verilere erişme
         //   Console.WriteLine(liste[1]);
         //   foreach(var eleman in liste)
         //   {
         //       Console.WriteLine(eleman);
         //   }
//
         //   //AddRange
            Console.WriteLine("**** Add Range ****");
         //   string[] renkler={"Kırmızı","Sarı","Yeşil"};
            List<int> sayılar=new List<int>(){1,8,3,7,9,92,5};
         //   liste.AddRange(renkler);
            liste.AddRange(sayılar);
            foreach(var elmn in liste)
            {
                Console.WriteLine(elmn);
            }

            //Sort
            Console.WriteLine("**** Sort *******");
            liste.Sort();
            foreach(var elmn in liste)
            {
                Console.WriteLine(elmn);
            }
        
            //Binary Search
            Console.WriteLine("** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(9));

            // Reverse 
            Console.WriteLine("** Reverse ****");
            liste.Reverse();
            foreach(var elmn in liste)
            {
                Console.WriteLine(elmn);
            }
            //Clear 
            Console.WriteLine("**** Clear ****");
            liste.Clear();
            foreach(var elmn in liste)
            {
                Console.WriteLine(elmn);
            }
    
        }
    }
}
