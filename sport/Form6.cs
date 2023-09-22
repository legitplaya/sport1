using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sport.Program.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sport
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 3)

            {
                MessageBox.Show("Правильно!"); count++;
                Form7 f = new Form7();
                this.Hide();
                f.ShowDialog();
            }   
            else
            {
                MessageBox.Show("НЕПравильно!!!");
                Form7 f = new Form7();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
