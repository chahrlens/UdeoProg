using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHospital
{
    internal class Validar
    {
        public int validateInt(String value, ref bool success)
        {
            int v = 0;
            if (int.TryParse(value, out v))
            {
                success = true;
                return v;
            }
            return 0;
        }
    }
}
