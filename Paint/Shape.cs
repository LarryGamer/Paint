using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    [Serializable]
    abstract class Shape    
    {
        public byte widthBorder;
        public Color ColorBorder { get; set; }
        public Color FillColor { get; set; }

        public byte WidthBorder { get=>widthBorder; set=> widthBorder=value; }
        protected PointF[] points;
        [NonSerialized]
        public RectangleF selectedRect;


        public void createRect()
        {
            float xRight = points[0].X;
            float xLeft = points[0].X;
            float yTop = points[0].Y;
            float yBottom = points[0].Y;

            foreach (PointF PointF in points)
            {
                xLeft = Math.Min(PointF.X, xLeft);
                xRight = Math.Max(PointF.X, xRight);
                yTop = Math.Min(PointF.Y, yTop);
                yBottom = Math.Max(PointF.Y, yBottom);
            }

            selectedRect = new RectangleF(xLeft, yTop, xRight - xLeft, yBottom - yTop);
        }

        public void drawRectAroundShape(Graphics graphics)
        {
            createRect();
            Pen pen = new Pen(Color.White);
            pen.DashStyle = DashStyle.Solid;
            pen.Width = 1.5f;
            graphics.DrawRectangle(pen, selectedRect.Left, selectedRect.Top, selectedRect.Width,
                selectedRect.Height);
            pen.Color = Color.Red;
            pen.DashPattern = new float[] { 4, 4 };
            graphics.DrawRectangle(pen, selectedRect.Left, selectedRect.Top, selectedRect.Width,
                selectedRect.Height);
        }
        public Shape(Color colorBorder, byte widthBorder)
        {
            this.widthBorder = widthBorder;
            this.ColorBorder = colorBorder;
        }

        public virtual Graphics Draw(Graphics graphics)
        {
            Pen pen = new Pen(ColorBorder,WidthBorder);

            graphics.DrawPolygon(pen, points);

            return graphics;
        }

        public virtual bool Touch(PointF pointForCheck)
        {
            bool c = false;

            for (int i = 0, j = points.Length - 1; i < points.Length; j = i++)
            {
                if ((((points[i].Y <= pointForCheck.Y) && (pointForCheck.Y < points[j].Y)) ||
                     ((points[j].Y <= pointForCheck.Y) && (pointForCheck.Y < points[i].Y))) &&
                    (((points[j].Y - points[i].Y) != 0) && (pointForCheck.X >
                                                            ((points[j].X - points[i].X) *
                                                                (pointForCheck.Y - points[i].Y) /
                                                                (points[j].Y - points[i].Y) + points[i].X))))
                    c = !c;
            }

            return c;
        }

        public virtual void DoFill(Graphics graphics)
        {
            graphics.FillPolygon(new SolidBrush(FillColor), points);
            Pen p = new Pen(ColorBorder, widthBorder);
            graphics.DrawPolygon(p, points);
        }

        public void Move(PointF point)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new PointF(points[i].X - point.X, points[i].Y - point.Y);
            }
        }


    }


}
