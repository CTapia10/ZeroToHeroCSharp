// Encapsulation
using Test.src.PrincipiosPOO.Encapsulation;

// Mala encapsulacion:
// BadBankAccount badAccount = new BadBankAccount();
// badAccount.balance = 100;
// System.Console.WriteLine(badAccount.balance);

// Creo el objeto cuenta bancaria con un monto de 100 inicial
BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine(bankAccount.GetBalance());

// Deposito 50 unidades
bankAccount.Depositar(50);
System.Console.WriteLine(bankAccount.GetBalance());

// Retiro 140 unidades
bankAccount.Retirar(140);
System.Console.WriteLine(bankAccount.GetBalance());

// Intento retirar 20 unidades (no deberia dejarme porque no hay saldo)
bankAccount.Retirar(20);
System.Console.WriteLine(bankAccount.GetBalance());


// Abstraccion
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