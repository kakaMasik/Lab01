using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Початок роботи";
            BackColor = Color.LightGreen;
            label8.Visible= false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = textBox3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = textBox4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = textBox4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = textBox4.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.BackColor= Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.Blue;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label3.BackColor= Color.White; label4.BackColor = Color.White; label5.BackColor = Color.White;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
        }
    }
}
