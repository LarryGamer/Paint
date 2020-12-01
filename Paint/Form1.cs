using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Paint
{
    internal enum Tools
    {
        Pryamougolnik,
        MyEllipse,
        Triangle,
        Fill,
        Select,
        None

    }
    public partial class Form1 : Form
    {
        Color color;
        byte borderSize;
        PointF currentPoint;
        PointF startMousePoint;
        Graphics graphics;
        Bitmap picture;
        Thread threadShape;
        bool threadShapeIsRunning;
        Collection collection;
        int moveIndex=-1;
        Thread threadForSelect;


        Tools tools;

        public Form1()
        {
            InitializeComponent();
            picture = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(picture);
            pictureBox1.Image = picture;
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panelColor.BackColor = colorDialog1.Color;
            color = colorDialog1.Color;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            borderSize = (byte)trackBar1.Value;
        }

        private void buttonDrawPryamougolnik_Click(object sender, EventArgs e)
        {
            tools = Tools.Pryamougolnik;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ResetSelect();
            }

            if (e.Button == MouseButtons.Left)
            {
                startMousePoint = e.Location;



                switch (tools)
                {

                    case Tools.Fill:
                        for (int i = collection.shapes.Count - 1; i >= 0; i--)
                        {
                            if (collection.shapes[i].Touch(currentPoint))
                            {
                                collection.shapes[i].FillColor = color;
                                break;
                            }
                        }
                        collection.Redraw(graphics);
                        pictureBox1.Image = picture;
                        break;


                    case Tools.Select:
                        for (int i = collection.shapes.Count - 1; i >= 0; i--)
                        {
                            bool alreadySelect = false;
                            foreach(int index in collection.indexesOfSelectedShapes)
                            {
                                if (index == i)
                                {
                                    alreadySelect = true;
                                    break;
                                }
                            }
                            bool touched = collection.shapes[i].Touch(currentPoint);
                            if (!alreadySelect)
                            {
                                if (touched)
                                {
                                    collection.indexesOfSelectedShapes.Add(i);
                                    collection.Redraw(graphics);
                                    pictureBox1.Image = picture;
                                }

                            }
                            else
                            {
                                if (touched)
                                {
                                    moveIndex = i;
                                    threadForSelect = new Thread(() =>
                                    {
                                        while (moveIndex!=-1)
                                        {
                                            collection.shapes[moveIndex].Move(new PointF(startMousePoint.X - currentPoint.X,
                                                        startMousePoint.Y - currentPoint.Y));
                                            startMousePoint = currentPoint;
                                            collection.Redraw(graphics);
                                            pictureBox1.Image = picture;
                                            Thread.Sleep(16);
                                        }
                                    });
                                    threadForSelect.Start();
                                    break;
                                }
                            }    
                        }
                            break;
                    default:
                        threadShapeIsRunning = true;
                        collection.AddShape(new Pryamougolnik(currentPoint, currentPoint, Color.Black, 5));
                        threadShape = new Thread(() =>
                          {
                              while (threadShapeIsRunning)
                              {
                                  PointF startPoint = new PointF();
                                  PointF endPoint = new PointF();
                                  collection.DeleteLastShape();
                                  startPoint.X = Math.Min(startMousePoint.X, currentPoint.X);
                                  startPoint.Y = Math.Min(startMousePoint.Y, currentPoint.Y);
                                  endPoint.X = startPoint.X + Math.Abs(currentPoint.X - startMousePoint.X);
                                  endPoint.Y = startPoint.Y + Math.Abs(currentPoint.Y - startMousePoint.Y);
                                  switch (tools)
                                  {
                                      case Tools.Pryamougolnik:
                                          Pryamougolnik pryamougolnik = new Pryamougolnik(startPoint, endPoint, color, borderSize);
                                          collection.AddShape(pryamougolnik);
                                          break;

                                      case Tools.MyEllipse:
                                          MyEllipse myEllipse = new MyEllipse(startPoint, endPoint, color, borderSize);
                                          collection.AddShape(myEllipse);
                                          break;
                                      case Tools.Triangle:
                                          Triangle triangle = new Triangle(startPoint, endPoint, color, borderSize);
                                          collection.AddShape(triangle);
                                          break;

                                  }
                                  collection.Redraw(graphics);
                                  pictureBox1.Image = picture;
                                  Thread.Sleep(16);
                              }

                          }
                            );
                        threadShape.Start();
                        break;
                }


            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            collection = new Collection();
            borderSize = (byte)trackBar1.Value;
            color = panelColor.BackColor;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                threadShapeIsRunning = false;
                //tools = Tools.None;
                moveIndex = -1;
            }
            
        }

        private void myEllipse_Click(object sender, EventArgs e)
        {
            tools = Tools.MyEllipse;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tools = Tools.Triangle;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collection.Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            picture.Dispose();
            picture = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(picture);

            collection.Open();

            collection.Redraw(graphics);
            pictureBox1.Image = picture;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            tools = Tools.Fill;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            tools = Tools.Select;
        }
        private void ResetSelect()
        {
            collection.indexesOfSelectedShapes.Clear();
            collection.Redraw(graphics);
            pictureBox1.Image = picture;
        }
    }
}
