using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjetoCaixaEletronico;

namespace testes
{
    class TesteConta
    {
        private Conta c;
        
        // Executado no início de cada teste
        [SetUp]
        public void Init()
        {
            c = new Conta();
        }

        // Executado no final de cada teste
        [TearDown]
        public void Cleanup() 
        { 
            // 
        }

        [Test]
        public void Criar_Conta()
        {
            Assert.IsNotNull(c);
        }

        [Test]
        public void Verificar_Saldo_Zero()
        {
            Assert.AreEqual(0, c.GetSaldo());
        }

        [Test]
        public void Verificar_Limite_Zero()
        {
            Assert.AreEqual(0, c.GetLimite());
        }

        [Test]
        public void Verificar_Depositar_Valor_Inteiro()
        {
            c.Depositar(50);
            Assert.AreEqual(50, c.GetSaldo());
        }
        
        [Test]
        public void Verificar_Depositar_Valor_Real()
        {
            c.Depositar(50.20);
            Assert.AreEqual(50.20, c.GetSaldo());
        }

        [Test]
        public void Verificar_Sacar_Dentro_do_Saldo()
        {
            c.Depositar(100);
            c.Sacar(50);
            Assert.AreEqual(50, c.GetSaldo());
        }

        [Test]
        public void Verificar_Sacar_Fora_do_Saldo()
        {
            c.Depositar(100);
            c.Sacar(150);
            Assert.AreEqual(100, c.GetSaldo());
        }

        [Test]
        public void Verificar_Sacar_Fora_do_Saldo_Dentro_do_Limite()
        {
            c.Depositar(100);
            c.SetLimite(100);
            c.Sacar(150);
            Assert.AreEqual(-50, c.GetSaldo());
        }

        [Test]
        public void Verificar_Sacar_Fora_do_Saldo_Fora_do_Limite()
        {
            c.Depositar(100);
            c.SetLimite(100);
            c.Sacar(250);
            Assert.AreEqual(100, c.GetSaldo());
        }

        [Test]
        public void Verificar_Sacar_Varias_Vezes()
        {
            c.Depositar(500);
            c.SetLimite(500);

            c.Sacar(100);
            Assert.AreEqual(400, c.GetSaldo());

            c.Sacar(50);
            Assert.AreEqual(350, c.GetSaldo());

            c.Sacar(350);
            Assert.AreEqual(0, c.GetSaldo());

            c.Sacar(300);
            Assert.AreEqual(-300, c.GetSaldo());

            c.Sacar(350);
            Assert.AreEqual(-300, c.GetSaldo());

            c.Sacar(200);
            Assert.AreEqual(-500, c.GetSaldo());

            c.Sacar(1);
            Assert.AreEqual(-500, c.GetSaldo());
        }

        [Test]
        public void Verificar_Transferir()
        {
            Conta c2 = new Conta();

            c.Depositar(500);
            c.Transferir(c2, 100);

            Assert.AreEqual(400, c.GetSaldo());
            Assert.AreEqual(100, c2.GetSaldo());
        }

    }
}
