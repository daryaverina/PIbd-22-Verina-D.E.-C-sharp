using System;
using System.Collections.Generic;
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
        readonly Dictionary<string, Parking<Plane>> parkingStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Plane>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddParking(string name)
        {
            // Прописать логику для добавления
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Plane>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
            // Прописать логику для удаления
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Plane> this[string index]
        {
            get
            {
                if (parkingStages.ContainsKey(index))
                {
                    return parkingStages[index];
                }
                return null;
            }
        }
    }
}
