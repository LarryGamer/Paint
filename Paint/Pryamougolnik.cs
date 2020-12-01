using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    [Serializable]
    class Pryamougolnik:Shape
    {
        public Pryamougolnik(PointF startPoint, PointF endPoint,  Color colorBorder, byte widthBorder):base(colorBorder,widthBorder)
        {
            points = new PointF[4];

            points[0] = startPoint; //левая верхняя
            points[1] = new PointF(endPoint.X, startPoint.Y); //правая верхняя
            points[2] = endPoint; // правая нижняя
            points[3] = new PointF(startPoint.X, endPoint.Y); //левая нижняя
        }
    }
}
