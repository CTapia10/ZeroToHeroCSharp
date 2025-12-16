namespace Test.src.PrincipiosPOO.Herencia
{
    public class Vehiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Anio { get; set; }
        
        public virtual void Arrancar()
        {
            Console.WriteLine("El vehiculo se esta encendiendo...");
        }
        public virtual void Apagar()
        {
            Console.WriteLine("El vehiculo se esta apagando...");
        }
    }

}