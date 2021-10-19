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
    public partial class FormParking : Form
    {
        private readonly Parking<Plane> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Plane>(pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonParkPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);
                if (parking + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Стоянка переполнена");
                }

            }
        }

        private void buttonParkAirbus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Airbus(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    if (parking + plane)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Стоянка переполнена");
                    }
                }
            }
        }


        private void label_place_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxParking_Click(object sender, EventArgs e)
        {

        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxTake.Text != "")
            {
                var plane = parking - Convert.ToInt32(maskedTextBoxTake.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }

        }

        private void FormParking_Load(object sender, EventArgs e)
        {

        }
    }
}
