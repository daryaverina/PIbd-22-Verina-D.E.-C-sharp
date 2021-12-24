using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlanes
{
    public partial class FormPlaneConfig : Form
    {
        Vehicle plane = null;

        private event Action<Vehicle> eventAddPlane;
        public FormPlaneConfig()
        {
            InitializeComponent();
            //Привязывание к панелям события MouseDown
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelGrey.MouseDown += panelColor_MouseDown;
            panelBrown.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            //Лямбда-выражение
            buttonCancell.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxPlane.Image = bmp;
            }
        }
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void LabelPlane_MouseDwon(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void LabelAirbus_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirbus.DoDragDrop(labelAirbus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолет":
                    plane = new Plane(Convert.ToInt32(numericUpDown_Speed.Value), Convert.ToInt32(numericUpDown_Weight.Value), Color.White);
                    break;
                case "Аэробус":
                    plane = new Airbus(Convert.ToInt32(numericUpDown_Speed.Value), Convert.ToInt32(numericUpDown_Weight.Value),
                           Color.White, Color.White, CheckBox_Star.Checked, checkBox_SecLevel.Checked);
                    break;
            }
            DrawPlane();
        }
        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.DoDragDrop(panel.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            Color mainc = (Color)e.Data.GetData(typeof(Color));
            plane?.SetMainColor(mainc);
            DrawPlane();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            Color dopc = (Color)e.Data.GetData(typeof(Color));
            (plane as Airbus)?.SetDopColor(dopc);
            DrawPlane();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
        private void checkBox_SecLevel_Click(object sender, EventArgs e)
        {
            if (plane != null && plane is Airbus)
            {
                Color mainColor = plane.MainColor;
                Color dopColor = (plane as Airbus).DopColor;
                bool star = (plane as Airbus).Star;
                if (!checkBox_SecLevel.Checked)
                {
                    plane = new Airbus(Convert.ToInt32(numericUpDown_Speed.Value),
                        Convert.ToInt32(numericUpDown_Weight.Value),
                        mainColor, dopColor, star, false);
                }
                else
                {

                    plane = new Airbus(Convert.ToInt32(numericUpDown_Speed.Value),
                        Convert.ToInt32(numericUpDown_Weight.Value),
                        mainColor, dopColor, star, true);
                }
                DrawPlane();
            }
        }

        private void CheckBox_Star_Click(object sender, EventArgs e)
        {
            if (plane != null && plane is Airbus)
            {
                Color mainColor = plane.MainColor;
                Color dopColor = (plane as Airbus).DopColor;
                bool seclevel = (plane as Airbus).SecondLevel;
                if (!CheckBox_Star.Checked)
                {
                    plane = new Airbus(Convert.ToInt32(numericUpDown_Speed.Value),
                         Convert.ToInt32(numericUpDown_Weight.Value),
                         mainColor, dopColor, false, seclevel);
                }
                else
                {
                    plane = new Airbus(Convert.ToInt32(numericUpDown_Speed.Value),
                       Convert.ToInt32(numericUpDown_Weight.Value),
                      mainColor, dopColor, true, seclevel);
                }
                DrawPlane();
            }
        }
    }
}
