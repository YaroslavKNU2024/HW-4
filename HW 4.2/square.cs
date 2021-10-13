using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4._2
{
    public partial class square : Form
    {
        public square()
        {
            InitializeComponent();
        }
        Square s;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.Perimeter().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double side = Convert.ToDouble(textBox1.Text);
                if (side <= 0) 
                    throw new ArgumentException();
                s = new Square(side);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't create a rectangle!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s != null)
                MessageBox.Show(s.Area().ToString());
            else
                MessageBox.Show("Create a square!");
        }
    }
}
