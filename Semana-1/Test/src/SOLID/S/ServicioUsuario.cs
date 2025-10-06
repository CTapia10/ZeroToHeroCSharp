using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID.S
{
    public class ServicioUsuario
    {

        public void Registrar(Usuario usuario)
        {
            // Logica registro de usuario
            // Enviar mail
            EnviadorMail enviadorMail = new();
            enviadorMail.EnviarEmail(usuario.Email, "Bienvenido a nuestra plataforma");
        }
    }
}