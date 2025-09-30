using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Test.src.PrincipiosPOO.Encapsulation
{
// Creo nueva clase BadBankAccount con  balance publico, mala practica (Da acceso a modificaciones desde cualquier lugar)
    public class BadBankAccount
    {
        public decimal balance;

    }
}