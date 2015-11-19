using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class checkIntersection
    {
        public bool isIntersection(int R1X1, int R1Y1, int R1X2, int R1Y2, int R2X1, int R2Y1, int R2X2, int R2Y2)
        {
            if ((interSegm(R1X1, R1Y1, R1X1, R1Y2, R2X1, R2Y1, R2X2, R2Y1) || (interSegm(R1X1, R1Y1, R1X1, R1Y2, R2X1, R2Y2, R2X2, R2Y2))) ||
                (interSegm(R1X2, R1Y1, R2X2, R2Y2, R2X1, R2Y1, R2X2, R2Y1) || (interSegm(R1X2, R1Y1, R2X2, R2Y2, R2X1, R2Y2, R2X2, R2Y2))) ||
                (interSegm(R1X1, R1Y1, R1X2, R1Y1, R2X1, R2Y1, R2X1, R2Y2) || (interSegm(R1X1, R1Y1, R1X2, R1Y1, R2X2, R2Y1, R2X2, R2Y2))) ||
                (interSegm(R1X1, R1Y2, R1X2, R1Y2, R2X1, R2Y1, R2X1, R2Y2) || (interSegm(R1X1, R1Y2, R1X2, R1Y2, R2X2, R2Y1, R2X2, R2Y2))))
            {
                return true;
            }
            return false;
        }

        private bool interSegm(int s1x1, int s1y1, int s1x2, int s1y2, int s2x1, int s2y1, int s2x2, int s2y2)
        {
            if (((s1x1 <= s2x1) && (s2x1 <= s1x2) || (s2x1 <= s1x1) && (s1x1 <= s2x2)) &&
                ((s1y2 <= s2y1) && (s2y1 <= s1y1) || (s2y2 <= s1y1) && (s1y1 <= s2y1)))
            {
                return true;
            }
            return false;
        }
    }
}

