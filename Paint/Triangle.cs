using System;
using System.Drawing;

namespace Paint
{

    [Serializable]
    internal class Triangle : Shape
    {
        public override float Width { get => Math.Abs(points[2].X - points[1].X); }
        public override float Height { get => Math.Abs(points[2].Y - points[1].Y); }

        public Triangle(PointF startPoint, PointF endPoint, Color colorBorder, byte widthBorder) : base(colorBorder, widthBorder)
        {
            points = new PointF[3];
            points[0] = new PointF(startPoint.X, endPoint.Y);
            points[1] = endPoint;
            points[2] = new PointF((endPoint.X - startPoint.X) / 2 + startPoint.X, startPoint.Y); //вершина
        }

        public override double GetSquare() => 0.5 * this.Width * this.Height;
        public override void SetPosition(float x, float y) {
            float width = this.Width;
            float height = this.Height;

            points[0] = new PointF(x, y + height);
            points[1] = new PointF(x + width, y + height);
            points[2] = new PointF(x + width / 2, y);
        }
    }
}
