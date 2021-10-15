using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter counter = new Counter(10);
            //var counter = new Counter(100);

            counter.Call();
            counter.Call();
            counter.Call();
            counter.Call();
            counter.Call();
            counter.Call();
            button1.Text = counter.GetCount().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var counter = new Counter(100);

            counter.Call();
            button2.Text = counter.GetCount().ToString();

            var counter2 = new Counter(100);
            counter2.Call();
            counter2.Call();
            counter2.Call();
            counter2.Call();
            this.Text = counter2.GetCount().ToString();
            //thisは、このプロジェクトのウインドウのタイトル
        }
    }
}
