using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
            if (!parkingStages.ContainsKey(name)) parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
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

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"ParkingCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    WriteToFile($"Parking{separator}{level.Key}{Environment.NewLine}",
                    fs);
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (plane.GetType().Name == "Plane")
                            {
                                WriteToFile($"Plane{separator}", fs);
                            }
                            if (plane.GetType().Name == "Airbus")
                            {
                                WriteToFile($"Airbus{separator}", fs);
                            }
                            //Записываемые параметры
                            WriteToFile(plane + Environment.NewLine, fs);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("ParkingCollection"))
            {
                //очищаем записи
                parkingStages.Clear();
            }
            else
            {
                //если нет такой записи, то это не те данные
                return false;
            }
            Vehicle car = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i].Contains("Parking"))
                {
                    //начинаем новую парковку
                    key = strs[i].Split(separator)[1];
                    parkingStages.Add(key, new Parking<Vehicle>(pictureWidth,
                    pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "Plane")
                {
                    car = new Plane(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "Airbus")
                {
                    car = new Airbus(strs[i].Split(separator)[1]);
                }
                var result = parkingStages[key] + car;
                if (!result)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
