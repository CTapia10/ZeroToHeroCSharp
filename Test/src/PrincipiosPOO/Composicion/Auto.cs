using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.PrincipiosPOO.Composicion
{
    public class Auto
    {
        private Asientos asientos = new();
        private Motor motor = new();
        private Ruedas ruedas = new();
        public void Arrancar()
        {
            asientos.Sentarse();
            ruedas.Girar();
            motor.Arrancar();
            Console.WriteLine("Auto encendido");
        }

    }
}