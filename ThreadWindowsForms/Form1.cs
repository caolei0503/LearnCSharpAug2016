using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadWindowsForms
{
    /// <summary>
    /// http://www.codeproject.com/Articles/18702/Threading-in-NET-and-WinForms
    /// </summary>
    public partial class Form1 : Form
    {
        public delegate void MyDelegate();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 1000; i++)
                textBox1.Text += "Main " + i.ToString();
            Thread t = new Thread(new ThreadStart(RunInThread));
            t.Start();

           
        }

        void RunInThread()
        {
            MyDelegate delInstatnce = new MyDelegate(AddControl);
            this.Invoke(delInstatnce);
        }

        void AddControl()
        {
            for (int i = 0; i < 1000; i++)
                textBox1.Text += "Thread " + i.ToString();
        }
    }
}
