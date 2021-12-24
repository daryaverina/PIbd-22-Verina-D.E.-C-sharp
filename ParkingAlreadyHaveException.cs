using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    class ParkingAlreadyHaveException : Exception
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ParkingAlreadyHaveException() : base("На парковке уже есть такой самолет") { }
    }
}
