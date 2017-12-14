using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacLib;

namespace FacApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Введите целое число от 0 до 20";
            if (long.TryParse(textBox1.Text, out long n))
            {
                FacClass obj = new FacClass();
                long res = obj.FacFunc(n);
                if (n > 20 || n < 0)
                {
                    MessageBox.Show("Введите целое число от 0 до 20!", "Ошибка!");
                    return;
                }
                string s = res.ToString();
                label1.Text = s;
            }
            else
            {
                label1.Text = string.Empty;
                MessageBox.Show("Введите целое число от 0 до 20!", "Ошибка!");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
