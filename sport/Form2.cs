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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\jenya\\Desktop\\sport\\sport\\Resources\\ronaldo.jpg");
        }
        

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (radioButton2.Checked)
            {
                MessageBox.Show("Правильно, Криштиану Роналду!");
                count++;
                Form3 f = new Form3();
                this.Hide();
                f.ShowDialog();
               
            }
            if (radioButton1.Checked|radioButton3.Checked| radioButton4.Checked)
            {
                MessageBox.Show("НЕПРАВИЛЬНО!!!");
                Form3 f = new Form3();
                this.Hide();
                f.ShowDialog();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
