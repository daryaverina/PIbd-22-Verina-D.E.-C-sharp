using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    class ParkingCollection
    {
        /// Словарь (хранилище) с парковками
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// Возвращение списка названий праковок
        public List<string> Keys => parkingStages.Keys.ToList();
        /// Ширина окна отрисовки
        private readonly int pictureWidth;
        /// Высота окна отрисовки
        private readonly int pictureHeight;

        private readonly char separator = ':';
        /// Конструктор
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// Добавление парковки
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }
        /// Удаление парковки
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name)) parkingStages.Remove(name);
        }
        /// Доступ к парковке
        public Parking<Vehicle> this[string ind]
        {
            set
            {
                if (!parkingStages.ContainsKey(ind))
                    parkingStages[ind] = value;
            }

            get
            {
                if (!parkingStages.ContainsKey(ind)) return null;
                return parkingStages[ind];
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter streamWriter = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("ParkingCollection");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    streamWriter.WriteLine($"Parking{separator}{level.Key}");
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            //если место не пустое
                            //Записываем тип самолета
                            if (plane.GetType().Name == "Plane")
                            {
                                streamWriter.Write($"Plane{separator}");
                            }
                            if (plane.GetType().Name == "Airbus")
                            {
                                streamWriter.Write($"Airbus{separator}");
                            }
                            //Записываемые параметры
                            streamWriter.WriteLine(plane);
                        }
                    }
                }
            }
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader streamReader = new StreamReader(filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FormatException("Неверный формат файла");
                }

                Vehicle plane = null;
                string key = string.Empty;
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Contains("Parking"))
                    {
                        key = line.Substring(8);
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Contains("Plane"))
                    {
                        plane = new Plane(line.Substring(6));
                    }
                    else if (line.Contains("Airbus"))
                    {
                        plane = new Airbus(line.Substring(7));
                    }
                    var result = parkingStages[key] + plane;
                    if (result==-1)
                    {
                        //throw new Exception("Не удалось загрузить автомобиль на парковку");
                        throw new TypeLoadException("Не удалось загрузить самолет на парковку");
                    }
                }
            }
        }
    }
}
