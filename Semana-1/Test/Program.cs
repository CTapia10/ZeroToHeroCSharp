//***/ Encapsulation
using Test.src.PrincipiosPOO.Encapsulation;
using Test.src.PrincipiosPOO.Herencia;


//*** Mala encapsulacion:
// BadBankAccount badAccount = new BadBankAccount();
// badAccount.balance = 100;
// System.Console.WriteLine(badAccount.balance);

// // Creo el objeto cuenta bancaria con un monto de 100 inicial
// BankAccount bankAccount = new BankAccount(100);
// System.Console.WriteLine(bankAccount.GetBalance());

// // Deposito 50 unidades
// bankAccount.Depositar(50);
// System.Console.WriteLine(bankAccount.GetBalance());

// // Retiro 140 unidades
// bankAccount.Retirar(140);
// System.Console.WriteLine(bankAccount.GetBalance());

// // Intento retirar 20 unidades (no deberia dejarme porque no hay saldo)
// bankAccount.Retirar(20);
// System.Console.WriteLine(bankAccount.GetBalance());


//***Abstraccion***///
// Reduce la complejidad escondiendo detalles innecesarios para el usuario

// Por ejemplo pasar de esto:
// using Test.src.PrincipiosPOO.Abstraccion;

// ServicioEmail servicioEmail = new ServicioEmail();
// ServicioEmail.Conectar();
// ServicioEmail.Autentificar();
// ServicioEmail.EnviarMail();
// ServicioEmail.Desconectar();

// A esto:
// using Test.src.PrincipiosPOO.Abstraccion;

// ServicioEmail servicioEmail = new ServicioEmail();
// ServicioEmail.EnviarMail(); // Guardando todo el proceso interno dentro de EnviarEmail()

//*** Herencia ***//
// using Test.src.PrincipiosPOO.Herencia;

// var auto = new Auto();

// // Compartido
// auto.Marca = "Ford";
// auto.Arrancar();
// auto.Apagar();

// // Unico
// auto.NumeroDePuertas = 4;


//*** Polymorfismo ***//
// El polymorfismo es la habilidad que tiene un objeto para tener varias formas
using Test.src.PrincipiosPOO.Polymorfismo;
//List<object> vehiculos = [];
List<Vehiculo> vehiculos = [];
vehiculos.Add(new Auto { Marca = "Ford", Modelo = "Modelo1", Anio = 2025, NumeroDePuertas = 4 });
vehiculos.Add(new Motocicleta { Marca = "Motito", Modelo = "ModeloGod", Anio = 2025 });

// Inspeccion de vehiculo
foreach (var vehiculo in vehiculos)
{
    // if (vehiculo is Auto)
    // {
    //     var auto = (Auto)vehiculo;
    //     auto.Arrancar();
    // }
    // else if (vehiculo is Motocicleta)
    // {
    //     var motocicleta = (Motocicleta)vehiculo;
    //     motocicleta.Arrancar();
    // }
    vehiculo.Arrancar();
}
