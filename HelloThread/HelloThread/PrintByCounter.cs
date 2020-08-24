using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloThread
{
    public class PrintByCounter
    {
        private int Counter { get; set; }
        private int CounterMamas { get; set; }
        private int CounterEmpire { get; set; }
        private object _lock;
        public PrintByCounter()
        {
            Counter = 0;
            CounterMamas = 0;
            CounterEmpire = 0;
            _lock = new object();
        }
        public void HandleThreads()
        {
            Thread EmpireThread = new Thread(Print1);
            Thread MamasThread = new Thread(Print2);
            EmpireThread.Start("Mamas");
            MamasThread.Start("Empire");
            EmpireThread.Join();
            MamasThread.Join();
            Console.WriteLine("This is " + CounterEmpire);
            Console.WriteLine("This is " + CounterMamas);


        }
        public void Print1(object st)
        {

            for (int i = 0; i < 100; i = Counter)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(st);
                    ++CounterMamas;
                    Counter++;
                }
            }
        }
        public void Print2(object st)
        {
            for (int i = 0; i < 100; i = Counter)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(st);
                    ++CounterEmpire;
                    Counter++;

                }
                
            }
        }
    }
}
