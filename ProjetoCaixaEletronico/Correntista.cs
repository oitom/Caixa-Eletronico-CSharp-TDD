using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoCaixaEletronico
{
    public class Correntista
    {
        private string cpf;
        private string nome;
        private Conta conta;

        public Correntista(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
            conta = new Conta();
        }

        public string GetCpf()
        {
            return cpf;
        }
    }
}
