//***/ Encapsulation:
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


//*** Abstraccion:
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

//*** Herencia:  ***//
// using Test.src.PrincipiosPOO.Herencia;

// var auto = new Auto();

// // Compartido
// auto.Marca = "Ford";
// auto.Arrancar();
// auto.Apagar();

// // Unico
// auto.NumeroDePuertas = 4;


// //*** Polymorfismo: ***//
// // El polymorfismo es la habilidad que tiene un objeto para tener varias formas
// using Test.src.PrincipiosPOO.Polymorfismo;
// //List<object> vehiculos = [];
// List<Vehiculo> vehiculos = [];
// vehiculos.Add(new Auto { Marca = "Ford", Modelo = "Modelo1", Anio = 2025, NumeroDePuertas = 4 });
// vehiculos.Add(new Motocicleta { Marca = "Motito", Modelo = "ModeloGod", Anio = 2025 });

// // Inspeccion de vehiculo
// foreach (var vehiculo in vehiculos)
// {
//     // if (vehiculo is Auto)
//     // {
//     //     var auto = (Auto)vehiculo;
//     //     auto.Arrancar();
//     // }
//     // else if (vehiculo is Motocicleta)
//     // {
//     //     var motocicleta = (Motocicleta)vehiculo;
//     //     motocicleta.Arrancar();
//     // }
//     vehiculo.Arrancar();
// }


//*** Coupling: ***//

// // El nivel de dependencia entre diferentes clases (Si modifico una clase ver que no rompa otra)
// using Test.src.PrincipiosPOO.Coupling;
// var orden = new Orden(new EnviadorMail());
// var ordensms = new Orden(new EnviadorSMS());
// orden.ColocarOrden();
// ordensms.ColocarOrden();


//*** Composicion ***//

// // La composicion involucra crear objetos complejos combinando objetos mas simples o componentes. En composicion, estos objetos
// // se juntan para formar estructuras mas grandes, con cada componente manteniendo su propio estado y comportamiento, en otros terminos
// // la composicion es un tipo de "tiene una" relacion con (Objeto principal delega tareas a los otros componentes u objetos simples).

// using Test.src.PrincipiosPOO.Composicion;
// var auto = new Auto();
// auto.Arrancar();

//*** Composicion vs Herencia ***//

// Cuando usar Composicion:
// 1. Cuando se necesita mas flexibilidad construyendo los objetos ensamblando componentes reusables mas pequenios
// 2. Cuando no "es una" clara relacion entre clases y es mas un "tiene una" relacion
// 3. Cuando se quiere evitar las limitaciones de la herencia

// Cuando usar Herencia
// 1. Cuando "es una" clara relacion entre clases y los objetos subclase se pueden tratar como instancias de superclases
// 2. Cuando se quiere promover reutilizacion de codigo heredando propiedades y comportamientos de clases existentes
// 3. Cuando se quiere aprovechar el polymorfismo que permite a los objetos de diferentes subclases que sean tratados uniformemente
// a traves de sus comun interface superclase



//*** Problema de la Clase Base Frágil y por qué deberías usar composición en lugar de herencia ***//

// El Problema de la Clase Base Frágil es un problema de diseño de software que surge en la programación orientada a objetos 
// cuando los cambios realizados en una clase base pueden romper inadvertidamente la funcionalidad de las clases derivadas.
// Este problema ocurre debido al fuerte acoplamiento entre las clases base y derivadas en jerarquías de herencia.

// Acoplamiento por herencia:
// La herencia crea un acoplamiento fuerte entre la clase base (superclase) y las clases derivadas (subclases).
// Cualquier cambio realizado en la clase base puede potencialmente afectar el comportamiento de todas las clases derivadas.

// Extensibilidad limitada:
// El Problema de la Clase Base Frágil limita la extensibilidad de los sistemas de software, ya que las modificaciones a la clase base
// pueden volverse cada vez más riesgosas y costosas con el tiempo.
// Los desarrolladores pueden evitar realizar los cambios necesarios por miedo a romper funcionalidades existentes —lo que genera software frágil—

// Estrategias de mitigación:
// Para mitigar el Problema de la Clase Base Frágil, los desarrolladores de software pueden usar principios de diseño como el Principio Abierto/Cerrado (OCP)
// y el Principio de Inversión de Dependencias (DIP), así como patrones de diseño como Composición sobre Herencia.
// Estos enfoques promueven un acoplamiento débil, encapsulación y diseño modular, reduciendo el impacto de los cambios en las clases base.


//*** Principios SOLID: ***//

// Single Responsibility Principle (SRP)
// Una clase tiene que tener solo una razon para cambiar, esto significa que tiene que tener solo una responsabilidad o proposito

// Open/Closed Principle (OCP)
// Entidades de Software (Clases,modulos,funciones etc.) Deben estar abiertas a extensiones pero cerradas a modificaciones