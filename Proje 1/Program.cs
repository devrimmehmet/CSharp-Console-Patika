using System;
using System.Collections.Generic;

namespace Proje_1
{
    class Program
    {
        public static void Main(string[] args)
        {
        List<numara> Rehber = new List<numara>(); 
        Rehber.Add(new numara("Devrim Mehmet","Pattabanoğlu", 9999999999));
        Rehber.Add(new numara("Hüseyin Kazım","Pattabanoğlu", 8888888888));
        Rehber.Add(new numara("Mehmet Alper","Sezer", 7777777777));
        Rehber.Add(new numara("Burak","Koca", 6666666666));
        Rehber.Add(new numara("Mehmet","Arslan", 5555555555));
        Inumara.arayuz();
        }
    }
}
