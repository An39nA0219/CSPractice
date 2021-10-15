using System;
using System.Windows.Forms;

namespace CS09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            a = b;
            b = 30;
            MessageBox.Show("a=" + a); // 20
            MessageBox.Show("b=" + b); // 30
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            Other b = new Other();

            a.Value = 10;
            b.Value = 20;
            a = b;
            b.Value = 30;
            MessageBox.Show("a=" + a.Value); // 30
            MessageBox.Show("b=" + b.Value); // 30
        }

        public class Other
        {
            public int Value;
        }

        private void OtherMethod(Other other)
        {
            other.Value = 55;
        }

        private void ValueMethod(int other)
        {
            other = 55;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            a.Value = 10;
            OtherMethod(a);
            MessageBox.Show("a=" + a.Value); // 55
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 10;
            ValueMethod(a);
            MessageBox.Show("a=" + a); // 10
        }
    }
}
