using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Paint
{
    [Serializable]
    class Collection
    {
        public List<Shape> shapes;
        public List<int> indexesOfSelectedShapes;

        public Collection()
        {
            shapes = new List<Shape>();
            indexesOfSelectedShapes = new List<int>();
        }

        

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void DeleteLastShape()
        {
            shapes.RemoveAt(shapes.Count - 1);
        }

        public void Redraw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            foreach (Shape shape in shapes)
            {
                shape.Draw(graphics);
                shape.DoFill(graphics);
            }

            for (int i = indexesOfSelectedShapes.Count - 1; i >= 0; i--)
            {
                shapes[indexesOfSelectedShapes[i]].drawRectAroundShape(graphics);
            }
        }

        public void Save()
        {
            SaveFileDialog sfd1 = new SaveFileDialog
            {
                Title = "Сериализовать изображение как...",
                OverwritePrompt = true, //имя уже существующего файла
                CheckPathExists = true //несуществующий путь
            };

            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(sfd1.FileName, FileMode.OpenOrCreate))
                        new BinaryFormatter().Serialize(fs, shapes);
                }
                
                    
                
                catch
                {
                    throw new Exception("Ошибка при сериализации");
                }
            }
        }

        public void Open()
        {
            OpenFileDialog opd = new OpenFileDialog
            {
                Title = "Выберите файл для его десериализации...",
                CheckPathExists = true,
                CheckFileExists = true
            };
            if (opd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    shapes.Clear();

                    using (FileStream fs = new FileStream(opd.FileName, FileMode.OpenOrCreate))
                        shapes = (List<Shape>)new BinaryFormatter().Deserialize(fs);
                }
                catch
                {
                    throw new Exception("Ошибка при десериализации");
                }
            }
        }
    }
}
