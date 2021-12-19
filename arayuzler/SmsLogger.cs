using System;

namespace arayuzler
{
    public class SmsLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms olarak log yazar.");
        }


    }
    
}