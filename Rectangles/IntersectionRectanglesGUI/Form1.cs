using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace IntersectionRectanglesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start();   
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

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rect1x1.Text = (rnd.Next(0, 50)).ToString();
            rect1x2.Text = (rnd.Next(50, 100)).ToString();
            rect1y1.Text = (rnd.Next(50, 100)).ToString();
            rect1y2.Text = (rnd.Next(0, 50)).ToString();
            rect2x1.Text = (rnd.Next(0, 100)).ToString();
            rect2x2.Text = (rnd.Next(100, 200)).ToString();
            rect2y1.Text = (rnd.Next(100, 200)).ToString();
            rect2y2.Text = (rnd.Next(0, 100)).ToString();
            start();
        }

        private void start()
        {
            int R1X1 = Convert.ToInt32(rect1x1.Text);
            int R1Y1 = Convert.ToInt32(rect1y1.Text);
            int R1X2 = Convert.ToInt32(rect1x2.Text);
            int R1Y2 = Convert.ToInt32(rect1y2.Text);
            int R2X1 = Convert.ToInt32(rect2x1.Text);
            int R2Y1 = Convert.ToInt32(rect2y1.Text);
            int R2X2 = Convert.ToInt32(rect2x2.Text);
            int R2Y2 = Convert.ToInt32(rect2y2.Text);

            if (R1X2 < R1X1 || R1Y2 > R1Y1 || R2X2 < R2X1 || R2Y2 > R2Y1)
            {
                MessageBox.Show("Некорректный ввод", "Result");
            }
            else
            {
                var rect1 = new Rectangle(R1X1, this.Height - R1Y1, R1X2 - R1X1, R1Y1 - R1Y2);
                var rect2 = new Rectangle(R2X1, this.Height - R2Y1, R2X2 - R2X1, R2Y1 - R2Y2);

                Picture picture = new Picture(rect1, rect2);
                picture.Show();

                checkIntersection r = new checkIntersection();
                if (r.isIntersection(R1X1, R1Y1, R1X2, R1Y2, R2X1, R2Y1, R2X2, R2Y2))
                {
                    MessageBox.Show("Прямоугольники пересекаются.", "Result");
                }
                else
                {
                    MessageBox.Show("Прямоугольники не пересекаются.", "Result");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
