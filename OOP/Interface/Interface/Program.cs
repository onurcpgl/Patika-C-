using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.writeLog();

            SmsLogger sms = new();
            sms.writeLog();
            //1.Yöntem.
            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();
            //2.Yöntem.
            //LogManagera gönderip hepsini ordan çekebilirz tek tek uğraşmak yerine.
            LogManager log = new LogManager(new FileLogger());
            log.writeLog();
        }
    }
}
