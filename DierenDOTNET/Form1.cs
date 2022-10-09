using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Dieren;
using DierenDOTNET;

namespace DierenDOTNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dier koe = new Koe(1000);
            Dier varken = new Varken(250);
            Dier slang = new Slang(5);

            if (checkBox1.Checked)
            {
                MessageBox.Show(koe.ToString());

            }
            if (checkBox3.Checked)
            {
                MessageBox.Show(slang.ToString());
            }

            if (checkBox2.Checked)
            {
                MessageBox.Show(varken.ToString());
            }
        }
    }
}
