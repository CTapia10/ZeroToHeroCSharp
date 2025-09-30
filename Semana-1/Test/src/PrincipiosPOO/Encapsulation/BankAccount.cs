using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.PrincipiosPOO.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Depositar(balance);
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El deposito tiene que ser un numero positivo");
            }
            this.balance += monto;
        }

        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto a retirar tiene que ser mayor a 0");
            }
            if (monto > balance)
            {
                throw new ArgumentException("No hay suficiente dinero para retirar");
            }
            this.balance -= monto;
        }
    }
}