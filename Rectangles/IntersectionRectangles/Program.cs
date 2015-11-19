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
        }
    }
    public class checkIntersection
    {
        public bool isIntersection(int R1X1, int R1Y1, int R1X2, int R1Y2, int R2X1, int R2Y1, int R2X2, int R2Y2)
        {
            if ((((R2X1 <= R1X1) && (R1X1 <= R2X2)) || ((R2X1 <= R1X2) && (R1X2 <= R2X2))) &&
                (((R2Y2 <= R1Y1) && (R1Y1 <= R2Y1)) || ((R2Y2 <= R1Y2) && (R1Y2 <= R2Y1))))
            {
                return true;
            }
            return false;
        }
    }

}
