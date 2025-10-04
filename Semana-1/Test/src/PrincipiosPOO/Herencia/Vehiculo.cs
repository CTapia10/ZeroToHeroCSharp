namespace Test.src.PrincipiosPOO.Herencia
{
    public class Vehiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Anio { get; set; }
        
        public void Arrancar()
        {
            Console.WriteLine("El vehiculo se esta encendiendo...");
        }
        public void Apagar()
        {
            Console.WriteLine("El vehiculo se esta apagando...");
        }
    }

}