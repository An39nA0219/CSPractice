using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            //if (value == 10)
            //{
            //    MessageBox.Show("10です");
            //} 
            //else if (value == 20)
            //{
            //    MessageBox.Show("20です");
            //}
            //else if (value == 21)
            //{
            //    MessageBox.Show("21です");
            //}
            //else
            //{
            //    MessageBox.Show("どれでもなかった");
            //}

            switch (value)
            {
                case 10:
                    MessageBox.Show("10です");
                    break;
                case 20:
                    MessageBox.Show("20です");
                    break;
                case 30:
                    MessageBox.Show("30です");
                    break;
                default:
                    MessageBox.Show("どれでもなかった");
                    break ;

            }
        }
    }
}
