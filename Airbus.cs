using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsPlanes
{
    public class Airbus : Plane
    {
        //private int _startPosX;
       // private int _startPosY;
       // private int _pictureWidth;
        //private int _pictureHeight;
       // private readonly int planeWidth = 300;
        //private readonly int planeHeight = 115;
       // public int MaxSpeed { private set; get; }
        //public int Weight { private set; get; }
       // public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Star { private set; get; }
        public bool SecondLevel { private set; get; }

        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool star, bool secondLevel) :
 base(maxSpeed, weight, mainColor, 300, 115)
        {
            DopColor = dopColor;
            Star = star;
            SecondLevel = secondLevel;
        }
        /*public void Init(int maxSpeed, int weight, Color mainColor, Color dopColor, bool star, bool sportLines)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Star = star;
            SecondLevel = sportLines;
        }*/
        /*
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }*/

        /*
        public void MoveTransport(Direction direction)
        {
            int step = MaxSpeed * 100 / Weight;
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
        }*/

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            Pen pen_light = new Pen(Color.Black, 2);
            Pen pen_blue = new Pen(MainColor, 3);
            Pen pen_light_1 = new Pen(Color.Black, 1);
            Brush brLightBlue = new SolidBrush(MainColor);
            Brush brLightPurple = new SolidBrush(DopColor);
            Brush brWhite = new SolidBrush(Color.White);
            Brush brBlack = new SolidBrush(Color.Black);

            // шасси
            base.DrawTransport(g);

            if (!SecondLevel)
            {
                PointF point12 = new PointF(_startPosX + 75, _startPosY + 75);
                PointF point13 = new PointF(_startPosX + 120, _startPosY + 75);
                PointF point14 = new PointF(_startPosX + 75, _startPosY + 25);
                PointF point15 = new PointF(_startPosX + 60, _startPosY + 25);
                PointF[] curvePoints4 = { point12, point13, point14, point15 };
                g.FillPolygon(brBlack, curvePoints4);
            }
            if (SecondLevel)
            {

                g.FillEllipse(brLightBlue, _startPosX + 3, _startPosY + 50, 25, 12);
                g.DrawEllipse(pen_light, _startPosX + 3, _startPosY + 50, 25, 12);


                PointF point24 = new PointF(_startPosX + 20, _startPosY + 50);
                PointF point25 = new PointF(_startPosX + 215, _startPosY + 50);
                PointF point26 = new PointF(_startPosX + 265, _startPosY + 82);
                PointF point27 = new PointF(_startPosX + 45, _startPosY + 82);
                PointF point28 = new PointF(_startPosX + 4, _startPosY + 58);
                PointF[] curvePoints7 = { point24, point25, point26, point27, point28 };
                g.FillPolygon(brLightBlue, curvePoints7);
                g.DrawLine(pen_light, _startPosX + 3, _startPosY + 58, _startPosX + 51, _startPosY + 86);
                g.DrawLine(pen_light, _startPosX + 11, _startPosY + 50, _startPosX + 215, _startPosY + 50);
                g.DrawLine(pen_light, _startPosX + 214, _startPosY + 50, _startPosX + 265, _startPosY + 82);
            }

            if (SecondLevel)
            {
                float x1 = _startPosX + 65;
                for (int i = 0; i < 14; i++)
                {
                    g.FillEllipse(brWhite, x1, _startPosY + 65, 5, 7);
                    g.DrawEllipse(pen_light_1, x1, _startPosY + 65, 5, 7);
                    x1 += 12;
                }

                PointF point25 = new PointF(_startPosX + 25, _startPosY + 50);
                PointF point26 = new PointF(_startPosX + 70, _startPosY + 50);
                PointF point27 = new PointF(_startPosX + 25, _startPosY);
                PointF point28 = new PointF(_startPosX + 10, _startPosY);
                PointF[] curvePoints8 = { point25, point26, point27, point28 };
                g.FillPolygon(brBlack, curvePoints8);
            }

            if (Star)
            {
                int x_ = 35;
                int y_ = 30;

                PointF point29 = new PointF(_startPosX + x_, _startPosY - 10 + y_);
                PointF point30 = new PointF(_startPosX + 2 + x_, _startPosY - 3 + y_);
                PointF point31 = new PointF(_startPosX + 10 + x_, _startPosY - 3 + y_);
                PointF point32 = new PointF(_startPosX + 4 + x_, _startPosY + 1 + y_);
                PointF point33 = new PointF(_startPosX + 6 + x_, _startPosY + 9 + y_);
                PointF point34 = new PointF(_startPosX + x_, _startPosY + 4 + y_);
                PointF point35 = new PointF(_startPosX - 6 + x_, _startPosY + 9 + y_);
                PointF point36 = new PointF(_startPosX - 4 + x_, _startPosY + 1 + y_);
                PointF point37 = new PointF(_startPosX - 10 + x_, _startPosY - 3 + y_);
                PointF point38 = new PointF(_startPosX - 2 + x_, _startPosY - 3 + y_);
                PointF[] curvePoints10 = { point29, point30, point31, point32, point33, point34, point35, point36, point37, point38, };
                g.FillPolygon(brLightPurple, curvePoints10);
            }

            /*
            //крылья
            Point point16 = new Point(_startPosX + 65, _startPosY + 88);
            Point point17 = new Point(_startPosX + 85, _startPosY + 88);
            Point point18 = new Point(_startPosX + 50, _startPosY + 80);
            Point point19 = new Point(_startPosX + 35, _startPosY + 80);
            Point[] curvePoints5 = { point16, point17, point18, point19 };
            g.FillPolygon(brBlack, curvePoints5);

            Point point20 = new Point(_startPosX + 145, _startPosY + 95);
            Point point21 = new Point(_startPosX + 175, _startPosY + 95);
            Point point22 = new Point(_startPosX + 140, _startPosY + 80);
            Point point23 = new Point(_startPosX + 125, _startPosY + 80);
            Point[] curvePoints6 = { point20, point21, point22, point23 };
            g.FillPolygon(brBlack, curvePoints6);*/
        }
    }
}
