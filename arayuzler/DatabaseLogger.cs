using System;

namespace arayuzler
{
    public class DatabaseLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Veritabanına log yazar.");
        }


    }
    
}