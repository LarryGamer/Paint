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
        public override float Width { get => Math.Abs(points[2].X - points[0].X); }
        public override float Height { get => Math.Abs(points[2].Y - points[0].Y); }

        public Pryamougolnik(PointF startPoint, PointF endPoint,  Color colorBorder, byte widthBorder):base(colorBorder,widthBorder)
        {
            points = new PointF[4];

            points[0] = startPoint; //левая верхняя
            points[1] = new PointF(endPoint.X, startPoint.Y); //правая верхняя
            points[2] = endPoint; // правая нижняя
            points[3] = new PointF(startPoint.X, endPoint.Y); //левая нижняя
        }

        public override double GetSquare() => this.Width * this.Height;
        public override void SetPosition(float x, float y) {
            float width = this.Width;
            float height = this.Height;

            points[0] = new PointF(x, y);
            points[1] = new PointF(x + width, y);
            points[2] = new PointF(x + width, y + height);
            points[3] = new PointF(x, y + height);
        }
    }
}
