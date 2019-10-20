using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace threads
{
    public partial class Form1 : Form
    {
        Thread th;
        Thread th1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(threada);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th1 = new Thread(threadb);
            th1.Start();
        }

        public void threada()
        {
            for (int i = 0; i < 50; i ++)
            {
                Thread.Sleep(100);
            }
            MessageBox.Show("completado primeira thread");
        }

        public void threadb()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
            }
            MessageBox.Show("completado segunda thread");
        }
    }
}
