// Encapsulation
using Test.src.PrincipiosPOO.Encapsulation;

// Mala encapsulacion:
// BadBankAccount badAccount = new BadBankAccount();
// badAccount.balance = 100;
// System.Console.WriteLine(badAccount.balance);

BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Depositar(50);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Retirar(140);

System.Console.WriteLine(bankAccount.GetBalance());

