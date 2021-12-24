using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class Parking<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, ITransport
    {
        public readonly List<T> _places;

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

        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }

        public static int operator +(Parking<T> p, T plane)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new AerodromeOverflowException();
            }
            if (p._places.Contains(plane))
            {
                throw new ParkingAlreadyHaveException();
            }
            p._places.Add(plane);
            return p._places.Count - 1;
        }
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                throw new AerodromeNotFoundException(index);
            }
            T plane = p._places[index];
            p._places.RemoveAt(index);
            return plane;
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
            if (index <0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        public void Sort() => _places.Sort((IComparer<T>)new PlaneComparer());

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_currentIndex < _places.Count - 1)
            {
                _currentIndex++;
                return true;
            }
            _currentIndex = -1;
            return false;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
