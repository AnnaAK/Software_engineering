using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            //arr[0] - x1
            //arr[1] - y1
            //arr[2] - x2
            //arr[3] - y2
            /*
            string[] arr1Str = Console.ReadLine().Split(new char[] {' '});
            double[] arr1D = new double[arr1Str.Length];
            
            for (int i = 0; i < arr1Str.Length; i++)
            {
                arr1D[i] = Convert.ToDouble(arr1Str[i]);
            }
            Rectangle rect1 = new Rectangle(arr1D[0], arr1D[1], arr1D[2], arr1D[3]);
            string[] arr2Str = Console.ReadLine().Split(new char[] { ' ' });
            double[] arr2D = new double[arr2Str.Length]; ;
            for (int i = 0; i < arr2Str.Length; i++)
            {
                arr2D[i] = Convert.ToDouble(arr2Str[i]);
            }
            Rectangle rect2 = new Rectangle(arr2D[0], arr2D[1], arr2D[2], arr2D[3]);
            WorkWithRectangles r = new WorkWithRectangles();
            Console.WriteLine(r.isIntersection(rect1, rect2).ToString());
*/
        }

    }

    public class WorkWithRectangles
    {
        private ObjRectangle rect1;
        private ObjRectangle rect2;

        public WorkWithRectangles(ObjRectangle rect1, ObjRectangle rect2)
        {
            this.rect1 = rect1;
            this.rect2 = rect2;
        }

        public bool isIntersection()
        {
            if ((((rect2.X1 <= rect1.X1) && (rect1.X1 <= rect2.X2)) || ((rect2.X1 <= rect1.X2) && (rect1.X2 <= rect2.X2))) &&
                (((rect2.Y1 <= rect1.Y1) && (rect1.Y1 <= rect2.Y2)) || ((rect2.Y1 <= rect1.Y2) && (rect1.Y2 <= rect2.Y2))))
            {
                return true;
            }
            return false;
        }
    }

    public class ObjRectangle
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;

        public int X1
        {
            get { return x1; }
        }

        public int Y1
        {
            get { return y1; }
        }

        public int X2
        {
            get { return x2; }
        }

        public int Y2
        {
            get { return y2; }
        }

        public ObjRectangle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

    }
}
