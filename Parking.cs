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
        private readonly List<T> _places;

        /// Максимальное количество мест на парковке
        private readonly int _maxCount;

        /// Ширина окна отрисовки
        private readonly int pictureWidth;
        /// Высота окна отрисовки
        private readonly int pictureHeight;
        /// Размер парковочного места (ширина)

        private readonly int _placeSizeWidth = 340;
        /// Размер парковочного места (высота)
        private readonly int _placeSizeHeight = 120;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();

        }

        public static bool operator +(Parking<T> p, T car)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(car);
            return true;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index >= p._places.Count) return null;
            else
            {
                if (p._places[index] == null) return null;
                else
                {
                    T temp = p._places[index];
                    p._places.RemoveAt(index);
                    return temp;
                }
            }
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(i % (pictureWidth / _placeSizeWidth) * _placeSizeWidth + 6,
                    i / (pictureWidth / _placeSizeWidth) * _placeSizeHeight + 5, pictureWidth, pictureHeight);
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
                   _placeSizeWidth + _placeSizeWidth - 20, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
    }
}
