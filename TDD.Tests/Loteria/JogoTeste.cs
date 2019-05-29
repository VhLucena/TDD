using System;
using System.Collections.Generic;
using Loteria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests.Loteria
{
    [TestClass]
    public class JogoTeste
    {
        [TestMethod]
        public void Deve_InicializarUmaCartela()
        {
            var jogo = new Jogo();

            var cartela = new Cartela(1,2,3,4,5,6);

            jogo.AdicionarCartela(cartela);

            Assert.AreEqual(jogo.Cartelas[0], cartela);
        }


        [TestMethod]
        public void Deve_InicializarCincoCartelas()
        {

        }
    }
}
