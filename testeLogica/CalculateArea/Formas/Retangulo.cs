using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Formas
{
    public class Retangulo : Poligono
    {
        public override float CalcularArea(float _base, float height)
        {
            base.CalcularArea( _base, height);
            area = _base * height;

            return area;
        }
    }
}
