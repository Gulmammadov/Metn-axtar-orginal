using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171012Win_MetnAxtarOrginal
{
    public partial class Form1 : Form
    {
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            index = textBox1.Text.IndexOf(textBox2.Text);
            if (index < 0)
            {
                MessageBox.Show("Tapilmadi");
            }
            else
            {
                textBox1.SelectionStart = index;
                textBox1.SelectionLength = textBox2.Text.Length;
                label1.Text = "Sözün başlama indexi: " + index.ToString();
            }
            //MessageBox.Show(index.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.HideSelection = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = textBox1.Text.IndexOf(textBox2.Text,index+1);
            if (index < 0)
            {
                MessageBox.Show("Tapilmadi");
            }
            else
            {
                textBox1.SelectionStart = index;
                textBox1.SelectionLength = textBox2.Text.Length;
                label1.Text = "Sözün başlama indexi: " + index.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
