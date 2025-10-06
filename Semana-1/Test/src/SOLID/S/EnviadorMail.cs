using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID.S
{
    public class EnviadorMail
    {
        public void EnviarEmail(string email, string mensaje)
        {
            Console.WriteLine($"Enviando mail a {email}: {mensaje}");
        }
    }
}