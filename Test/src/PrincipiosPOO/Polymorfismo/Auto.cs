using Test.src.PrincipiosPOO.Herencia;
namespace Test.src.PrincipiosPOO.Polymorfismo
{
    public class Auto : Vehiculo
    {
        public int NumeroDePuertas { get; set; }

        public int NumeroDeRuedas { get; set; }

        public override void Arrancar()
        {
            Console.WriteLine("El automovil se esta encendiendo...");
        }
        public override void Apagar()
        {
            Console.WriteLine("El automovil se esta apagando...");
        }
    }

}
    
