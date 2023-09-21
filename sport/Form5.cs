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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Усэйн Болт")
            {
                MessageBox.Show("Правильно!"); count++;
                Form6 f = new Form6();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильно!");
                Form6 f = new Form6();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
