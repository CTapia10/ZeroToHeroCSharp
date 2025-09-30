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

