using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.PrincipiosPOO.Coupling
{
    public interface IServicioNotificacion
    {
        void EnviarNotificacion(string mensaje);
    }
}