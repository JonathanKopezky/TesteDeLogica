using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Poligono
    {
        public float area { get; set; }
        public float _base { get; set; }
        public float height { get; set; }

        public virtual float CalcularArea(float _base, float height)
        {
            return area;
        }
    }
}
