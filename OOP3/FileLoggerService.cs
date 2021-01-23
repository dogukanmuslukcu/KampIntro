using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}

