using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoCaixaEletronico
{
    public class Conta
    {
        private double saldo;
        private double limite;

        public Conta()
        {
            this.saldo = 0;
            this.limite = 0;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public double GetLimite()
        {
            return limite;
        }

        public void SetLimite(double limite)
        { 
            this.limite = limite;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo + limite >= valor)
            {
                saldo -= valor;
            
            }
        }

        public void Transferir(Conta c, double valor)
        {
            if (saldo + limite >= valor)
            {
                saldo -= valor;
                c.Depositar(valor);
            }
        }
    }
}
