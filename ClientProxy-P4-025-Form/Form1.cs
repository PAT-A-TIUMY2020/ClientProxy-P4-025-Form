using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_025_Form
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
        ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox14.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            c = a - b;
            textBox15.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox5.Text);
            b = Convert.ToInt32(textBox6.Text);
            c = a * b;
            textBox16.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox7.Text);
            b = Convert.ToInt32(textBox8.Text);
            c = a / b;
            textBox17.Text = c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                a.X = Int32.Parse(textBox9.Text);
                a.Y = Int32.Parse(textBox11.Text);
                b.X = Int32.Parse(textBox10.Text);
                b.Y = Int32.Parse(textBox12.Text);
           
                double XKoordinat = a.X - b.X;
                double YKoordinat = a.Y - b.Y;
                double HasilKoordinat = Math.Sqrt(Math.Pow(XKoordinat, 2) +
                Math.Pow(YKoordinat, 2));

                textBox13.Text = HasilKoordinat.ToString();

            }
            catch { }
        }
    }
}
