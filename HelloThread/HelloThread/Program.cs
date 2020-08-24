using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace HelloThread
{
    class Program
    {
        public static void Print(object st, object maxloop)
        {
            for(int i=0;i<(int)maxloop;i++)
            { Console.WriteLine(st); }
        }


        public static void Main(string[] args)
        {
            /*            Thread t1 = new Thread(() => Print("Empire", 1000));
                        Thread t2 = new Thread(()=>Print("Mamas",1000));
                        t2.Start();
                        t1.Start();*/ //the first EX
            PrintByCounter printByCounter = new PrintByCounter(); // second ex
            printByCounter.HandleThreads();
        }
    }
}
