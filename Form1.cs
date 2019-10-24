using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Solve();
        }

        private void Solve()
        {
            var isNumeric_a = int.TryParse(textBox1.Text, out int a);
            var isNumeric_b = int.TryParse(textBox2.Text, out int b);
            var isNumeric_c = int.TryParse(textBox3.Text, out int c);

            if (isNumeric_a & isNumeric_b & isNumeric_c) 
            {                
                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

                textBoxSolution1.Text = Convert.ToString(x1);
                textBoxSolution2.Text = Convert.ToString(x2);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Solve();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }
    }
}
