using Oefening3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Oefening3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox3.Text != "")
            {
                double euro1 = double.Parse(textBox3.Text) * 1.02;
                textBox1.Text = euro1.ToString();
            }

            if (textBox2.Text != "")
            {
                double frank1 = double.Parse(textBox6.Text) * 0.99;
                textBox1.Text = frank1.ToString();


            }

            if (textBox2.Text != "")
            {
                double pounds1 = double.Parse(textBox2.Text) * 0.88;
                textBox1.Text = pounds1.ToString();
            }


            if (textBox5.Text != "")
            {
                double rupees1 = double.Parse(textBox5.Text) * 81.50;
                textBox1.Text = rupees1.ToString();
            }


            if (textBox4.Text != "")
            {
                double yen1 = double.Parse(textBox4.Text) * 144.50;
                textBox1.Text = yen1.ToString();

            }


            if (textBox1.Text != "")
            {

                USD dollar = new USD(double.Parse(textBox1.Text));
                USD euro = new Euro(double.Parse(textBox1.Text));
                USD pounds = new Pounds(double.Parse(textBox1.Text));
                USD yen = new Yen(double.Parse(textBox1.Text));
                USD franken = new Franken(double.Parse(textBox1.Text));
                USD rupees = new Rupees(double.Parse(textBox1.Text));

                textBox1.Text = dollar.ToString();
                textBox3.Text = euro.ToString();
                textBox6.Text = franken.ToString();
                textBox2.Text = pounds.ToString();
                textBox4.Text = yen.ToString();
                textBox5.Text = rupees.ToString();

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}