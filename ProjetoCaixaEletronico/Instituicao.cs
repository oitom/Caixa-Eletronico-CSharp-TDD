using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoCaixaEletronico
{
    public class Instituicao
    {
        private List<Correntista> correntistas;

        public Instituicao()
        {
            correntistas = new List<Correntista>();
        }

        public List<Correntista> GetCorrentistas()
        {
            return correntistas;
        }

        public void CadastrarCorrentista(string cpf, string nome)
        {
            if (BuscarCorrentistaPorCpf(cpf) == null)
            {
                Correntista c = new Correntista(cpf, nome);
                correntistas.Add(c);
            }
        }

        public Correntista BuscarCorrentistaPorCpf(string cpf)
        {
            foreach (Correntista correntista in correntistas)
            {
                if (correntista.GetCpf().Equals(cpf))
                {
                    return correntista;
                }
            }
            return null;
        }
    }
}
