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
    public partial class Form2 : Form
    {
        public EquilateralTriangle _T;
        public Form2(EquilateralTriangle T)
        {
            _T = T;
            if (_T == null)
                throw new ArgumentException("Triangle was not created. Something went wrong!");
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_T.GetPerimeter().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_T.GetArea().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> vector = _T.CalculateAngles();
            foreach (string x in vector)
                MessageBox.Show(x);
        }
    }
}
