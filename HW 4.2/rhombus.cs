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
    public partial class rhombus : Form
    {
        public rhombus()
        {
            InitializeComponent();
        }
        Rhombus rmb;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double side = Convert.ToDouble(textBox1.Text);
                double SmallDiagonal = Convert.ToDouble(textBox2.Text);
                double BigDiagonal = Convert.ToDouble(textBox3.Text);

                rmb = new Rhombus(side, SmallDiagonal, BigDiagonal);
            }
            catch (Exception ex)
            { MessageBox.Show("Can't create a rhombus"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rmb != null)
                MessageBox.Show(rmb.Perimeter().ToString());
            else
                MessageBox.Show("Can't create a rhombus");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rmb != null)
                MessageBox.Show(rmb.Area().ToString());
            else
                MessageBox.Show("Can't create a rhombus");
        }
    }
}
