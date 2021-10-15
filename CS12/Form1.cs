using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> values = new List<int>();
            values.Add(10);
            values.Add(20);
            values.Add(30);
            values.Add(50);
            values.Add(51);

            values.RemoveAt(3);
            values.Remove(20);

            MessageBox.Show(values[2].ToString());
            values.Clear();

            MessageBox.Show(values.Count.ToString());

        }
    }
}
