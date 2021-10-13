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
    public partial class triangle : Form
    {
        public triangle()
        {
            InitializeComponent();
        }
        private Triangle T;
        private bool checker(double first_side, double second_side, double third_side)
        {
            if (first_side <= 0 || second_side <= 0 || third_side <= 0 ||
                first_side + second_side <= third_side || second_side + third_side <= first_side || first_side + third_side <= second_side)
            {
                MessageBox.Show("Impossible to create a triangle!");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (T != null)
            {
                if (!checker(T.first, T.second, T.third)) return;
                MessageBox.Show(T.Perimeter().ToString());
            }
            else
                MessageBox.Show("Create a triangle!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (T != null)
            {
                if (!checker(T.first, T.second, T.third)) return;
                MessageBox.Show(T.Area().ToString());
            } else
                MessageBox.Show("Create a triangle");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double first, second, third;
            try
            {
                first = Convert.ToDouble(a.Text);
                second = Convert.ToDouble(b.Text);
                third = Convert.ToDouble(c.Text);
            } catch(Exception ex)
            {
                MessageBox.Show("Impossible to create!");
                return;
            }
            T = new Triangle(first, second, third);
        }



        private void triangle_Load(object sender, EventArgs e)
        {

        }
    }
}
