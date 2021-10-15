using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> items = new List<int>();
            items.Add(10);
            items.Add(20);
            items.Add(30);
            items.Add(40);

            foreach(int item in items)
            {
                if(item == 30)
                {
                    break;
                }
                if(item == 20)
                {
                    continue;
                }
                MessageBox.Show(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> items = new List<int>();
            items.Add(10);
            items.Add(20);
            items.Add(30);
            items.Add(40);

            //foreach (int item in items)
            //{
            //    //items[1] = 22; 回ってる途中で値を変えるとエラーになる
            //    //items.RemoveAt(1); これもダメ
                
            //    MessageBox.Show(item.ToString());
            //}

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == 10)
                {
                    items.RemoveAt(i);
                }
            }
        }
    }
}
