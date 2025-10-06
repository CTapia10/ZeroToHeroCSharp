namespace Test.src.PrincipiosPOO.Coupling
{
    public class Orden
    {
        public void ColocarOrden()
        {
            // Logica de colocar orden
            EnviadorMail enviadorMail = new();
            enviadorMail.EnviarMail("Orden colocada exitosamente");
        }

    }
}