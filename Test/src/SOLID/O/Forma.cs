using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID.O
{
    // public class Forma
    // {
    // ** Sin respetar Open/Closed Principle (OCP)

    // public TipoDeFormas Tipo { get; set; }
    // public double Radio { get; set; }
    // public double Largo { get; set; }
    // public double Ancho { get; set; }
    // public double CalcularArea()
    // {
    //     switch (Tipo)
    //     {
    //         case TipoDeFormas.Circulo:
    //             return Math.PI * Math.Pow(Radio, 2);
    //         case TipoDeFormas.Rectangulo:
    //             return Largo * Ancho;
    //         default:
    //             throw new InvalidOperationException("Tipo de forma incorrecto");
    //     }
    // }

    // }
    // ** Respetando Open/Closed Principle (OCP)
    public abstract class Forma
    {
        public abstract double CalcularArea();
    }
}