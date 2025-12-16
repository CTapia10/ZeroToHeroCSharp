using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.PrincipiosPOO.Coupling
{
    public class EnviadorSMS : IServicioNotificacion
    {
        public void EnviarNotificacion(string mensaje)
        {
            Console.WriteLine("Enviando mensaje sms: " + mensaje);
        }
    }
}