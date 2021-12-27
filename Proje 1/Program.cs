using System;

namespace Proje_1
{
    
    class Program
    {
    public static bool rehber=true;
    public static int islem=0;    
        static void  Main(string[] args)
        {
            while(rehber==true)
            {
           Console.Clear();
           Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :"); 
           Console.WriteLine("*******************************************");
           Console.WriteLine("(1) Telefon Numarası Kaydetmek"); 
           Console.WriteLine("(2) Telefon Numarası Sil");
           Console.WriteLine("(3) Telefon Numarası Güncelle");
           Console.WriteLine("(4) Rehberi Listeleme (A-Z, Z-A seçimli)");
           Console.WriteLine("(5) Rehberde Arama");
           Console.WriteLine("(6) Programı Kapat");  
           
          try
          {
                islem =Convert.ToInt32(Console.ReadLine());
          }
          catch (Exception)
          {
             Hata();
              
          }
            
                if(islem<7 && islem>0)
                {
                    switch(islem)
                    {
                        case 1:{
                                Console.Clear(); 
                                Islem.NumaraEkle();
                                 break;
                                }
                        case 2:{
                                Console.Clear();  
                                Islem.NumaraSil();
                                 break;
                                }
                        case 3:{
                                Console.Clear();  
                                Islem.NumaraDegistir();
                                 break;
                                }                
                        case 4:{
                                Console.Clear();  
                                Islem.NumaraListele();
                                 break;
                                }
                        case 5:{
                                Console.Clear();  
                                Islem.NumaraArama();
                                 break;
                                }
                        case 6:{
                               Kapat();
                                 break;
                                }
                                         
                    }
               }else{
                  
                    }
               
           }
        
        }

        public static void Hata()
        {   Console.Clear();
            Console.WriteLine("********** HATA! **********");
            Console.WriteLine("Lütfen sadece 1-6 arasında sayı girişi yapınız!");
            Console.WriteLine("********** HATA! **********");
            Console.ReadKey();
        }

         public static void Kapat()
        {
            DMP1:
            Console.Clear();
            Console.WriteLine("Ana Menüye Dönmek için (E) \nProgramı Kapatmak için (H)"); 
        
              string cevap=Console.ReadLine();
            if(cevap=="E" || cevap=="e")
            {
            rehber=true;
            } 
            if(cevap=="H" || cevap=="h")
            {
            rehber=false;
            }
            if(cevap!="E"&&cevap!="e"&&cevap!="h"&&cevap!="H")
            {
                Console.Clear();
                Console.WriteLine("Evet Yada Hayır (E/H)");
                Console.ReadKey();
                
                goto DMP1;
            }
        
        }
       
    }
}
