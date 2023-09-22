using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sport.Program;

namespace sport
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.count < 3)
            {
                MessageBox.Show("Ваша оценка 2");
            }
            if (Data.count == 4)
            {
                MessageBox.Show("Ваша оценка 4");
            }
            if (Data.count == 5)
            {
                MessageBox.Show("Ваша оценка 5");
            }
        }
    }
}
