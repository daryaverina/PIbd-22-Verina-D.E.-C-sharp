using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    public class PlaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name == "Plane" && y.GetType().Name == "Plane")
            {
                return ComparerPlane(x as Plane, y as Plane);
            }
            else if (x.GetType().Name == "Airbus" && y.GetType().Name == "Airbus")
            {
                return ComparerAirbus(x as Airbus, y as Airbus);
            }
            else if (x.GetType().Name == "Airbus" && y.GetType().Name == "Plane")
            {
                return -1;
            }
            else if (x.GetType().Name == "Plane" && y.GetType().Name == "Airbus")
            {
                return 1;
            }
            return 0;
        }
        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerAirbus(Airbus x, Airbus y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Star != y.Star)
            {
                return x.Star.CompareTo(y.Star);
            }
            if (x.SecondLevel != y.SecondLevel)
            {
                return x.SecondLevel.CompareTo(y.SecondLevel);
            }
            return 0;
        }
    }
}
