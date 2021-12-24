using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using NLog;


namespace WindowsFormsPlanes
{
    public partial class FormParking : Form
    {
        private readonly ParkingCollection parkingCollection;

        // Логгер
        private readonly Logger logger;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width,
pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
          //  Draw();
        }
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }

            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
       listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
           listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                    Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                   pictureBoxParking.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                    pictureBoxParking.Image = bmp;

            }
        }
        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxParkingName.Text))
            {
             //   logger.Warn($"Не ввели название аэродрома");
                MessageBox.Show("Введите название аэродрома", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили аэродром {textBoxParkingName.Text}");
            parkingCollection.AddParking(textBoxParkingName.Text);
            ReloadLevels();
        }
        private void buttonDeleteParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэродром { listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили аэродром { listBoxParkings.SelectedItem.ToString()} ");
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                    Draw();
                }
            }
        }
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBoxTake.Text != "")
            {
                try
                {
                    var plane = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxTake.Text);
                    if (plane != null)
                    {
                        FormPlane form = new FormPlane();
                        form.SetPlane(plane);
                        form.ShowDialog();
                        logger.Info($"Изъят самолет {plane} с места{ maskedTextBoxTake.Text} ");
                        Draw();
                    }
                }
                catch (AerodromeNotFoundException ex)
                {
                    // logger.Warn($"Введен индекс вне доступного интервала: { maskedTextBoxTake.Text}");
                    logger.Warn("Попытка забрать транспорт с незанятого места");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная ошибка при попытке изъять корабль с { maskedTextBoxTake.Text} места");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку{ listBoxParkings.SelectedItem.ToString()}  ");
            Draw();
        }

        private void buttonAddPlane_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                var formLocoConfig = new FormPlaneConfig();
                formLocoConfig.AddEvent(AddPlane);
                formLocoConfig.Show();
            }
        }
        private void AddPlane(Vehicle plane)
        {
            if (plane != null && listBoxParkings.SelectedIndex > -1)
            {
                try
                {
                    if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + plane != -1)
                    {
                        Draw();
                        logger.Info($"Добавлен автомобиль {plane}");
                    }
                    else
                    {
                        MessageBox.Show("Самолет не удалось поставить");
                    }
                    Draw();
                }
                catch (AerodromeOverflowException ex)
                {
                    logger.Warn($"Переполнение аэродрома { listBoxParkings.SelectedItem.ToString()}");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная ошибка при попытке добавить самолет на аэродром { listBoxParkings.SelectedItem.ToString()}");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      

        
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogParking.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialogParking.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialogParking.FileName);
                }
                catch (FileNotFoundException ex)
                {
                    logger.Warn("Ошибка сохранения: файл не найден");
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogParking.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialogParking.FileName);

                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,

                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialogParking.FileName);
                    ReloadLevels();
                    Draw();
                }
                /*
                catch (AerodromeOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }*/
                catch (FileNotFoundException ex)
                {
                    logger.Warn("Ошибка загрузки: файл не найден");
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}



