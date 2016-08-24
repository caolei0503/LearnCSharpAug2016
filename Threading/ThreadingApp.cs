using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BackgroundWorker0 background = new BackgroundWorker0();
            //background.TestArea2();

            //ThreadingSynchronize.MainExecute();

            //ThreadTimer timer = new ThreadTimer();
            //timer.RunTimer();

            ThreadPoolExample.MainExecute();
            Console.WriteLine("ok");
        }
    }
}
