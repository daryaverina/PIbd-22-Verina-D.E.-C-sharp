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
    public partial class FormPlane : Form
    {
        private Airbus airbus;
        public FormPlane()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airbus.DrawTransport(gr);
            pictureBoxPlane.Image = bmp;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            airbus = new Airbus();
            airbus.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
            Color.Green, true, true);
            airbus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width, pictureBoxPlane.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    airbus.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    airbus.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    airbus.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    airbus.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void FormPlane_Load(object sender, EventArgs e)
        {

        }
    }
}
