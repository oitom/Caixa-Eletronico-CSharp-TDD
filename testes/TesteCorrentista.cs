using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjetoCaixaEletronico;

namespace testes
{
    class TesteCorrentista
    {
        [Test]
        public void Criar_Corresntista()
        {
            Correntista c = new Correntista("111", "João");
            Assert.IsNotNull(c);
        }

    }
}
