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
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjRectangle rect1 = new ObjRectangle(Convert.ToDouble(rect1x1.Text), Convert.ToDouble(rect1y1.Text),
                                                  Convert.ToDouble(rect1x2.Text), Convert.ToDouble(rect1y2.Text));
            ObjRectangle rect2 = new ObjRectangle(Convert.ToDouble(rect2x1.Text), Convert.ToDouble(rect2y1.Text),
                                                  Convert.ToDouble(rect2x2.Text), Convert.ToDouble(rect2y2.Text));
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
    }
}
