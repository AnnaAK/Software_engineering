using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntersectionRectanglesGUI
{
    public partial class Picture : Form
    {
        private Rectangle rect1;
        private Rectangle rect2;

        public Picture(Rectangle rect1, Rectangle rect2)
        {
            this.rect1 = rect1;
            this.rect2 = rect2;
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = CreateGraphics())
            {
                Pen pen = new Pen(Color.Blue, 3);
                g.DrawRectangle(pen, rect1);
                pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rect2);
            }
        }
    }
}
