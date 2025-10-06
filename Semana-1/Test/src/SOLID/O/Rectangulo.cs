using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID.O
{
    public class Rectangulo : Forma
    {
    public double Largo { get; set; }
    public double Ancho { get; set; }
        public override double CalcularArea()
        {
            return Largo * Ancho;
        }
    }
}