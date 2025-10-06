

namespace Test.src.PrincipiosPOO.Coupling
{
    public class EnviadorMail : IServicioNotificacion
    {
        public void EnviarNotificacion(string mensaje)
        {
            // Logica de enviar mail
            Console.WriteLine("Enviando mail: " + mensaje);
        }
    }
}