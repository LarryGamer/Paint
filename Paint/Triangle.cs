using System;
using System.Drawing;

namespace Paint
{

    [Serializable]
    internal class Triangle : Shape
    {

        public Triangle(PointF startPoint, PointF endPoint, Color colorBorder, byte widthBorder) : base(colorBorder, widthBorder)
        {
            points = new PointF[3];
            points[0] = new PointF(startPoint.X, endPoint.Y);
            points[1] = endPoint;
            points[2] = new PointF((endPoint.X - startPoint.X) / 2 + startPoint.X, startPoint.Y); //вершина
        }
    }
}
