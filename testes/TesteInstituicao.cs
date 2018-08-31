using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjetoCaixaEletronico;

namespace testes
{
    class TesteInstituicao
    {
        
        [Test]
        public void Criar_Instuicao()
        {
            Instituicao i = new Instituicao();
            Assert.IsNotNull(i);
        }
        [Test]
        public void Verificar_Lista_Correntista()
        {
            Instituicao i = new Instituicao();
            Assert.IsNotNull(i.GetCorrentistas());
        }

        [Test]
        public void Verificar_Lista_Correntista_Vazia()
        {
            Instituicao i = new Instituicao();
            Assert.IsEmpty(i.GetCorrentistas());
        }

        [Test]
        public void Verificar_Cadastro_Correntista()
        {
            Instituicao i = new Instituicao();
            i.CadastrarCorrentista("111","João");
            Assert.IsNotEmpty(i.GetCorrentistas());
        }

        [Test]
        public void Verificar_Mais_De_Um_Cadastro_Correntista()
        {
            Instituicao i = new Instituicao();
            i.CadastrarCorrentista("111","João");
            i.CadastrarCorrentista("222", "Maria");
            i.CadastrarCorrentista("333", "Pedro");
            Assert.AreEqual(3, i.GetCorrentistas().Count);
        }

        [Test]
        public void Verificar_Correntista_Com_Mesmo_Cpf()
        {
            Instituicao i = new Instituicao();
            i.CadastrarCorrentista("111", "João");
            i.CadastrarCorrentista("111", "João");
            Assert.AreEqual(1, i.GetCorrentistas().Count);
        }

        [Test]
        public void Verificar_Buscar_Correntista_Existente_Por_Cpf()
        {
            Instituicao i = new Instituicao();
            i.CadastrarCorrentista("111", "João");
            i.CadastrarCorrentista("222", "Maria");
            Assert.IsNotNull(i.BuscarCorrentistaPorCpf("111"));
        }

        [Test]
        public void Verificar_Buscar_Correntista_Inexistente_Por_Cpf()
        {
            Instituicao i = new Instituicao();
            i.CadastrarCorrentista("111", "João");
            i.CadastrarCorrentista("222", "Maria");
            Assert.IsNull(i.BuscarCorrentistaPorCpf("333"));
        }
    }
}
