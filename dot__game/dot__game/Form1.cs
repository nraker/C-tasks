using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dot__game
{
    public partial class Form1 : Form
    {
        double sb = 0;
        int kr = 3;
        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (kr > 0)
            {
                if (xBox.TextLength >= 1 || yBox.TextLength >= 1)
                {
                    x = Convert.ToInt32(xBox.Text);
                    y = Convert.ToInt32(yBox.Text);
                }
                else
                {
                    x = 999; y = 999; // по дефолту мимо мишени
                }

                double b = 0; // баллы

                double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                double h = r / 15;
                h = Math.Ceiling(h);

                if (h > 10)
                {
                    label6.Text = ("мимо мишени, баллов 0");
                }
                else
                {
                    b = 11 - h; // количество баллов за бросок
                    label6.Text = Convert.ToString(($"попадание в зону {h}, баллов {b}"));
                    sb += b; // суммирование к общим баллам
                    label9.Text = Convert.ToString(($"{sb} баллов за все броски"));
                }
                kr--;

                label7.Text = Convert.ToString(($"Количество оставшихся бросков: {kr}"));
            }
            else if (kr <= 0)
            {
                label7.Text = ("Броски закончились");
            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool number = Char.IsDigit(e.KeyChar);  // цифры
            bool control = Char.IsControl(e.KeyChar); // backspace, enter, tab

            if (!(number || control))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool number = Char.IsDigit(e.KeyChar);  // цифры
            bool control = Char.IsControl(e.KeyChar); // backspace, enter, tab

            if (!(number || control))
                e.Handled = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bool number = Char.IsDigit(e.KeyChar);  // цифры
            
            if (!number)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             
                sb = 0;
            label6.Text = Convert.ToString(0);
            label9.Text = Convert.ToString(0);
            
            if(textBox1.TextLength >= 1)
            {
                kr = Convert.ToInt32(textBox1.Text);
                label7.Text = Convert.ToString($"Количество оставшихся бросков: {kr}");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
