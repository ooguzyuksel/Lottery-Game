using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int s1, s2, s3, s4, s5, s6;

            s1 = rnd.Next(1, 7);
            s2 = rnd.Next(1, 7);
            s3 = rnd.Next(1, 7);
            s4 = rnd.Next(1, 7);
            s5 = rnd.Next(1, 7);
            s6 = rnd.Next(1, 7);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            label5.Text = s5.ToString();
            label6.Text = s6.ToString();

            if(s1.ToString() == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (s2.ToString() == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (s3.ToString() == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (s4.ToString() == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if (s5.ToString() == textBox5.Text)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }

            if (s6.ToString() == textBox6.Text)
            {
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;


            textBox1.Focus();

        }
    }
}
