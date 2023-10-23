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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart thread = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart thread2 = new ThreadStart(MyThreadClass.Thread2);

            Thread threadA = new Thread(thread);
            Thread threadB = new Thread(thread2);
            Thread threadC = new Thread(thread);
            Thread threadD = new Thread(thread2);

            threadA.Name = "ThreadA process:";
            threadB.Name = "ThreadB process:";
            threadC.Name = "ThreadC process:";
            threadD.Name = "ThreadD process:";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;  
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            Console.WriteLine(label1.Text.ToString());

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();    

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            label1.Text = "End of a Thread";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
