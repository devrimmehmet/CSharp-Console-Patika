using System;
using System.Collections.Generic;

namespace Proje_1
{
    class Inumara
    {
        public static void arayuz()
        {
           List<numara> Rehber = new List<numara>(); 
           
           Console.Clear(); 
           Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :"); 
           Console.WriteLine("*******************************************");
           DMP:
           Console.WriteLine("(1) Yeni Numara Kaydetmek"); 
           Console.WriteLine("(2) Varolan Numarayı Silmek");
           Console.WriteLine("(3) Varolan Numarayı Güncelleme");
           Console.WriteLine("(4) Rehberi Listelemek");
           Console.WriteLine("(5) Rehberde Arama Yapmak");
           Console.WriteLine("(6) Programı Kapat");  
           
           try
           {
               int islem =Convert.ToInt32(Console.ReadLine());
               if(islem<7 && islem>0){
                    switch(islem)
                    {
                        case 1:{
                                Console.Clear(); 
                                numara.numaraKaydet();
                                 break;
                                }
                        case 2:{
                                Console.Clear();  
                                numara.numaraSil();
                                 break;
                                }
                        case 3:{
                                Console.Clear();  
                                numara.numaraGuncelle();
                                 break;
                                }                
                        case 4:{
                                Console.Clear();  
                                numara.rehberListeleme();
                                 break;
                                }
                        case 5:{
                                Console.Clear();  
                                numara.rehberdeArama();
                                 break;
                                }
                        case 6:{
                                Inumara.ProgramKapat();
                                 break;
                                }                
                    }
               }else{
                   Hata();
                    goto DMP;
               }
               
           }
           catch (Exception)
           {
               
               Hata();
               goto DMP;
           }
        }
        public static void Hata()
        {   Console.Clear();
            Console.WriteLine("********** HATA! **********");
            Console.WriteLine("Lütfen sadece 1-6 arasında sayı girişi yapınız!");
            Console.WriteLine("********** HATA! **********");
        }
         public static void ProgramKapat()
        {
            DMP1:
            Console.WriteLine("Ana Menüye Dönmek için (E) \nProgramı Kapatmak için (H)"); 
        
              string cevap=Console.ReadLine();
            if(cevap=="E" || cevap=="e")
            {
                Inumara.arayuz();
            } else if(cevap=="H" || cevap=="h")
            {
                
            }
            else{
                Console.WriteLine("Evet Yada Hayır (E/H)");
                goto DMP1;
            }
        
        }  
    }
}
