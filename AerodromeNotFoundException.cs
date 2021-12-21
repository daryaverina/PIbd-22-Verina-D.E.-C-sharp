using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    public class AerodromeNotFoundException : Exception
    {
        public AerodromeNotFoundException(int i) : base("Не найден самолет по месту " + i)
        {
        }
    }
}




