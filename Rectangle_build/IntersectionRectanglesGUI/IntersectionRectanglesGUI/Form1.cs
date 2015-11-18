using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntersectionRectangles;

namespace IntersectionRectanglesGUI
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int R1X1 = Convert.ToInt32(rect1x1.Text);
            int R1Y1 = Convert.ToInt32(rect1y1.Text);
            int R1X2 = Convert.ToInt32(rect1x2.Text);
            int R1Y2 = Convert.ToInt32(rect1y2.Text);
            int R2X1 = Convert.ToInt32(rect2x1.Text);
            int R2Y1 = Convert.ToInt32(rect2y1.Text);
            int R2X2 = Convert.ToInt32(rect2x2.Text);
            int R2Y2 = Convert.ToInt32(rect2y2.Text);

            if (R1X2 < R1X1 || R1Y2 < R1Y1 || R2X2 < R2X1 || R2Y2 < R2Y1)
            {
                MessageBox.Show("Некорректный ввод", "Result");
            }
            else
            {

                graphics.DrawRectangle(new Pen(Color.Coral), R1X1, R1Y2, R1X2 - R1X1, R1Y2 - R1Y1);
                graphics.DrawRectangle(new Pen(Color.DarkMagenta), R2X1, R2Y2, R2X2 - R2X1, R2Y2 - R2Y1);

                ObjRectangle rect1 = new ObjRectangle(R1X1, R1Y1, R1X2, R1Y2);
                ObjRectangle rect2 = new ObjRectangle(R2X1, R2Y1, R2X2, R2Y2);
                WorkWithRectangles r = new WorkWithRectangles(rect1, rect2);
                if (r.isIntersection())
                {
                    MessageBox.Show("Прямоугольники пересекаются.", "Result");
                }
                else
                {
                    MessageBox.Show("Прямоугольники не пересекаются.", "Result");
                }
            }
         }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            rect1x1.Text = "";
            rect1x2.Text = "";
            rect1y1.Text = "";
            rect1y2.Text = "";
            rect2x1.Text = "";
            rect2x2.Text = "";
            rect2y1.Text = "";
            rect2y2.Text = "";
            graphics.Clear(Color.AliceBlue);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
