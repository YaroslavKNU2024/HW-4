using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4._3
{
    public partial class ISForm : Form
    {
        public ISForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        IsoscelesTriangle IST;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double alpha = Convert.ToDouble(textBox3.Text);

                IST = new IsoscelesTriangle(a, b, alpha);
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible to create a triangle");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IST == null)
            {
                MessageBox.Show("You haven't created a triangle yet!");
                return;
            }
            MessageBox.Show(IST.Perimeter().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IST == null)
            {
                MessageBox.Show("You haven't created a triangle yet!");
                return;
            }
            MessageBox.Show(IST.Area().ToString());
        }
    }
}
