namespace Test.src.PrincipiosPOO.Coupling
{
    public class Orden
    {
        private readonly IServicioNotificacion servicioNotificacion;

        public Orden(IServicioNotificacion servicioNotificacion)
        {
            this.servicioNotificacion = servicioNotificacion;
        }

        public void ColocarOrden()
        {
            // // Logica de colocar orden
            // EnviadorMail enviadorMail = new();
            // enviadorMail.EnviarNotificacion("Orden colocada exitosamente");
            servicioNotificacion.EnviarNotificacion("Orden colocada exitosamente");
        }

    }
}