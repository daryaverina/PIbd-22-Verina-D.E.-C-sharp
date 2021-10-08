using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class Parking<T> where T : class, ITransport
    {
        private readonly T[] _places;
        /// Ширина окна отрисовки
        private readonly int pictureWidth;
        /// Высота окна отрисовки
        private readonly int pictureHeight;
        /// Размер парковочного места (ширина)

        // private readonly int _placeSizeWidth = 350;
        private readonly int _placeSizeWidth = 300;
        /// Размер парковочного места (высота)
       // private readonly int _placeSizeHeight = 165;
        private readonly int _placeSizeHeight = 115;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static int operator +(Parking<T> p, T plane)
        {
            //for(int i=0;i< p.pictureWidth; i+=p._placeSizeWidth)
            //Pen pen = new Pen(Color.Black, 3);
          //  Plane plane = new Plane(100,100,Color.Blue);
            //plane.SetPosition(500, 10, 300, 115);
            int i = 0;
            while (i < p.pictureHeight / p._placeSizeHeight - 1)
            {
                int j = 0;
                while (j < p.pictureWidth / p._placeSizeWidth)
                {
                    if (p._places[i * (p.pictureWidth / p._placeSizeWidth) + j] == null)
                    {
                        p._places[i * (p.pictureWidth / p._placeSizeWidth) + j] = plane;
                        plane.SetPosition(p._placeSizeWidth * j + 6, p._placeSizeHeight * i + 8, p.pictureWidth, p.pictureHeight);
                        return (i * (p.pictureWidth / p._placeSizeWidth) + j);
                    }
                    j++;
                }
                i++;
            }
            return -1;
            // plane.DrawTransport();
            /*  for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
              {
                  for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                  {//линия рамзетки места
                      g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                     _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                  }
                  g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                 (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
              }*/

           // return -1;
            // Прописать логику для сложения
        }

        public static T operator -(Parking<T> p, int index)
        {



            // Прописать логику для вычитания
            return null;
        }


        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }

        }
    }
}
