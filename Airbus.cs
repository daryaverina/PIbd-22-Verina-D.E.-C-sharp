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

        public Color DopColor { private set; get; }
        public bool Star { private set; get; }
        public bool SecondLevel { private set; get; }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool star, bool secondLevel) :
 base(maxSpeed, weight, mainColor, 300, 115)
        {
            DopColor = dopColor;
            Star = star;
            SecondLevel = secondLevel;
        }

        public Airbus(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Star = Convert.ToBoolean(strs[4]);
                SecondLevel = Convert.ToBoolean(strs[5]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            base.MoveTransport(direction);
        }

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

                PointF point25 = new PointF(_startPosX + 52, _startPosY + 50);
                PointF point26 = new PointF(_startPosX + 97, _startPosY + 50);
                PointF point27 = new PointF(_startPosX + 52, _startPosY);
                PointF point28 = new PointF(_startPosX + 37, _startPosY);
                PointF[] curvePoints8 = { point25, point26, point27, point28 };
                g.FillPolygon(brBlack, curvePoints8);
            }

            if (Star)
            {
                int x_ = 72;
                int y_ = 38;

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
        }

        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{Star}{separator}{SecondLevel}";
        }
    }
}
