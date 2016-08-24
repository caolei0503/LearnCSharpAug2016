using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class AreaClass2
    {
        public double Base;
        public double Height;
        public double CalcArea()
        {
            // Calculate the area of a triangle.
            return 0.5 * Base * Height;
        }
    }
    
    class BackgroundWorker0
    {
        private System.ComponentModel.BackgroundWorker BackgroundWorker1
        = new System.ComponentModel.BackgroundWorker();

        public void TestArea2()
        {
            InitializeBackgroundWorker();

            AreaClass2 AreaObject2 = new AreaClass2();
            AreaObject2.Base = 30;
            AreaObject2.Height = 40;

            // Start the asynchronous operation.
            BackgroundWorker1.RunWorkerAsync(AreaObject2);
        }

        private void InitializeBackgroundWorker()
        {
            // Attach event handlers to the BackgroundWorker object.
            BackgroundWorker1.DoWork +=
                new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted +=
                new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
        }

        private void BackgroundWorker1_DoWork(
            object sender,
            System.ComponentModel.DoWorkEventArgs e)
        {
            AreaClass2 AreaObject2 = (AreaClass2)e.Argument;
            // Return the value through the Result property.
            e.Result = AreaObject2.CalcArea();
        }

        private void BackgroundWorker1_RunWorkerCompleted(
            object sender,
            System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // Access the result through the Result property.
            double Area = (double)e.Result;
            Console.WriteLine("The area is: " + Area.ToString());
        }
    }
}
