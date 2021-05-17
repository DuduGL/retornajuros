using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetornaJuros.Services.Implementations;
using RetornaJuros.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetornaJuros.Test
{
    [TestClass]
    public class RetornaJurosTest
    {
        public readonly IRetornaJurosService retornaJurosService;

        public RetornaJurosTest()
        {
            retornaJurosService = new RetornaJurosService();
        }

        [TestMethod]
        public void RetarnaJuros_Deve_Retornar_1 ()
        {
            //Act
            decimal juros = retornaJurosService.RetornaJuros();

            //Assert
            Assert.AreEqual(juros, (decimal)0.01);
        }
    }
}
