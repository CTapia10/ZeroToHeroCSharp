using Test.src.PrincipiosPOO.Herencia;
namespace Test.src.PrincipiosPOO.Polymorfismo
{
    public class Motocicleta : Vehiculo
    {
        public int NumeroDeRuedas { get; set; }

        public override void Arrancar()
        {
            Console.WriteLine("El avion se esta encendiendo...");
        }
        public override void Apagar()
        {
            Console.WriteLine("El avion se esta apagando...");
        }
    }

}