using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    /// <summary>
    /// msdn
    /// https://msdn.microsoft.com/en-us/library/mt679037.aspx
    /// </summary>
    class ThreadingSynchronize
    {
        static ManualResetEvent autoEvent;

        static void DoWork()
        {
            Console.WriteLine("   worker thread started, now waiting on event...");
            autoEvent.WaitOne();
            Console.WriteLine("   worker thread reactivated, now exiting...");
        }

        public static void MainExecute()
        {
            autoEvent = new ManualResetEvent(false);

            Console.WriteLine("main thread starting worker thread...");
            Thread t = new Thread(DoWork);
            t.Start();

            Console.WriteLine("main thread sleeping for 1 second...");
            Thread.Sleep(200);

            Console.WriteLine("main thread signaling worker thread...");
            autoEvent.Set();
        }
    }
}
