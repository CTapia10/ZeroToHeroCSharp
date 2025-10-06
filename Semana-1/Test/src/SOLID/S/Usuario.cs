using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID.S
{
    // Sin respetar principio Single Responsibility Principle (SRP)
    // public class Usuario
    // {
    //     public string Username { get; set; }
    //     public string Email { get; set; }

    //     public void Registrar()
    //     {
    //         // Logica registro de usuario
    //         // Enviar mail
    //         EnviadorMail enviadorMail = new();
    //         enviadorMail.EnviarEmail(Email, "Bienvenido a nuestra plataforma");
    //     }
    // }


    //*** Respetando principio Single Responsibility Principle (SRP)
// Clase usuario solo carga datos del usuario
    public class Usuario
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }
    
}