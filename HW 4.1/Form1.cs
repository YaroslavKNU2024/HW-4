using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4._1
{
    public partial class Form1 : Form
    {

        private Triangle A;
        public EquilateralTriangle T;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                A = new Triangle(a, b, c);
                if (a == b && b == c)
                {
                    MessageBox.Show("You've created  an equaliteral triangle. Redirecting you to another form.");
                    T = new EquilateralTriangle();
                    T.first = T.second = T.third = A.first;
                    this.Hide();
                    Form treq = new Form2(T);
                    treq.ShowDialog();
                    this.Close();
                }

            }
            catch (Exception) {
                MessageBox.Show("Не удалось создать триугольник");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (A != null)
                MessageBox.Show(A.GetPerimeter().ToString());
            else
                MessageBox.Show("Create a triangle");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> angles = A.CalculateAngles();
            foreach(string x in angles)
                MessageBox.Show(x);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            T = new EquilateralTriangle();
            MessageBox.Show(T.GetEdge().ToString());
        }

    }
}
