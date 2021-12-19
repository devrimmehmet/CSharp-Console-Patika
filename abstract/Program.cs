using System;

namespace abstractornek
{
    class Program
    {
        static void Main(string[] args)
        {

              NewFocus focus1=new NewFocus();
              Console.WriteLine( focus1.HangiMarkanınAraci().ToString());
              Console.WriteLine( focus1.KacTekerlektenOlusur().ToString());
              Console.WriteLine( focus1.StandartRengiNe().ToString());

              NewCivic civic1=new NewCivic();
              Console.WriteLine( civic1.HangiMarkanınAraci().ToString());
              Console.WriteLine( civic1.KacTekerlektenOlusur().ToString());
              Console.WriteLine( civic1.StandartRengiNe().ToString());

        }
    }
}
