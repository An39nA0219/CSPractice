using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS06
{
    public partial class Form1 : Form
    {
        private int _value = 0;

        public Form1()
        {
            InitializeComponent();
            _value = 0;
        }

        private int GetValue()
        {
            int valueM = 111;
            _value = 2;
            return 1;
        }

        private void SetValue()
        {
            MessageBox.Show("AAA");
        }
    }

}
