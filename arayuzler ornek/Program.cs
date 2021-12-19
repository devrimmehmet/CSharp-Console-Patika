using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus=new Focus();
            Console.WriteLine( focus.HangiMarkanınAraci().ToString());
            Console.WriteLine( focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine( focus.StandartRengiNe().ToString());

            Civic civic=new Civic();
            Console.WriteLine( civic.HangiMarkanınAraci().ToString());
            Console.WriteLine( civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine( civic.StandartRengiNe().ToString());

           
        }
    }
}
