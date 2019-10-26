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
                //double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                //double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

                double x1 = (2 * c) / (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)));             
                double x2 = (2 * c) / (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)));

                if (a == 0) x1 = x2;

                textBoxSolution1.Text = Convert.ToString(x1);
                textBoxSolution2.Text = Convert.ToString(x2);

                this.Refresh();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var isNumeric_a = int.TryParse(textBox1.Text, out int a);
            var isNumeric_b = int.TryParse(textBox2.Text, out int b);
            var isNumeric_c = int.TryParse(textBox3.Text, out int c);

            int scale = 10;

            Pen pen_axis = new Pen(Color.Gray, 2);

            int y_coord1, y_coord2;

            
            Point[] axis_x =
                    {
                        new Point(0,                        ClientRectangle.Height / 2),
                        new Point(ClientRectangle.Width,    ClientRectangle.Height / 2)
                    };

            //Draw lines to screen.
            e.Graphics.DrawLines(pen_axis, axis_x);

            Point[] axis_y =
                   {
                        new Point(ClientRectangle.Width / 2, 0),
                        new Point(ClientRectangle.Width / 2, ClientRectangle.Height)
                    };

            //Draw lines to screen.
            e.Graphics.DrawLines(pen_axis, axis_y);

            Pen pen = new Pen(Color.Red, 2);

            if (isNumeric_a & isNumeric_b & isNumeric_c)
            {
                for (int x_coord = (-ClientRectangle.Width / 2); x_coord < ClientRectangle.Width / 2; x_coord++)
                {
                    y_coord1 = a * x_coord * x_coord + b * x_coord + c;
                    y_coord2 = a * (x_coord + 1) * (x_coord + 1) + b * (x_coord + 1) + c;

                    Point[] points =
                            {
                               new Point(x_coord * scale + ClientRectangle.Width/2,         -y_coord1 * scale + ClientRectangle.Height/2),
                               new Point((x_coord + 1) * scale + ClientRectangle.Width/2,   -y_coord2 * scale + ClientRectangle.Height/2)
                            };

                    //Draw lines to screen.
                    e.Graphics.DrawLines(pen, points);
                }
            }
        }

        private void Form1_PaintCurve(object sender, PaintEventArgs e)
        {
            var isNumeric_a = int.TryParse(textBox1.Text, out int a);
            var isNumeric_b = int.TryParse(textBox2.Text, out int b);
            var isNumeric_c = int.TryParse(textBox3.Text, out int c);

            int scale = 25;
            double step = 0.25;

            Pen pen_axis = new Pen(Color.LightGray, 2);

            double y_coord1, y_coord2;
            double x_coord = -1 * ClientRectangle.Width / 2;

            Point[] axis_x =
                    {
                        new Point(0,                        ClientRectangle.Height / 2),
                        new Point(ClientRectangle.Width,    ClientRectangle.Height / 2)
                    };

            for (int x = ClientRectangle.Width / 2; x> -ClientRectangle.Width / 2; x -= scale)
            {
                Point[] steps =
                   {
                        new Point(x, ClientRectangle.Height / 2 - 3),
                        new Point(x, ClientRectangle.Height / 2 + 3)
                    };
                e.Graphics.DrawLines(pen_axis, steps);
            }
            for (int x = ClientRectangle.Width / 2; x < ClientRectangle.Width; x += scale)
            {
                Point[] steps =
                   {
                        new Point(x, ClientRectangle.Height / 2 - 3),
                        new Point(x, ClientRectangle.Height / 2 + 3)
                    };
                e.Graphics.DrawLines(pen_axis, steps);
            }

            for (int y = ClientRectangle.Height / 2; y > -ClientRectangle.Height / 2; y -= scale)
            {
                Point[] steps =
                   {
                        new Point(ClientRectangle.Width / 2 - 3, y),
                        new Point(ClientRectangle.Width / 2 + 3, y)
                    };
                e.Graphics.DrawLines(pen_axis, steps);
            }
            for (int y = ClientRectangle.Height / 2; y < ClientRectangle.Height; y += scale)
            {
                Point[] steps =
                   {
                        new Point(ClientRectangle.Width / 2 - 3, y),
                        new Point(ClientRectangle.Width / 2 + 3, y)
                    };
                e.Graphics.DrawLines(pen_axis, steps);
            }


            //Draw lines to screen.
            e.Graphics.DrawLines(pen_axis, axis_x);

            Point[] axis_y =
                   {
                        new Point(ClientRectangle.Width / 2, 0),
                        new Point(ClientRectangle.Width / 2, ClientRectangle.Height)
                    };

            //Draw lines to screen.
            e.Graphics.DrawLines(pen_axis, axis_y);

            Pen pen = new Pen(Color.Red, 3);

            if (isNumeric_a & isNumeric_b & isNumeric_c)
            {
                //for (int x_coord = (-ClientRectangle.Width / 2); x_coord < ClientRectangle.Width / 2; x_coord++)
                while (x_coord < ClientRectangle.Width / 2)
                {
                    y_coord1 = a * x_coord * x_coord + b * x_coord + c;
                    y_coord2 = a * (x_coord + step) * (x_coord + step) + b * (x_coord + step) + c;

                    Point[] points =
                            {
                               new Point( Convert.ToInt32(x_coord * scale + ClientRectangle.Width/2),         Convert.ToInt32(-y_coord1 * scale + ClientRectangle.Height/2)),
                               new Point( Convert.ToInt32((x_coord + step) * scale + ClientRectangle.Width/2),   Convert.ToInt32(-y_coord2 * scale + ClientRectangle.Height/2))
                            };

                    //Draw lines to screen.
                    e.Graphics.DrawLines(pen, points);

                    x_coord += step;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Solve();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
