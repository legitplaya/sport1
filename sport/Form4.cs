using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sport.Program.Data;

namespace sport
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "Шахматы")
            {
                MessageBox.Show("Правильно!"); count++;
                Form5 f = new Form5();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильно!");
                Form5 f = new Form5();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
