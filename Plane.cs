using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class Plane : Vehicle
    {
        protected readonly int planeWidth = 300;
        protected readonly int planeHeight = 115;

        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected Plane(int maxSpeed, float weight, Color mainColor, int planeWidth, int
planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX + step > 0)
                    {
                        _startPosX -= step;
                    }

                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY + step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            Pen pen_light = new Pen(Color.Black, 2);
            Pen pen_blue = new Pen(MainColor, 3);
            Pen pen_light_1 = new Pen(Color.Black, 1);
            Brush brLightBlue = new SolidBrush(MainColor);
            Brush brWhite = new SolidBrush(Color.White);
            Brush brBlack = new SolidBrush(Color.Black);

            // шасси
            g.DrawLine(pen, _startPosX + 255, _startPosY + 100, _startPosX + 255, _startPosY + 110);
            g.DrawEllipse(pen, _startPosX + 253, _startPosY + 110, 4, 4);
            g.DrawLine(pen, _startPosX + 115, _startPosY + 103, _startPosX + 115, _startPosY + 112);
            g.DrawEllipse(pen, _startPosX + 117, _startPosY + 110, 4, 4);
            g.DrawEllipse(pen, _startPosX + 110, _startPosY + 110, 4, 4);

            //тело
            g.DrawEllipse(pen, _startPosX + 65, _startPosY + 75, 220, 30);
            g.FillEllipse(brLightBlue, _startPosX + 65, _startPosY + 75, 220, 30);
            g.FillEllipse(brLightBlue, _startPosX + 47, _startPosY + 75, 25, 12);
            g.DrawEllipse(pen, _startPosX + 47, _startPosY + 75, 25, 12);

            PointF point7 = new PointF(_startPosX + 54, _startPosY + 75);
            PointF point8 = new PointF(_startPosX + 165, _startPosY + 75);
            PointF point9 = new PointF(_startPosX + 115, _startPosY + 103);
            PointF point10 = new PointF(_startPosX + 85, _startPosY + 103);
            PointF point11 = new PointF(_startPosX + 51, _startPosY + 87);
            PointF[] curvePoints3 = { point7, point8, point9, point10, point11 };
            g.FillPolygon(brLightBlue, curvePoints3);
            g.DrawLine(pen_light, _startPosX + 54, _startPosY + 75, _startPosX + 165, _startPosY + 75);
            g.DrawLine(pen_light, _startPosX + 115, _startPosY + 103, _startPosX + 85, _startPosY + 103);
            g.DrawLine(pen_light, _startPosX + 85, _startPosY + 103, _startPosX + 51, _startPosY + 86);

            //перед
            PointF point1 = new PointF(_startPosX + 265, _startPosY + 80);
            PointF point2 = new PointF(_startPosX + 290, _startPosY + 90);
            PointF point3 = new PointF(_startPosX + 265, _startPosY + 100);
            PointF[] curvePoints = { point1, point2, point3, };
            g.FillPolygon(brWhite, curvePoints);
            g.DrawPolygon(pen, curvePoints);
            PointF point4 = new PointF(_startPosX + 265, _startPosY + 90);
            PointF point5 = new PointF(_startPosX + 290, _startPosY + 90);
            PointF point6 = new PointF(_startPosX + 265, _startPosY + 100);
            PointF[] curvePoints2 = { point4, point5, point6, };
            g.FillPolygon(brBlack, curvePoints2);

            //иллюминаторы
            float x = _startPosX + 85;
            for (int i = 0; i < 14; i++)
            {
                g.FillEllipse(brWhite, x, _startPosY + 81, 5, 7);
                g.DrawEllipse(pen_light_1, x, _startPosY + 81, 5, 7);
                x += 12;
            }
            //крылья
            PointF point16 = new PointF(_startPosX + 65, _startPosY + 88);
            PointF point17 = new PointF(_startPosX + 85, _startPosY + 88);
            PointF point18 = new PointF(_startPosX + 50, _startPosY + 80);
            PointF point19 = new PointF(_startPosX + 35, _startPosY + 80);
            PointF[] curvePoints5 = { point16, point17, point18, point19 };
            g.FillPolygon(brBlack, curvePoints5);

            PointF point20 = new PointF(_startPosX + 145, _startPosY + 95);
            PointF point21 = new PointF(_startPosX + 175, _startPosY + 95);
            PointF point22 = new PointF(_startPosX + 140, _startPosY + 80);
            PointF point23 = new PointF(_startPosX + 125, _startPosY + 80);
            PointF[] curvePoints6 = { point20, point21, point22, point23 };
            g.FillPolygon(brBlack, curvePoints6);

            PointF point12 = new PointF(_startPosX + 75, _startPosY + 75);
            PointF point13 = new PointF(_startPosX + 120, _startPosY + 75);
            PointF point14 = new PointF(_startPosX + 75, _startPosY + 25);
            PointF point15 = new PointF(_startPosX + 60, _startPosY + 25);
            PointF[] curvePoints4 = { point12, point13, point14, point15 };
            g.FillPolygon(brBlack, curvePoints4);
        }
    }
}
