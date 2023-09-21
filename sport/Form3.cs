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
    public partial class Form3 : Form
    {
        
        
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox4.Checked)
            {
                MessageBox.Show("Правильно!"); count++;
                Form4 f = new Form4();
                this.Hide();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("WRONG!!!!");
                Form4 f = new Form4();
                this.Hide();
                f.ShowDialog();
            }
            
        }
    }
}
